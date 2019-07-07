using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkVideoCutter
{
    public partial class FfmpegConf : Form
    {
        public FfmpegConf()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ffmpeg.zeranoe.com/builds/");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "ffmpeg.exe|ffmpeg.exe";
            if (o.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text= o.FileName;

                buttonOK.Enabled = true;
                labelSelected.Text = "FFMPEG file selected. Let's try this out...";
            }
        }

        private void DarkButton1_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(textBox1.Text))
            {
                MessageBox.Show("File does not exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Properties.Settings.Default.FfmpegLocation = textBox1.Text;
                Properties.Settings.Default.Save();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textBox1.Text) == true)
                buttonOK.Enabled = true;
        }

        private void FfmpegConf_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                if (MessageBox.Show("Are you sure you want to exit without configuration?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
        }

        private void FfmpegConf_Load(object sender, EventArgs e)
        {

        }
    }
}
