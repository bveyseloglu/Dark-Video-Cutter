using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Diagnostics;
using System.Threading;

namespace DarkVideoCutter
{
    public partial class Form1 : Form
    {

        string fileOpened = "", cutCommand = "", outputFile = "", fileName = "";
        long previousFileLenght = 0;
        int waitFileTimeout = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void ControlsEnable(bool status)
        {
            buttonMenu.Enabled = buttonCut.Enabled = trackBar1.Enabled = trackBar2.Enabled = textBox1.Enabled = textBox2.Enabled = status;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";

            // check for ffmpeg. if ffmpeg has not configured, show the configuration dialog
            if (Properties.Settings.Default.FfmpegLocation == "" || System.IO.File.Exists(Properties.Settings.Default.FfmpegLocation) == false)
            {
                this.Hide();
                FfmpegConf ff = new FfmpegConf();
                ff.textBox1.Text = Properties.Settings.Default.FfmpegLocation;
                if (ff.ShowDialog() != DialogResult.OK)
                    Application.Exit();
            }

            SetStatus("Open a video file from menu.", WorkingStatus.Idle);
        }

        public enum WorkingStatus
        {
            Idle,
            Busy,
            Error,
            Success
        }

        public void SetStatus(string newStatus, WorkingStatus workingStatus)
        {
            labelStatus.Text = newStatus;

            if (workingStatus == WorkingStatus.Idle) pictureBoxStatus.Image = DarkVideoCutter.Properties.Resources.logo;
            else if (workingStatus == WorkingStatus.Busy) pictureBoxStatus.Image = DarkVideoCutter.Properties.Resources.load;
            else if (workingStatus == WorkingStatus.Error) pictureBoxStatus.Image = DarkVideoCutter.Properties.Resources.error;
            else if (workingStatus == WorkingStatus.Success) pictureBoxStatus.Image = DarkVideoCutter.Properties.Resources.success;
        }

        private void DarkButton1_MouseUp(object sender, MouseEventArgs e)
        {
            // draw menu
            Point pnt;

            pnt = buttonMenu.PointToScreen(new Point(0, 0));
            pnt = this.PointToClient(pnt);

            darkContextMenu1.Show(this, pnt);            
        }

        private void OpenVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Video Files(*.mp4;*.mov;*.avi;*.wmv;*.mkv)|*.mp4;*.mov;*.avi;*.wmv;*.mkv|All files (*.*)|*.*";

