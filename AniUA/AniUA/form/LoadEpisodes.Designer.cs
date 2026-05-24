namespace AniUA.form
{
    partial class LoadEpisodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadEpisodes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerText = new System.Windows.Forms.Label();
            this.headerLogo = new System.Windows.Forms.PictureBox();
            this.buttTurn = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ep1 = new System.Windows.Forms.Button();
            this.ep2 = new System.Windows.Forms.Button();
            this.ep3 = new System.Windows.Forms.Button();
            this.ep4 = new System.Windows.Forms.Button();
            this.ep5 = new System.Windows.Forms.Button();
            this.ep6 = new System.Windows.Forms.Button();
            this.ep7 = new System.Windows.Forms.Button();
            this.ep8 = new System.Windows.Forms.Button();
            this.ep9 = new System.Windows.Forms.Button();
            this.ep10 = new System.Windows.Forms.Button();
            this.ep11 = new System.Windows.Forms.Button();
            this.ep12 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(900, 27);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            this.headerText.Size = new System.Drawing.Size(227, 23);
            this.headerText.TabIndex = 4;
            this.headerText.Text = "AniUA — Вибір епізоду";
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
            this.buttTurn.Location = new System.Drawing.Point(846, 0);
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
            this.buttClose.Location = new System.Drawing.Point(873, 0);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ep1);
            this.flowLayoutPanel1.Controls.Add(this.ep2);
            this.flowLayoutPanel1.Controls.Add(this.ep3);
            this.flowLayoutPanel1.Controls.Add(this.ep4);
            this.flowLayoutPanel1.Controls.Add(this.ep5);
            this.flowLayoutPanel1.Controls.Add(this.ep6);
            this.flowLayoutPanel1.Controls.Add(this.ep7);
            this.flowLayoutPanel1.Controls.Add(this.ep8);
            this.flowLayoutPanel1.Controls.Add(this.ep9);
            this.flowLayoutPanel1.Controls.Add(this.ep10);
            this.flowLayoutPanel1.Controls.Add(this.ep11);
            this.flowLayoutPanel1.Controls.Add(this.ep12);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 473);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ep1
            // 
            this.ep1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep1.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep1.ForeColor = System.Drawing.Color.White;
            this.ep1.Location = new System.Drawing.Point(11, 10);
            this.ep1.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep1.Name = "ep1";
            this.ep1.Size = new System.Drawing.Size(46, 46);
            this.ep1.TabIndex = 1;
            this.ep1.Text = "1";
            this.ep1.UseVisualStyleBackColor = true;
            this.ep1.Click += new System.EventHandler(this.ep1_Click);
            // 
            // ep2
            // 
            this.ep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep2.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep2.ForeColor = System.Drawing.Color.White;
            this.ep2.Location = new System.Drawing.Point(78, 10);
            this.ep2.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep2.Name = "ep2";
            this.ep2.Size = new System.Drawing.Size(46, 46);
            this.ep2.TabIndex = 2;
            this.ep2.Text = "2";
            this.ep2.UseVisualStyleBackColor = true;
            // 
            // ep3
            // 
            this.ep3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep3.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep3.ForeColor = System.Drawing.Color.White;
            this.ep3.Location = new System.Drawing.Point(145, 10);
            this.ep3.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep3.Name = "ep3";
            this.ep3.Size = new System.Drawing.Size(46, 46);
            this.ep3.TabIndex = 3;
            this.ep3.Text = "3";
            this.ep3.UseVisualStyleBackColor = true;
            // 
            // ep4
            // 
            this.ep4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep4.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep4.ForeColor = System.Drawing.Color.White;
            this.ep4.Location = new System.Drawing.Point(212, 10);
            this.ep4.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep4.Name = "ep4";
            this.ep4.Size = new System.Drawing.Size(46, 46);
            this.ep4.TabIndex = 4;
            this.ep4.Text = "4";
            this.ep4.UseVisualStyleBackColor = true;
            // 
            // ep5
            // 
            this.ep5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep5.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep5.ForeColor = System.Drawing.Color.White;
            this.ep5.Location = new System.Drawing.Point(279, 10);
            this.ep5.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep5.Name = "ep5";
            this.ep5.Size = new System.Drawing.Size(46, 46);
            this.ep5.TabIndex = 5;
            this.ep5.Text = "5";
            this.ep5.UseVisualStyleBackColor = true;
            // 
            // ep6
            // 
            this.ep6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep6.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep6.ForeColor = System.Drawing.Color.White;
            this.ep6.Location = new System.Drawing.Point(346, 10);
            this.ep6.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep6.Name = "ep6";
            this.ep6.Size = new System.Drawing.Size(46, 46);
            this.ep6.TabIndex = 6;
            this.ep6.Text = "6";
            this.ep6.UseVisualStyleBackColor = true;
            // 
            // ep7
            // 
            this.ep7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep7.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep7.ForeColor = System.Drawing.Color.White;
            this.ep7.Location = new System.Drawing.Point(413, 10);
            this.ep7.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep7.Name = "ep7";
            this.ep7.Size = new System.Drawing.Size(46, 46);
            this.ep7.TabIndex = 7;
            this.ep7.Text = "7";
            this.ep7.UseVisualStyleBackColor = true;
            // 
            // ep8
            // 
            this.ep8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep8.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep8.ForeColor = System.Drawing.Color.White;
            this.ep8.Location = new System.Drawing.Point(480, 10);
            this.ep8.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep8.Name = "ep8";
            this.ep8.Size = new System.Drawing.Size(46, 46);
            this.ep8.TabIndex = 8;
            this.ep8.Text = "8";
            this.ep8.UseVisualStyleBackColor = true;
            // 
            // ep9
            // 
            this.ep9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep9.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep9.ForeColor = System.Drawing.Color.White;
            this.ep9.Location = new System.Drawing.Point(547, 10);
            this.ep9.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep9.Name = "ep9";
            this.ep9.Size = new System.Drawing.Size(46, 46);
            this.ep9.TabIndex = 9;
            this.ep9.Text = "9";
            this.ep9.UseVisualStyleBackColor = true;
            // 
            // ep10
            // 
            this.ep10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep10.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep10.ForeColor = System.Drawing.Color.White;
            this.ep10.Location = new System.Drawing.Point(614, 10);
            this.ep10.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep10.Name = "ep10";
            this.ep10.Size = new System.Drawing.Size(46, 46);
            this.ep10.TabIndex = 10;
            this.ep10.Text = "10";
            this.ep10.UseVisualStyleBackColor = true;
            // 
            // ep11
            // 
            this.ep11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep11.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep11.ForeColor = System.Drawing.Color.White;
            this.ep11.Location = new System.Drawing.Point(681, 10);
            this.ep11.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep11.Name = "ep11";
            this.ep11.Size = new System.Drawing.Size(46, 46);
            this.ep11.TabIndex = 11;
            this.ep11.Text = "11";
            this.ep11.UseVisualStyleBackColor = true;
            // 
            // ep12
            // 
            this.ep12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ep12.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ep12.ForeColor = System.Drawing.Color.White;
            this.ep12.Location = new System.Drawing.Point(748, 10);
            this.ep12.Margin = new System.Windows.Forms.Padding(11, 10, 10, 10);
            this.ep12.Name = "ep12";
            this.ep12.Size = new System.Drawing.Size(46, 46);
            this.ep12.TabIndex = 12;
            this.ep12.Text = "12";
            this.ep12.UseVisualStyleBackColor = true;
            // 
            // LoadEpisodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadEpisodes";
            this.Text = "Load_episodes";
            this.Load += new System.EventHandler(this.LoadEpisodes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox headerLogo;
        private System.Windows.Forms.Button buttTurn;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ep1;
        private System.Windows.Forms.Button ep2;
        private System.Windows.Forms.Button ep3;
        private System.Windows.Forms.Button ep4;
        private System.Windows.Forms.Button ep5;
        private System.Windows.Forms.Button ep6;
        private System.Windows.Forms.Button ep7;
        private System.Windows.Forms.Button ep8;
        private System.Windows.Forms.Button ep9;
        private System.Windows.Forms.Button ep10;
        private System.Windows.Forms.Button ep11;
        private System.Windows.Forms.Button ep12;
    }
}