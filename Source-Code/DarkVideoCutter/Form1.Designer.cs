namespace DarkVideoCutter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelVideoPosition = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.MaskedTextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.buttonMenu = new DarkUI.Controls.DarkButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonCut = new DarkUI.Controls.DarkButton();
            this.darkContextMenu1 = new DarkUI.Controls.DarkContextMenu();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.soundOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.configureFFMPEGLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCheckVideoEnd = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerCheckCutCompleted = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.darkContextMenu1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 491);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Controls.Add(this.axWindowsMediaPlayer1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelVideoPosition, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(638, 491);
            this.tableLayoutPanel2.TabIndex = 100;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(17, 17);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(604, 337);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // labelVideoPosition
            // 
            this.labelVideoPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVideoPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVideoPosition.ForeColor = System.Drawing.Color.DarkGray;
            this.labelVideoPosition.Location = new System.Drawing.Point(17, 363);
            this.labelVideoPosition.Name = "labelVideoPosition";
            this.labelVideoPosition.Size = new System.Drawing.Size(604, 22);
            this.labelVideoPosition.TabIndex = 97;
            this.labelVideoPosition.Text = "00:00:00.0";
            this.labelVideoPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.trackBar1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 402);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(604, 26);
            this.tableLayoutPanel3.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(507, 3);
            this.textBox1.Mask = "00:00:00.0";
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0000000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(43, 3);
            this.trackBar1.Maximum = 11000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(458, 20);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar1_MouseUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.trackBar2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(17, 448);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(604, 26);
            this.tableLayoutPanel4.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 91;
            this.label2.Text = "End:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(507, 3);
            this.textBox2.Mask = "00:00:00.0";
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0000000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new System.Drawing.Point(43, 3);
            this.trackBar2.Maximum = 11000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(458, 20);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 11000;
            this.trackBar2.ValueChanged += new System.EventHandler(this.TrackBar2_ValueChanged);
            this.trackBar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar2_MouseUp);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(3, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Padding = new System.Windows.Forms.Padding(5);
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DarkButton1_MouseUp);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelStatus.Location = new System.Drawing.Point(84, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(551, 26);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "status here";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCut
            // 
            this.buttonCut.Location = new System.Drawing.Point(0, 2);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCut.Size = new System.Drawing.Size(64, 23);
            this.buttonCut.TabIndex = 6;
            this.buttonCut.Text = "Cut";
            this.buttonCut.Click += new System.EventHandler(this.Button1_Click);
            // 
            // darkContextMenu1
            // 
            this.darkContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripSeparator1,
            this.openVideoToolStripMenuItem,
            this.toolStripSeparator2,
            this.soundOffToolStripMenuItem,
            this.toolStripSeparator4,
            this.configureFFMPEGLocationToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.darkContextMenu1.Name = "darkContextMenu1";
            this.darkContextMenu1.Size = new System.Drawing.Size(180, 186);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Enabled = false;
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // openVideoToolStripMenuItem
            // 
            this.openVideoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openVideoToolStripMenuItem.Name = "openVideoToolStripMenuItem";
            this.openVideoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openVideoToolStripMenuItem.Text = "Open video...";
            this.openVideoToolStripMenuItem.Click += new System.EventHandler(this.OpenVideoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // soundOffToolStripMenuItem
            // 
            this.soundOffToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.soundOffToolStripMenuItem.Name = "soundOffToolStripMenuItem";
            this.soundOffToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.soundOffToolStripMenuItem.Text = "Enable sound";
            this.soundOffToolStripMenuItem.Click += new System.EventHandler(this.SoundOffToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // configureFFMPEGLocationToolStripMenuItem
            // 
            this.configureFFMPEGLocationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.configureFFMPEGLocationToolStripMenuItem.Name = "configureFFMPEGLocationToolStripMenuItem";
            this.configureFFMPEGLocationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.configureFFMPEGLocationToolStripMenuItem.Text = "Configure...";
            this.configureFFMPEGLocationToolStripMenuItem.Click += new System.EventHandler(this.ConfigureFFMPEGLocationToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // timerCheckVideoEnd
            // 
            this.timerCheckVideoEnd.Interval = 40;
            this.timerCheckVideoEnd.Tick += new System.EventHandler(this.TimerCheckVideoEnd_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // timerCheckCutCompleted
            // 
            this.timerCheckCutCompleted.Interval = 1000;
            this.timerCheckCutCompleted.Tick += new System.EventHandler(this.TimerCheckCutCompleted_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 601);
            this.tableLayoutPanel1.TabIndex = 79;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonMenu);
            this.flowLayoutPanel1.Controls.Add(this.labelStatus);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(638, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 560);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(638, 32);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxStatus);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(562, 26);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatus.TabIndex = 4;
            this.pictureBoxStatus.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(571, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 26);
            this.panel2.TabIndex = 2;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(226, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(668, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(684, 640);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dark Video Cutter 1.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.darkContextMenu1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private DarkUI.Controls.DarkButton buttonMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TrackBar trackBar1;
        internal DarkUI.Controls.DarkButton buttonCut;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private DarkUI.Controls.DarkContextMenu darkContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timerCheckVideoEnd;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelVideoPosition;
        private System.Windows.Forms.ToolStripMenuItem soundOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timerCheckCutCompleted;
        private System.Windows.Forms.MaskedTextBox textBox1;
        private System.Windows.Forms.MaskedTextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem configureFFMPEGLocationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

