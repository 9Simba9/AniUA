using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AniUA.form
{
    public partial class PlayerAniUA : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";

        public PlayerAniUA()
        {
            InitializeComponent();
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
            this.Hide();
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

        private void PlayerAniUA_Load(object sender, EventArgs e)
        {
            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized; 
            
            Player.uiMode = "none";

            //Завантаєеня епізоду з БД
            //Properties.Settings.Default.AnimeID
            

            Player.Ctlcontrols.pause();
            start.Visible = false;
        }

        private void CompressVideo(string inputFilePath, string outputFilePath)
        {
            string ffmpegPath = "повний_шлях_до_ffmpeg"; // Замініть на відповідний шлях до FFmpeg на вашій системі
            string arguments = $"-i \"{inputFilePath}\" -vf \"scale=1280:720\" -b:v 1M -c:a copy \"{outputFilePath}\"";

            ProcessStartInfo startInfo = new ProcessStartInfo(ffmpegPath, arguments);
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

        }

        private void pause_Click(object sender, EventArgs e)
        {
            start.Visible = true;
            pause.Visible = false;
            Player.Ctlcontrols.pause();
        }

        private void start_Click(object sender, EventArgs e)
        {
            pause.Visible = true;
            start.Visible = false;
            Player.Ctlcontrols.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Перемотка на 1 хвилину і 25 секунд
            double targetPosition = 1 * 60 + 25;

            //Встановлення нової позиції відтворення
            Player.Ctlcontrols.currentPosition += targetPosition;

            //Початок відтворення з нової позиції
            Player.Ctlcontrols.play();
        }

        private void volume_ValueChanged(object sender, EventArgs e)
        {
            Player.settings.volume = volume.Value;
        }

        private void Player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            timerPlayer.Enabled = true;
            timerPlayer.Interval = 1000;
        }

        private void timerPlayer_Tick(object sender, EventArgs e)
        {
            trackBar.Maximum = Convert.ToInt32(Player.currentMedia.duration);
            trackBar.Value = Convert.ToInt32(Player.Ctlcontrols.currentPosition);

            if (Player != null)
            {
                int s = (int)Player.Ctlcontrols.currentPosition;
                int h = s / 3600;
                int m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 +  m * 60);
                textTime.Text = string.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
            }
            else
            {
                textTime.Text = "0:00:00";
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            Player.Ctlcontrols.currentPosition = trackBar.Value;
        }

        private void textTime_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv|All Files|*.*";
            openFileDialog.Title = "Виберіть MP4 файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                //MessageBox.Show($"Ви вибрали файл: {selectedFilePath}");

                // Передача вибраного шляху до плеєра
                Player.URL = selectedFilePath;
                Player.Ctlcontrols.play();
            }
        }

        private void hideUU_Click(object sender, EventArgs e)
        {
            pause.Visible = false;
            start.Visible = false;
            panel.Visible = false;

            hideUI.Visible = false;
            showUI.Visible = true;
        }

        private void showUI_Click(object sender, EventArgs e)
        {
            pause.Visible = true;
            start.Visible = true;
            panel.Visible = true;

            showUI.Visible = false;
            hideUI.Visible = true;
        }
    }
}
