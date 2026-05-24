using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniUA.form
{
    public partial class LoadEpisodes : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";

        private bool isDragging = false;
        private int xOffset;
        private int yOffset;
        public LoadEpisodes()
        {
            InitializeComponent();
        }

        private void LoadEpisodes_Load(object sender, EventArgs e)
        {
            //

        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttClose_MouseEnter(object sender, EventArgs e)
        {
            buttClose.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void buttClose_MouseLeave(object sender, EventArgs e)
        {
            buttClose.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void buttTurn_MouseEnter(object sender, EventArgs e)
        {
            buttTurn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void buttTurn_MouseLeave(object sender, EventArgs e)
        {
            buttTurn.BackColor = Color.FromArgb(25, 25, 25);
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

        private void ep1_Click(object sender, EventArgs e)
        {
            PlayerAniUA OpenPlayer = new PlayerAniUA();
            OpenPlayer.Show();

            this.Hide();
        }
    }
}
