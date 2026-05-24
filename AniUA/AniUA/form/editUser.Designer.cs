namespace AniUA.form
{
    partial class editUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerText = new System.Windows.Forms.Label();
            this.headerLogo = new System.Windows.Forms.PictureBox();
            this.buttTurn = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.DBuser = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBuser)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1940, 27);
            this.panel1.TabIndex = 71;
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
            this.headerText.Size = new System.Drawing.Size(562, 23);
            this.headerText.TabIndex = 4;
            this.headerText.Text = "AniUA — меню адміністратора - редагування користувача";
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
            this.buttTurn.Location = new System.Drawing.Point(1886, 0);
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
            this.buttClose.Location = new System.Drawing.Point(1913, 0);
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
            // DBuser
            // 
            this.DBuser.AllowUserToAddRows = false;
            this.DBuser.AllowUserToDeleteRows = false;
            this.DBuser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DBuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBuser.Dock = System.Windows.Forms.DockStyle.Left;
            this.DBuser.Location = new System.Drawing.Point(0, 27);
            this.DBuser.Name = "DBuser";
            this.DBuser.ReadOnly = true;
            this.DBuser.Size = new System.Drawing.Size(1000, 1043);
            this.DBuser.TabIndex = 72;
            this.DBuser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBuser_CellClick);
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ID.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(1029, 110);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(180, 28);
            this.ID.TabIndex = 73;
            // 
            // Nickname
            // 
            this.Nickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Nickname.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname.Location = new System.Drawing.Point(1029, 178);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(180, 28);
            this.Nickname.TabIndex = 74;
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Email.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(1029, 314);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(180, 28);
            this.Email.TabIndex = 76;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(1029, 246);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(180, 28);
            this.Password.TabIndex = 75;
            // 
            // Status
            // 
            this.Status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Status.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(1029, 382);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(180, 28);
            this.Status.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1025, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 79;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1025, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "Нікнейм";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1025, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 81;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1025, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 82;
            this.label4.Text = "Пошта";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1025, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 83;
            this.label5.Text = "Статус";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1235, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 28);
            this.button2.TabIndex = 85;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1235, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 28);
            this.button3.TabIndex = 86;
            this.button3.Text = "Зберегти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1235, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 28);
            this.button4.TabIndex = 87;
            this.button4.Text = "Зберегти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1235, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 28);
            this.button5.TabIndex = 88;
            this.button5.Text = "Зберегти";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUser.ForeColor = System.Drawing.Color.White;
            this.deleteUser.Location = new System.Drawing.Point(1029, 504);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(346, 28);
            this.deleteUser.TabIndex = 89;
            this.deleteUser.Text = "Видалити користувача";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1029, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 28);
            this.button1.TabIndex = 90;
            this.button1.Text = "Зберегти все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(1791, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 150;
            this.label8.Text = "<<Повернутись";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1940, 1070);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.DBuser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editUser";
            this.Text = "editUser";
            this.Load += new System.EventHandler(this.editUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox headerLogo;
        private System.Windows.Forms.Button buttTurn;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.DataGridView DBuser;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}