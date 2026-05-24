namespace AniUA.form
{
    partial class PlayerAniUA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerAniUA));
            this.header = new System.Windows.Forms.Panel();
            this.hideUI = new System.Windows.Forms.PictureBox();
            this.showUI = new System.Windows.Forms.PictureBox();
            this.headerText = new System.Windows.Forms.Label();
            this.headerLogo = new System.Windows.Forms.PictureBox();
            this.buttTurn = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.start = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.volume = new System.Windows.Forms.TrackBar();
            this.panel = new System.Windows.Forms.Panel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.textTime = new System.Windows.Forms.Label();
            this.timerPlayer = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.header.Controls.Add(this.hideUI);
            this.header.Controls.Add(this.showUI);
            this.header.Controls.Add(this.headerText);
            this.header.Controls.Add(this.headerLogo);
            this.header.Controls.Add(this.buttTurn);
            this.header.Controls.Add(this.buttClose);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1224, 27);
            this.header.TabIndex = 1;
            // 
            // hideUI
            // 
            this.hideUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideUI.Image = ((System.Drawing.Image)(resources.GetObject("hideUI.Image")));
            this.hideUI.Location = new System.Drawing.Point(1140, 0);
            this.hideUI.Name = "hideUI";
            this.hideUI.Size = new System.Drawing.Size(24, 27);
            this.hideUI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideUI.TabIndex = 6;
            this.hideUI.TabStop = false;
            this.hideUI.Click += new System.EventHandler(this.hideUU_Click);
            // 
            // showUI
            // 
            this.showUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showUI.Image = ((System.Drawing.Image)(resources.GetObject("showUI.Image")));
            this.showUI.Location = new System.Drawing.Point(1140, 0);
            this.showUI.Name = "showUI";
            this.showUI.Size = new System.Drawing.Size(24, 27);
            this.showUI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showUI.TabIndex = 5;
            this.showUI.TabStop = false;
            this.showUI.Click += new System.EventHandler(this.showUI_Click);
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerText.Font = new System.Drawing.Font("NAMU 1750", 14.25F);
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.headerText.Location = new System.Drawing.Point(30, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(157, 23);
            this.headerText.TabIndex = 4;
            this.headerText.Text = "AniUA — Плеєр";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerLogo
            // 
            this.headerLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerLogo.Image = ((System.Drawing.Image)(resources.GetObject("headerLogo.Image")));
            this.headerLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.headerLogo.Location = new System.Drawing.Point(0, 0);
            this.headerLogo.Name = "headerLogo";
            this.headerLogo.Size = new System.Drawing.Size(30, 27);
            this.headerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerLogo.TabIndex = 1;
            this.headerLogo.TabStop = false;
            // 
            // buttTurn
            // 
            this.buttTurn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttTurn.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttTurn.FlatAppearance.BorderSize = 0;
            this.buttTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttTurn.Font = new System.Drawing.Font("NAMU 1750", 12F);
            this.buttTurn.ForeColor = System.Drawing.Color.White;
            this.buttTurn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttTurn.Location = new System.Drawing.Point(1170, 0);
            this.buttTurn.Name = "buttTurn";
            this.buttTurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttTurn.Size = new System.Drawing.Size(27, 27);
            this.buttTurn.TabIndex = 3;
            this.buttTurn.Text = "—";
            this.buttTurn.UseVisualStyleBackColor = true;
            this.buttTurn.Click += new System.EventHandler(this.buttTurn_Click);
            this.buttTurn.MouseEnter += new System.EventHandler(this.buttTurn_MouseEnter);
            this.buttTurn.MouseLeave += new System.EventHandler(this.buttTurn_MouseLeave);
            // 
            // buttClose
            // 
            this.buttClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttClose.FlatAppearance.BorderSize = 0;
            this.buttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttClose.Font = new System.Drawing.Font("NAMU 1750", 12F);
            this.buttClose.ForeColor = System.Drawing.Color.White;
            this.buttClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttClose.Location = new System.Drawing.Point(1197, 0);
            this.buttClose.Name = "buttClose";
            this.buttClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttClose.Size = new System.Drawing.Size(27, 27);
            this.buttClose.TabIndex = 1;
            this.buttClose.Text = "X";
            this.buttClose.UseVisualStyleBackColor = true;
            this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
            this.buttClose.MouseEnter += new System.EventHandler(this.buttClose_MouseEnter);
            this.buttClose.MouseLeave += new System.EventHandler(this.buttClose_MouseLeave);
            // 
            // Player
            // 
            this.Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(0, 27);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(1224, 720);
            this.Player.TabIndex = 2;
            this.Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_PlayStateChange);
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.BackColor = System.Drawing.Color.Black;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(562, 310);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 100);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.start.TabIndex = 3;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pause.BackColor = System.Drawing.Color.Black;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(562, 310);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(100, 100);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause.TabIndex = 4;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1196, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // volume
            // 
            this.volume.Dock = System.Windows.Forms.DockStyle.Left;
            this.volume.LargeChange = 10;
            this.volume.Location = new System.Drawing.Point(0, 0);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volume.Size = new System.Drawing.Size(160, 26);
            this.volume.TabIndex = 6;
            this.volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume.Value = 50;
            this.volume.ValueChanged += new System.EventHandler(this.volume_ValueChanged);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.trackBar);
            this.panel.Controls.Add(this.textTime);
            this.panel.Controls.Add(this.volume);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 721);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1224, 26);
            this.panel.TabIndex = 7;
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.LargeChange = 30;
            this.trackBar.Location = new System.Drawing.Point(232, 0);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(964, 26);
            this.trackBar.TabIndex = 8;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // textTime
            // 
            this.textTime.AutoSize = true;
            this.textTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.textTime.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTime.ForeColor = System.Drawing.Color.White;
            this.textTime.Location = new System.Drawing.Point(160, 0);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(72, 19);
            this.textTime.TabIndex = 7;
            this.textTime.Text = "0:00:00";
            this.textTime.Click += new System.EventHandler(this.textTime_Click);
            // 
            // timerPlayer
            // 
            this.timerPlayer.Tick += new System.EventHandler(this.timerPlayer_Tick);
            // 
            // PlayerAniUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1224, 747);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerAniUA";
            this.Text = "PlayerAniUA";
            this.Load += new System.EventHandler(this.PlayerAniUA_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox headerLogo;
        private System.Windows.Forms.Button buttTurn;
        private System.Windows.Forms.Button buttClose;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label textTime;
        private System.Windows.Forms.Timer timerPlayer;
        private System.Windows.Forms.PictureBox hideUI;
        private System.Windows.Forms.PictureBox showUI;
    }
}