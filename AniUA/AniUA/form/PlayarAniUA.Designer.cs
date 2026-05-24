namespace AniUA.form
{
    partial class PlayarAniUA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayarAniUA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerText = new System.Windows.Forms.Label();
            this.headerLogo = new System.Windows.Forms.PictureBox();
            this.buttTurn = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.headerText);
            this.panel1.Controls.Add(this.headerLogo);
            this.panel1.Controls.Add(this.buttTurn);
            this.panel1.Controls.Add(this.buttClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 27);
            this.panel1.TabIndex = 1;
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
            this.headerText.Size = new System.Drawing.Size(97, 23);
            this.headerText.TabIndex = 4;
            this.headerText.Text = "AniUA — ";
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
            // 
            // PlayarAniUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1224, 747);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayarAniUA";
            this.Text = "PlayarAniUA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox headerLogo;
        private System.Windows.Forms.Button buttTurn;
        private System.Windows.Forms.Button buttClose;
    }
}