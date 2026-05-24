namespace AniUA.form
{
    partial class editComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editComments));
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerText = new System.Windows.Forms.Label();
            this.headerLogo = new System.Windows.Forms.PictureBox();
            this.buttTurn = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.DBcomments = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.IDanime = new System.Windows.Forms.TextBox();
            this.IDuser = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBcomments)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1666, 27);
            this.panel1.TabIndex = 72;
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
            this.headerText.Size = new System.Drawing.Size(550, 23);
            this.headerText.TabIndex = 4;
            this.headerText.Text = "AniUA — меню адміністратора - редагування коментарів";
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
            this.buttTurn.Location = new System.Drawing.Point(1612, 0);
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
            this.buttClose.Location = new System.Drawing.Point(1639, 0);
            this.buttClose.Name = "buttClose";
            this.buttClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttClose.Size = new System.Drawing.Size(27, 27);
            this.buttClose.TabIndex = 1;
            this.buttClose.Text = "X";
            this.buttClose.UseVisualStyleBackColor = true;
            this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
            // 
            // DBcomments
            // 
            this.DBcomments.AllowUserToAddRows = false;
            this.DBcomments.AllowUserToDeleteRows = false;
            this.DBcomments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DBcomments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBcomments.Dock = System.Windows.Forms.DockStyle.Left;
            this.DBcomments.Location = new System.Drawing.Point(0, 27);
            this.DBcomments.Name = "DBcomments";
            this.DBcomments.ReadOnly = true;
            this.DBcomments.Size = new System.Drawing.Size(985, 1043);
            this.DBcomments.TabIndex = 73;
            this.DBcomments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBcomments_CellClick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("NAMU 1750", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(1519, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 151;
            this.label8.Text = "<<Повернутись";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1009, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(572, 28);
            this.button1.TabIndex = 167;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUser.ForeColor = System.Drawing.Color.White;
            this.deleteUser.Location = new System.Drawing.Point(1009, 468);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(572, 28);
            this.deleteUser.TabIndex = 166;
            this.deleteUser.Text = "Видалити коментар";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1005, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 161;
            this.label5.Text = "Оцінка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1005, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 160;
            this.label4.Text = "Коментар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1397, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 159;
            this.label3.Text = "ID аніме";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1201, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 158;
            this.label2.Text = "ID користувача";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1005, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 157;
            this.label1.Text = "ID";
            // 
            // Rating
            // 
            this.Rating.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rating.Location = new System.Drawing.Point(1009, 324);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(180, 28);
            this.Rating.TabIndex = 156;
            // 
            // Comment
            // 
            this.Comment.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comment.Location = new System.Drawing.Point(1009, 174);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(572, 113);
            this.Comment.TabIndex = 155;
            // 
            // IDanime
            // 
            this.IDanime.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDanime.Location = new System.Drawing.Point(1401, 87);
            this.IDanime.Name = "IDanime";
            this.IDanime.Size = new System.Drawing.Size(180, 28);
            this.IDanime.TabIndex = 154;
            // 
            // IDuser
            // 
            this.IDuser.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDuser.Location = new System.Drawing.Point(1205, 87);
            this.IDuser.Name = "IDuser";
            this.IDuser.Size = new System.Drawing.Size(180, 28);
            this.IDuser.TabIndex = 153;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("NAMU 1750", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(1009, 87);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(180, 28);
            this.ID.TabIndex = 152;
            // 
            // editComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1666, 1070);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.IDanime);
            this.Controls.Add(this.IDuser);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DBcomments);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editComments";
            this.Text = "editComments";
            this.Load += new System.EventHandler(this.editComments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBcomments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox headerLogo;
        private System.Windows.Forms.Button buttTurn;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.DataGridView DBcomments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.TextBox IDanime;
        private System.Windows.Forms.TextBox IDuser;
        private System.Windows.Forms.TextBox ID;
    }
}