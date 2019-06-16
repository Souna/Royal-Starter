namespace ServerPinger
{
    partial class FrmPinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPinger));
            this.btnCheckIP = new System.Windows.Forms.Button();
            this.btnStopPinging = new System.Windows.Forms.Button();
            this.nmrPingDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPlaySong = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLaunchPath = new System.Windows.Forms.TextBox();
            this.chkLaunchProgram = new System.Windows.Forms.CheckBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnSoundLocation = new System.Windows.Forms.Button();
            this.radLoginServer = new System.Windows.Forms.RadioButton();
            this.radGameServer = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radLoginServer2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPingDelay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckIP
            // 
            this.btnCheckIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIP.Location = new System.Drawing.Point(281, 189);
            this.btnCheckIP.Name = "btnCheckIP";
            this.btnCheckIP.Size = new System.Drawing.Size(85, 29);
            this.btnCheckIP.TabIndex = 1;
            this.btnCheckIP.Text = "Start";
            this.btnCheckIP.UseVisualStyleBackColor = true;
            this.btnCheckIP.Click += new System.EventHandler(this.BtnCheckIP_Click);
            // 
            // btnStopPinging
            // 
            this.btnStopPinging.Enabled = false;
            this.btnStopPinging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopPinging.Location = new System.Drawing.Point(375, 189);
            this.btnStopPinging.Name = "btnStopPinging";
            this.btnStopPinging.Size = new System.Drawing.Size(85, 29);
            this.btnStopPinging.TabIndex = 2;
            this.btnStopPinging.Text = "Stop";
            this.btnStopPinging.UseVisualStyleBackColor = true;
            this.btnStopPinging.Click += new System.EventHandler(this.BtnStopPinging_Click);
            // 
            // nmrPingDelay
            // 
            this.nmrPingDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrPingDelay.Location = new System.Drawing.Point(105, 146);
            this.nmrPingDelay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmrPingDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPingDelay.Name = "nmrPingDelay";
            this.nmrPingDelay.Size = new System.Drawing.Size(39, 22);
            this.nmrPingDelay.TabIndex = 5;
            this.nmrPingDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPingDelay.ValueChanged += new System.EventHandler(this.NmrPingDelay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Check every:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "second";
            // 
            // chkPlaySong
            // 
            this.chkPlaySong.AutoSize = true;
            this.chkPlaySong.Checked = true;
            this.chkPlaySong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlaySong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlaySong.Location = new System.Drawing.Point(16, 85);
            this.chkPlaySong.Name = "chkPlaySong";
            this.chkPlaySong.Size = new System.Drawing.Size(167, 20);
            this.chkPlaySong.TabIndex = 1;
            this.chkPlaySong.TabStop = false;
            this.chkPlaySong.Text = "Play sound when online";
            this.chkPlaySong.UseVisualStyleBackColor = true;
            this.chkPlaySong.CheckedChanged += new System.EventHandler(this.ChkPlaySong_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(469, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 29);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear Log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtLaunchPath
            // 
            this.txtLaunchPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaunchPath.Location = new System.Drawing.Point(16, 48);
            this.txtLaunchPath.Name = "txtLaunchPath";
            this.txtLaunchPath.ReadOnly = true;
            this.txtLaunchPath.Size = new System.Drawing.Size(219, 22);
            this.txtLaunchPath.TabIndex = 11;
            this.txtLaunchPath.Text = "C:\\MapleRoyals\\MapleRoyals.exe";
            this.txtLaunchPath.Visible = false;
            this.txtLaunchPath.Click += new System.EventHandler(this.TxtLaunchPath_Click);
            // 
            // chkLaunchProgram
            // 
            this.chkLaunchProgram.AutoSize = true;
            this.chkLaunchProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLaunchProgram.Location = new System.Drawing.Point(16, 22);
            this.chkLaunchProgram.Name = "chkLaunchProgram";
            this.chkLaunchProgram.Size = new System.Drawing.Size(189, 20);
            this.chkLaunchProgram.TabIndex = 12;
            this.chkLaunchProgram.TabStop = false;
            this.chkLaunchProgram.Text = "Launch Royals when online";
            this.chkLaunchProgram.UseVisualStyleBackColor = true;
            this.chkLaunchProgram.CheckedChanged += new System.EventHandler(this.ChkLaunchProgram_CheckedChanged);
            // 
            // lstLog
            // 
            this.lstLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(12, 79);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(263, 139);
            this.lstLog.TabIndex = 13;
            this.lstLog.DoubleClick += new System.EventHandler(this.LstLog_DoubleClick);
            // 
            // btnSoundLocation
            // 
            this.btnSoundLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoundLocation.Location = new System.Drawing.Point(16, 111);
            this.btnSoundLocation.Name = "btnSoundLocation";
            this.btnSoundLocation.Size = new System.Drawing.Size(163, 25);
            this.btnSoundLocation.TabIndex = 15;
            this.btnSoundLocation.TabStop = false;
            this.btnSoundLocation.Text = "Custom sound file...";
            this.btnSoundLocation.UseVisualStyleBackColor = true;
            this.btnSoundLocation.Click += new System.EventHandler(this.btnSoundLocation_Click);
            // 
            // radLoginServer
            // 
            this.radLoginServer.AutoSize = true;
            this.radLoginServer.Checked = true;
            this.radLoginServer.Location = new System.Drawing.Point(15, 21);
            this.radLoginServer.Name = "radLoginServer";
            this.radLoginServer.Size = new System.Drawing.Size(112, 20);
            this.radLoginServer.TabIndex = 16;
            this.radLoginServer.TabStop = true;
            this.radLoginServer.Text = "Login Server 1";
            this.radLoginServer.UseVisualStyleBackColor = true;
            // 
            // radGameServer
            // 
            this.radGameServer.AutoSize = true;
            this.radGameServer.Location = new System.Drawing.Point(15, 44);
            this.radGameServer.Name = "radGameServer";
            this.radGameServer.Size = new System.Drawing.Size(106, 20);
            this.radGameServer.TabIndex = 17;
            this.radGameServer.Text = "Game Server";
            this.radGameServer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.radLoginServer2);
            this.groupBox2.Controls.Add(this.radLoginServer);
            this.groupBox2.Controls.Add(this.radGameServer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 70);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // radLoginServer2
            // 
            this.radLoginServer2.AutoSize = true;
            this.radLoginServer2.BackColor = System.Drawing.Color.Transparent;
            this.radLoginServer2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.radLoginServer2.Location = new System.Drawing.Point(133, 21);
            this.radLoginServer2.Name = "radLoginServer2";
            this.radLoginServer2.Size = new System.Drawing.Size(112, 20);
            this.radLoginServer2.TabIndex = 18;
            this.radLoginServer2.Text = "Login Server 2";
            this.radLoginServer2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPlaySong);
            this.groupBox1.Controls.Add(this.txtLaunchPath);
            this.groupBox1.Controls.Add(this.btnSoundLocation);
            this.groupBox1.Controls.Add(this.chkLaunchProgram);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmrPingDelay);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(281, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 180);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Note: Use Login Server 1, it works better =)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPinger
            // 
            this.AcceptButton = this.btnCheckIP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(563, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStopPinging);
            this.Controls.Add(this.btnCheckIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royals Status Checker";
            ((System.ComponentModel.ISupportInitialize)(this.nmrPingDelay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckIP;
        private System.Windows.Forms.Button btnStopPinging;
        private System.Windows.Forms.NumericUpDown nmrPingDelay;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPlaySong;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLaunchPath;
        private System.Windows.Forms.CheckBox chkLaunchProgram;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnSoundLocation;
        private System.Windows.Forms.RadioButton radLoginServer;
        private System.Windows.Forms.RadioButton radGameServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radLoginServer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