            if (o.ShowDialog() == DialogResult.OK)
            {
                fileOpened = o.FileName;
                fileName = Path.GetFileName(o.FileName);

                // set status
                SetStatus(Path.GetFileName(o.FileName), WorkingStatus.Idle);

                // preview video
                axWindowsMediaPlayer1.URL = o.FileName;
                axWindowsMediaPlayer1.settings.volume = 0;

                // enable controls
                trackBar1.Enabled = true;
                trackBar2.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                labelVideoPosition.Visible = true;

                // get video duration then configure bars and textboxes
                var player = new WindowsMediaPlayer();
                var clip = player.newMedia(o.FileName);
                textBox1.Text = labelVideoPosition.Text= "00:00:00.0";

                string vidLenght = TimeSpan.FromSeconds(clip.duration).ToString();

                if (vidLenght.Contains(".") == false) vidLenght += ".0";

                textBox2.Text = vidLenght.Substring(0,10);
                trackBar1.Maximum = Convert.ToInt32(textBox2.Text.Substring(0,2))*3600 + Convert.ToInt32(textBox2.Text.Substring(3, 2)) * 60 + Convert.ToInt32(textBox2.Text.Substring(6, 2));
                trackBar2.Maximum = trackBar1.Maximum;
                trackBar1.Value = 0;
                trackBar2.Value = trackBar2.Maximum;

                // reset media player
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                // start timer to update video position label
                timerCheckVideoEnd.Start();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL == "")
                SetStatus("Please open a video file first.", WorkingStatus.Idle);
            else
            {
                // check for start and end positions are same
                if (textBox1.Text == textBox2.Text)
                {
                    SetStatus("The starting and ending points can not be same.", WorkingStatus.Error);
                    return;
                }

                // find the duration of the cutted part

                // first, convert the starting and ending points to seconds
                int endPointInSecs = Convert.ToInt32(textBox2.Text.Substring(0, 2)) * 3600 + Convert.ToInt32(textBox2.Text.Substring(3, 2)) * 60 + Convert.ToInt32(textBox2.Text.Substring(6, 2));
                int startPointInSecs = Convert.ToInt32(textBox1.Text.Substring(0, 2)) * 3600 + Convert.ToInt32(textBox1.Text.Substring(3, 2)) * 60 + Convert.ToInt32(textBox1.Text.Substring(6, 2));

                int duration = endPointInSecs - startPointInSecs;

                // convert seconds to h, m, s
                int hour = (int)duration / 3600;
                int min = (int)(duration - hour * 3600) / 60;
                int sec = (int)duration - hour * 3600 - min * 60;

                // find ms
                int ms;

                if (Convert.ToInt32(textBox2.Text.Substring(9, 1)) >= Convert.ToInt32(textBox1.Text.Substring(9, 1)))
                    ms = Convert.ToInt32(textBox2.Text.Substring(9, 1)) - Convert.ToInt32(textBox1.Text.Substring(9, 1));
                else { 
                    ms = Convert.ToInt32(textBox2.Text.Substring(9, 1)) + 10 - Convert.ToInt32(textBox1.Text.Substring(9, 1));
                    sec--;
                }

                // generate command for ffmpeg
                outputFile = Path.GetDirectoryName(fileOpened) + "\\" + Path.GetFileNameWithoutExtension(fileOpened) + " " + textBox1.Text.Replace(":", ".").Replace(",", ".") + " - " + " " + textBox2.Text.Replace(":", ".").Replace(",", ".") + Path.GetExtension(fileOpened);
                cutCommand = "-ss " + textBox1.Text.Replace(",", ".") + " -i " + "\"" + fileOpened + "\" -to " + hour + ":"+ min + ":" + sec + "." + ms + " -c copy \"" + outputFile + "\"";

                // check for a file that may has a same name with output
                if (System.IO.File.Exists(outputFile))
                {
                    SetStatus("There is a file with same output name at the output location. We can not continue.", WorkingStatus.Error);
                    return;
                }

                // check for ffmpeg
                if (!System.IO.File.Exists(Properties.Settings.Default.FfmpegLocation)) {
                    SetStatus("FFMPEG not found. Go to Menu and then select \"Configure...\" to continue.", WorkingStatus.Error);
                    return;
                }

                // disable controls
                ControlsEnable(false);

                // start work
                SetStatus("Cutting video...", WorkingStatus.Busy );

                previousFileLenght = 0;
                waitFileTimeout = 0;

                backgroundWorker1.RunWorkerAsync();
                timerCheckCutCompleted.Start();
            }
        }


        private void TimerCheckVideoEnd_Tick(object sender, EventArgs e)
        {
            // update video position label below the video
            int hour = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition / 3600;
            int min = (int)(axWindowsMediaPlayer1.Ctlcontrols.currentPosition - hour * 3600) / 60;
            int sec = ((int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition - hour * 3600 - min * 60);
            labelVideoPosition.Text = hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + ".0";

            // check for the last second of the cutted part of the video
            int last = Convert.ToInt32(textBox2.Text.Substring(0, 2)) * 3600 + Convert.ToInt32(textBox2.Text.Substring(3, 2)) * 60 + Convert.ToInt32(textBox2.Text.Substring(6, 2));

            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition.CompareTo(last) == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                timerCheckVideoEnd.Stop();
            }

        }

        public void PlayCuttedPart()
        {
            // play the cutted part
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(textBox1.Text.Substring(0, 2)) * 3600 + Convert.ToInt32(textBox1.Text.Substring(3, 2)) * 60 + Convert.ToInt32(textBox1.Text.Substring(6, 2));
            axWindowsMediaPlayer1.Ctlcontrols.play();

            timerCheckVideoEnd.Start();
        }

        public void ShowTheLastSec()
        {
            // show the last sec of the cutted part
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(textBox2.Text.Substring(0, 2)) * 3600 + Convert.ToInt32(textBox2.Text.Substring(3, 2)) * 60 + Convert.ToInt32(textBox2.Text.Substring(6, 2));
            axWindowsMediaPlayer1.Ctlcontrols.play();

            timerCheckVideoEnd.Start();
        }

