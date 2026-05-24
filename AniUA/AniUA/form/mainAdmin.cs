using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniUA.form
{
    public partial class mainAdmin : Form
    {
        private bool isDragging = false;
        private int xOffset;
        private int yOffset;

        public mainAdmin()
        {
            InitializeComponent();
        }

        private void mainAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StatusLoginAdmin = false;
            Properties.Settings.Default.StatusLogin = false;
            Properties.Settings.Default.Save();

            login OpenLogin = new login();
            OpenLogin.Show();
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            xOffset = e.X;
            yOffset = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int newX = this.Location.X + (e.X - xOffset);
                int newY = this.Location.Y + (e.Y - yOffset);
                this.Location = new System.Drawing.Point(newX, newY);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StatusLoginAdmin = true;
            Properties.Settings.Default.Save();

            Application.Exit();
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttTurn_MouseEnter(object sender, EventArgs e)
        {
            buttTurn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void buttTurn_MouseLeave(object sender, EventArgs e)
        {
            buttTurn.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void buttClose_MouseEnter(object sender, EventArgs e)
        {
            buttClose.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void buttClose_MouseLeave(object sender, EventArgs e)
        {
            buttClose.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            editUser OpenEditUser = new editUser();
            OpenEditUser.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            editAnime OpenEditAnime = new editAnime();
            OpenEditAnime.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            addAnime OpenAddAnime = new addAnime();
            OpenAddAnime.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            editComments OpenEditComments = new editComments();
            OpenEditComments.Show();
            this.Hide();
        }
    }
}
