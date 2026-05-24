using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace AniUA.form
{
    public partial class addAnime : Form
    {
        ToolTip toolTip = new ToolTip();
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";

        public addAnime()
        {
            InitializeComponent();

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;

            toolTip.SetToolTip(label19, "Серіал/Фільм/Анонс");
            toolTip.SetToolTip(label23, "Завершено/Виходить/Анонс");
            toolTip.SetToolTip(label12, "якщо тип \"Анонс\", дд.мм.рррр");
        }

        private void addAnime_Load(object sender, EventArgs e)
        {
            LoadAnime();
        }

        private void LoadAnime()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID_anime, name, original_name, history, genres, director, country, recommended_age, year, count_episodes, duration_episodes, status, rating, video_link1, video_link2, video_link3, img1, img2, img3 FROM anime";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                DBanime.DataSource = dataTable;


                // Встановлення горизонтального вирівнювання для кожної колонки
                DBanime.Columns["ID_anime"].Width = 60;
                DBanime.Columns["name"].Width = 200;
                DBanime.Columns["original_name"].Width = 200;
                DBanime.Columns["history"].Width = 200;
                DBanime.Columns["genres"].Width = 150;
                DBanime.Columns["director"].Width = 100;
                DBanime.Columns["country"].Width = 60;
                DBanime.Columns["recommended_age"].Width = 60;
                DBanime.Columns["year"].Width = 60;
                DBanime.Columns["count_episodes"].Width = 60;
                DBanime.Columns["duration_episodes"].Width = 60;
                DBanime.Columns["status"].Width = 100;
                DBanime.Columns["rating"].Width = 60;

            }
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

        private void label8_Click(object sender, EventArgs e)
        {
            mainAdmin OpenMainAdmin = new mainAdmin();
            OpenMainAdmin.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Перевірка наявності обов'язкових полів
            if (string.IsNullOrWhiteSpace(tName.Text) ||
                string.IsNullOrWhiteSpace(tOriginalName.Text) ||
                string.IsNullOrWhiteSpace(tHistory.Text) ||
                string.IsNullOrWhiteSpace(tGenres.Text) ||
                string.IsNullOrWhiteSpace(tDirector.Text) ||
                string.IsNullOrWhiteSpace(tCountry.Text) ||
                string.IsNullOrWhiteSpace(tRecAge.Text) ||
                string.IsNullOrWhiteSpace(tYear.Text) ||
                string.IsNullOrWhiteSpace(tCountEpisode.Text) ||
                string.IsNullOrWhiteSpace(tDurationEpisode.Text) ||
                string.IsNullOrWhiteSpace(tStatus.Text) ||
                string.IsNullOrWhiteSpace(tRaiting.Text) ||
                string.IsNullOrWhiteSpace(tVideoLink1.Text) || 
                string.IsNullOrWhiteSpace(tDataAnonce.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка правильності формату числових полів
            int recommendedAge;
            if (!int.TryParse(tRecAge.Text, out recommendedAge))
            {
                MessageBox.Show("Введіть коректний рекомендований вік.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int year;
            if (!int.TryParse(tYear.Text, out year))
            {
                MessageBox.Show("Введіть коректний рік.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int countEpisodes;
            if (!int.TryParse(tCountEpisode.Text, out countEpisodes))
            {
                MessageBox.Show("Введіть коректну кількість епізодів.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double rating;
            if (!double.TryParse(tRaiting.Text, out rating))
            {
                MessageBox.Show("Введіть коректний рейтинг.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Додавання нового запису аніме
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO anime 
                        (logo, name, original_name, history, genres, director, country, recommended_age, year, count_episodes, duration_episodes, status, statusX, rating, data_announce, video_link1, video_link2, video_link3, img1, img2, img3) 
                        VALUES 
                        (@logo, @name, @originalName, @history, @genres, @director, @country, @recommendedAge, @year, @countEpisodes, @durationEpisodes, @status, @statusX, @rating, @data_announce, @videoLink1, @videoLink2, @videoLink3, @img1, @img2, @img3)";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@logo", ImageToByteArray(pLogo.Image));
                command.Parameters.AddWithValue("@name", tName.Text);
                command.Parameters.AddWithValue("@originalName", tOriginalName.Text);
                command.Parameters.AddWithValue("@history", tHistory.Text);
                command.Parameters.AddWithValue("@genres", tGenres.Text);
                command.Parameters.AddWithValue("@director", tDirector.Text);
                command.Parameters.AddWithValue("@country", tCountry.Text);
                command.Parameters.AddWithValue("@recommendedAge", recommendedAge);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@countEpisodes", countEpisodes);
                command.Parameters.AddWithValue("@durationEpisodes", tDurationEpisode.Text);
                command.Parameters.AddWithValue("@status", tStatus.Text);
                command.Parameters.AddWithValue("@statusX", tStatusX.Text);
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@data_announce", tDataAnonce.Text);
                command.Parameters.AddWithValue("@videoLink1", tVideoLink1.Text);
                command.Parameters.AddWithValue("@videoLink2", tVideoLink2.Text);
                command.Parameters.AddWithValue("@videoLink3", tVideoLink3.Text);

                if (pImg1.Image != null || pImg2.Image != null || pImg3.Image != null)
                {
                    command.Parameters.AddWithValue("@img1", DBNull.Value);
                    command.Parameters.AddWithValue("@img2", DBNull.Value);
                    command.Parameters.AddWithValue("@img3", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@img1", ImageToByteArray(pImg1.Image));
                    command.Parameters.AddWithValue("@img2", ImageToByteArray(pImg2.Image));
                    command.Parameters.AddWithValue("@img3", ImageToByteArray(pImg3.Image));
                }

                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        //Метод для конвертації зображення в масив байтів
        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private string selectedFilePath1; // додайте змінну для зберігання шляху до вибраного файлу
        private void button18_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            long maxSize = 5 * 1024 * 1024; // 5 MB

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath1 = openFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(selectedFilePath1);

                if (fileInfo.Length > maxSize)
                {
                    MessageBox.Show("Вибраний файл завеликий. Будь ласка, виберіть файл меншого розміру. 5МБ", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Image image = Image.FromFile(selectedFilePath1);

                pImg1.Image = image;
            }
        }

        private string selectedFilePath2; // додайте змінну для зберігання шляху до вибраного файлу
        private void button19_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            long maxSize = 5 * 1024 * 1024; // 5 MB

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath2 = openFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(selectedFilePath2);

                if (fileInfo.Length > maxSize)
                {
                    MessageBox.Show("Вибраний файл завеликий. Будь ласка, виберіть файл меншого розміру. 5МБ", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Image image = Image.FromFile(selectedFilePath2);

                pImg2.Image = image;
            }
        }

        private string selectedFilePath3; // додайте змінну для зберігання шляху до вибраного файлу
        private void button21_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            long maxSize = 5 * 1024 * 1024; // 5 MB

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath3 = openFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(selectedFilePath3);

                if (fileInfo.Length > maxSize)
                {
                    MessageBox.Show("Вибраний файл завеликий. Будь ласка, виберіть файл меншого розміру. 5МБ", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Image image = Image.FromFile(selectedFilePath3);

                pImg3.Image = image;
            }
        }

        private string selectedFilePathLogo; // додайте змінну для зберігання шляху до вибраного файлу
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            long maxSize = 5 * 1024 * 1024; // 5 MB

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePathLogo = openFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(selectedFilePathLogo);

                if (fileInfo.Length > maxSize)
                {
                    MessageBox.Show("Вибраний файл завеликий. Будь ласка, виберіть файл меншого розміру. 5МБ", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Image image = Image.FromFile(selectedFilePathLogo);

                pLogo.Image = image;
            }
        }
    }
}