        private void TrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            PlayCuttedPart();
        }

        private void TrackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            ShowTheLastSec();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SoundOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (soundOffToolStripMenuItem.Text == "Enable sound")
            {
                soundOffToolStripMenuItem.Text = "Disable sound";
                axWindowsMediaPlayer1.settings.volume = 100;
            }
            else
            {
                soundOffToolStripMenuItem.Text = "Enable sound";
                axWindowsMediaPlayer1.settings.volume = 0;
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value > trackBar2.Value)
            {
                trackBar1.Value = trackBar2.Value;
            }
            else
            {
                int hour = trackBar1.Value / 3600;
                int min = (trackBar1.Value - hour * 3600) / 60;
                int sec = (trackBar1.Value - hour * 3600 - min * 60);
                textBox1.Text = hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + "." + textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
            }

            SetStatus(fileName, WorkingStatus.Idle);
        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar2.Value < trackBar1.Value)
            {
                trackBar2.Value = trackBar1.Value;
            }
            else
            {
                int hour = trackBar2.Value / 3600;
                int min = (trackBar2.Value - hour * 3600) / 60;
                int sec = (trackBar2.Value - hour * 3600 - min * 60);
                textBox2.Text = hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + "." + textBox2.Text.Substring(textBox2.Text.Length - 1, 1);
            }

            SetStatus(fileName, WorkingStatus.Idle);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newValue = Convert.ToInt32(textBox1.Text.Substring(0, 2)) * 3600 + Convert.ToInt32(textBox1.Text.Substring(3, 2)) * 60 + Convert.ToInt32(textBox1.Text.Substring(6, 2));

                if (newValue > trackBar1.Maximum) trackBar1.Value = trackBar1.Maximum; else trackBar1.Value = newValue;

                SetStatus(fileName, WorkingStatus.Idle);
            }
            catch
            {
                // do nothing if the input is not valid
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newValue = Convert.ToInt32(textBox2.Text.Substring(0, 2)) * 3600 + Convert.ToInt32(textBox2.Text.Substring(3, 2)) * 60 + Convert.ToInt32(textBox2.Text.Substring(6, 2));

                if (newValue > trackBar2.Maximum) trackBar2.Value = trackBar2.Maximum; else trackBar2.Value = newValue;

                SetStatus(fileName, WorkingStatus.Idle);
            }
            catch
            {
                // do nothing
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bveyseloglu/Dark-Video-Cutter");
        }

        private void ConfigureFFMPEGLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FfmpegConf ff = new FfmpegConf();
            ff.labelTitle.Text = "Configure";
            ff.labelDesc.Text = "Select the location of FFMPEG library. We need it to cut the videos. You can download it from here:";
            ff.buttonOK.Text = "OK";
            ff.buttonOK.Enabled = true;
            ff.labelSelected.Visible = false;
            ff.textBox1.Text = Properties.Settings.Default.FfmpegLocation;
            ff.ShowDialog();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.FfmpegLocation, cutCommand);
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo = psi;
            p.Start();

            // it doenst work for some reason
            p.WaitForExit();
        }

        private void TimerCheckCutCompleted_Tick(object sender, EventArgs e)
        {
            // wait for process completed by checking the size of the output file.
            if (System.IO.File.Exists(outputFile) == true)
            {
                // if there is a file exist at the output location, then compare it's old and new sizes.
                // if sizes are equal, that means the ffmpeg process completed.
                FileInfo fi = new FileInfo(outputFile);
                if (previousFileLenght == fi.Length)
                {
                    SetStatus("Video cutted successfully. Check the video folder.",WorkingStatus.Success);
                    timerCheckCutCompleted.Stop();
                    ControlsEnable(true);
                }
                else
                {
                    previousFileLenght = fi.Length;
                }
            }
            else
            {
                // if there is no file at the output for some reason (e.g. admin rights), wait 5 secs
                if (waitFileTimeout > 5)
                {
                    SetStatus("Something went wrong. Admin rights or low space?",WorkingStatus.Error);
                    timerCheckCutCompleted.Stop();
                    ControlsEnable(true);
                }
                else
                    waitFileTimeout++;
            }

        }
    }
}
