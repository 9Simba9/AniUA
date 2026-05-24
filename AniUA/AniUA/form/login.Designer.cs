namespace AniUA
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerText = new System.Windows.Forms.Label();
            this.headerLogo = new System.Windows.Forms.PictureBox();
            this.buttTurn = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textNickname = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.clickThis = new System.Windows.Forms.Label();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelPasword = new System.Windows.Forms.Label();
            this.imgEyeOn = new System.Windows.Forms.PictureBox();
            this.imgLock = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgEyeOff = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEyeOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEyeOff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.headerText);
            this.panel1.Controls.Add(this.headerLogo);
            this.panel1.Controls.Add(this.buttTurn);
            this.panel1.Controls.Add(this.buttClose);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // headerText
            // 
            resources.ApplyResources(this.headerText, "headerText");
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Name = "headerText";
            // 
            // headerLogo
            // 
            resources.ApplyResources(this.headerLogo, "headerLogo");
            this.headerLogo.Name = "headerLogo";
            this.headerLogo.TabStop = false;
            // 
            // buttTurn
            // 
            this.buttTurn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttTurn, "buttTurn");
            this.buttTurn.FlatAppearance.BorderSize = 0;
            this.buttTurn.ForeColor = System.Drawing.Color.White;
            this.buttTurn.Name = "buttTurn";
            this.buttTurn.UseVisualStyleBackColor = true;
            this.buttTurn.Click += new System.EventHandler(this.button3_Click);
            this.buttTurn.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.buttTurn.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // buttClose
            // 
            this.buttClose.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttClose, "buttClose");
            this.buttClose.FlatAppearance.BorderSize = 0;
            this.buttClose.ForeColor = System.Drawing.Color.White;
            this.buttClose.Name = "buttClose";
            this.buttClose.UseVisualStyleBackColor = true;
            this.buttClose.Click += new System.EventHandler(this.button1_Click);
            this.buttClose.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.buttClose.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Welcome
            // 
            resources.ApplyResources(this.Welcome, "Welcome");
            this.Welcome.ForeColor = System.Drawing.Color.White;
            this.Welcome.Name = "Welcome";
            // 
            // labelLogin
            // 
            resources.ApplyResources(this.labelLogin, "labelLogin");
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Name = "labelLogin";
            // 
            // textNickname
            // 
            resources.ApplyResources(this.textNickname, "textNickname");
            this.textNickname.Name = "textNickname";
            // 
            // textPassword
            // 
            resources.ApplyResources(this.textPassword, "textPassword");
            this.textPassword.Name = "textPassword";
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // butLogin
            // 
            resources.ApplyResources(this.butLogin, "butLogin");
            this.butLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.ForeColor = System.Drawing.Color.Black;
            this.butLogin.Name = "butLogin";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // question
            // 
            resources.ApplyResources(this.question, "question");
            this.question.ForeColor = System.Drawing.Color.White;
            this.question.Name = "question";
            // 
            // clickThis
            // 
            resources.ApplyResources(this.clickThis, "clickThis");
            this.clickThis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickThis.ForeColor = System.Drawing.Color.White;
            this.clickThis.Name = "clickThis";
            this.clickThis.Click += new System.EventHandler(this.clickThis_Click);
            // 
            // labelNickname
            // 
            resources.ApplyResources(this.labelNickname, "labelNickname");
            this.labelNickname.ForeColor = System.Drawing.Color.White;
            this.labelNickname.Name = "labelNickname";
            // 
            // labelPasword
            // 
            resources.ApplyResources(this.labelPasword, "labelPasword");
            this.labelPasword.ForeColor = System.Drawing.Color.White;
            this.labelPasword.Name = "labelPasword";
            // 
            // imgEyeOn
            // 
            resources.ApplyResources(this.imgEyeOn, "imgEyeOn");
            this.imgEyeOn.Name = "imgEyeOn";
            this.imgEyeOn.TabStop = false;
            this.imgEyeOn.Click += new System.EventHandler(this.imgEye_Click);
            // 
            // imgLock
            // 
            resources.ApplyResources(this.imgLock, "imgLock");
            this.imgLock.Name = "imgLock";
            this.imgLock.TabStop = false;
            // 
            // imgUser
            // 
            resources.ApplyResources(this.imgUser, "imgUser");
            this.imgUser.Name = "imgUser";
            this.imgUser.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // imgEyeOff
            // 
            resources.ApplyResources(this.imgEyeOff, "imgEyeOff");
            this.imgEyeOff.Name = "imgEyeOff";
            this.imgEyeOff.TabStop = false;
            this.imgEyeOff.Click += new System.EventHandler(this.imgEyeOff_Click);
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.Controls.Add(this.imgEyeOff);
            this.Controls.Add(this.imgEyeOn);
            this.Controls.Add(this.labelPasword);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.clickThis);
            this.Controls.Add(this.question);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.imgLock);
            this.Controls.Add(this.textNickname);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEyeOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEyeOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.Button buttTurn;
        private System.Windows.Forms.PictureBox headerLogo;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.TextBox textNickname;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.PictureBox imgLock;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label clickThis;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label labelPasword;
        private System.Windows.Forms.PictureBox imgEyeOn;
        private System.Windows.Forms.PictureBox imgEyeOff;
    }
}