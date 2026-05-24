using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace AniUA.form
{
    public partial class editAnime : Form
    {
        ToolTip toolTip = new ToolTip();
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";

        public editAnime()
        {
            InitializeComponent();

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;

            toolTip.SetToolTip(label19, "Серіал/Фільм/Анонс");
            toolTip.SetToolTip(label23, "Завершено/Виходить/Анонс");
            toolTip.SetToolTip(label22, "якщо тип \"Анонс\", дд.мм.рррр");
        }

        private void LoadAnime()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID_anime, logo, name, original_name, history, genres, director, country, recommended_age, year, count_episodes, duration_episodes, status, statusX, rating, data_announce, video_link1, video_link2, video_link3, img1, img2, img3 FROM anime";
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
                DBanime.Columns["statusX"].Width = 100;
                DBanime.Columns["rating"].Width = 60;

            }
        }

        private void LoadImg()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT logo, img1, img2, img3 FROM anime WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    byte[] imgByteslogo = (byte[])dataTable.Rows[0]["logo"];
                    byte[] imgBytes1 = dataTable.Rows[0]["img1"] as byte[];
                    byte[] imgBytes2 = dataTable.Rows[0]["img2"] as byte[];
                    byte[] imgBytes3 = dataTable.Rows[0]["img3"] as byte[];

                    using (MemoryStream msl = new MemoryStream(imgByteslogo))
                    {
                        pLogo.Image = Image.FromStream(msl);
                    }

                    if (imgBytes1 != null)
                    {
                        using (MemoryStream ms1 = new MemoryStream(imgBytes1))
                        {
                            pImg1.Image = Image.FromStream(ms1);
                        }
                    }

                    if (imgBytes2 != null)
                    {
                        using (MemoryStream ms2 = new MemoryStream(imgBytes2))
                        {
                            pImg2.Image = Image.FromStream(ms2);
                        }
                    }

                    if (imgBytes3 != null)
                    {
                        using (MemoryStream ms3 = new MemoryStream(imgBytes3))
                        {
                            pImg3.Image = Image.FromStream(ms3);
                        }
                    }
                }

                connection.Close();
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

        private void editAnime_Load(object sender, EventArgs e)
        {
            LoadAnime();
        }

        private void DBanime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Перевірити, чи було клікнуто на рядок, а не на заголовок стовпця
            if (e.RowIndex >= 0)
            {
                // Отримати дані з вибраного рядка
                DataGridViewRow selectedRow = DBanime.Rows[e.RowIndex];
                string IDanime = selectedRow.Cells["ID_anime"].Value.ToString();
                string name = selectedRow.Cells["name"].Value.ToString();
                string originalName = selectedRow.Cells["original_name"].Value.ToString();
                string history = selectedRow.Cells["history"].Value.ToString();
                string genres = selectedRow.Cells["genres"].Value.ToString();
                string director = selectedRow.Cells["director"].Value.ToString();
                string country = selectedRow.Cells["country"].Value.ToString();
                string recommended_age = selectedRow.Cells["recommended_age"].Value.ToString();
                string year = selectedRow.Cells["year"].Value.ToString();
                string count_episodes = selectedRow.Cells["count_episodes"].Value.ToString();
                string duration_episodes = selectedRow.Cells["duration_episodes"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();
                string statusX = selectedRow.Cells["statusX"].Value.ToString();
                string rating = selectedRow.Cells["rating"].Value.ToString();
                string dataAnonce = selectedRow.Cells["data_announce"].Value.ToString();
                string videoLink1 = selectedRow.Cells["video_link1"].Value.ToString();
                string videoLink2 = selectedRow.Cells["video_link2"].Value.ToString();
                string videoLink3 = selectedRow.Cells["video_link3"].Value.ToString();



                // Завантажити дані у TextBox
                tIDanime.Text = IDanime;
                tName.Text = name;
                tOriginalName.Text = originalName;
                tHistory.Text = history;
                tGenres.Text = genres;
                tDirector.Text = director;
                tCountry.Text = country;
                tRecAge.Text = recommended_age;
                tYear.Text = year;

                tCountEpisode.Text = count_episodes;
                tDurationEpisode.Text = duration_episodes;
                tStatus.Text = status;
                tStatusX.Text = statusX;

                tRaiting.Text = rating;
                tDataAnonce.Text = dataAnonce;

                tVideoLink1.Text = videoLink1;
                tVideoLink2.Text = videoLink2;
                tVideoLink3.Text = videoLink3;

                LoadImg();
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
        private void button23_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET name = @newName WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@newName", Convert.ToString(tName.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET original_name = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tOriginalName.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET history = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tHistory.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET genres = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tGenres.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET director = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tDirector.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET country = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tCountry.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string recAgeText = tRecAge.Text;
                if (!int.TryParse(recAgeText, out int recommendedAge))
                {
                    MessageBox.Show("Введено некоректне значення віку. Будь ласка, введіть лише цифри.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();

                string query = "UPDATE anime SET recommended_age = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToInt32(tRecAge.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string yearText = tYear.Text;
                if (!int.TryParse(yearText, out int recommendedAge))
                {
                    MessageBox.Show("Введено некоректне значення року. Будь ласка, введіть лише цифри.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();

                string query = "UPDATE anime SET year = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToInt32(tYear.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string countEpisodeText = tCountEpisode.Text;
                if (!int.TryParse(countEpisodeText, out int recommendedAge))
                {
                    MessageBox.Show("Введено некоректне значення кількості епізодів. Будь ласка, введіть лише цифри.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();

                string query = "UPDATE anime SET count_episodes = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToInt32(tCountEpisode.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string durationEpisodeText = tDurationEpisode.Text;
                if (!int.TryParse(durationEpisodeText, out int recommendedAge))
                {
                    MessageBox.Show("Введено некоректне значення тривалості епізоду. Будь ласка, введіть лише цифри.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();

                string query = "UPDATE anime SET duration_episodes = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToInt32(tDurationEpisode.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET status = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tStatus.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string raitingText = tRaiting.Text;
                if (!float.TryParse(raitingText, out float rating))
                {
                    MessageBox.Show("Введено некоректне значення рейтингу. Будь ласка, введіть числове значення.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();
                
                string query = "UPDATE anime SET rating = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", rating);
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET video_link1 = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tVideoLink1.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET video_link2 = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tVideoLink2.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET video_link3 = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tVideoLink3.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath1))
            {
                MessageBox.Show("Виберіть файл зображення для оновлення.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET img1 = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", File.ReadAllBytes(selectedFilePath1));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath2))
            {
                MessageBox.Show("Виберіть файл зображення для оновлення.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET img2 = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", File.ReadAllBytes(selectedFilePath2));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath3))
            {
                MessageBox.Show("Виберіть файл зображення для оновлення.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET img3 = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", File.ReadAllBytes(selectedFilePath3));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            int selectedUserId = Convert.ToInt32(DBanime.CurrentRow.Cells["ID_anime"].Value);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM anime WHERE ID_anime = {selectedUserId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE anime SET logo = @logo, name = @name, original_name = @originalName, history = @history, 
                        genres = @genres, director = @director, country = @country, recommended_age = @recommendedAge, 
                        year = @year, count_episodes = @countEpisodes, duration_episodes = @durationEpisodes, 
                        status = @status, statusX = @statusX, rating = @rating, data_announce = @data_announce, 
                        video_link1 = @videoLink1, video_link2 = @videoLink2, video_link3 = @videoLink3, 
                        img1 = @img1, img2 = @img2, img3 = @img3 
                    WHERE ID_anime = @idAnime";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", tName.Text);
                command.Parameters.AddWithValue("@logo", ImageToByteArray(pLogo.Image));
                command.Parameters.AddWithValue("@originalName", tOriginalName.Text);
                command.Parameters.AddWithValue("@history", tHistory.Text);
                command.Parameters.AddWithValue("@genres", tGenres.Text);
                command.Parameters.AddWithValue("@director", tDirector.Text);
                command.Parameters.AddWithValue("@country", tCountry.Text);
                command.Parameters.AddWithValue("@recommendedAge", Convert.ToInt32(tRecAge.Text));
                command.Parameters.AddWithValue("@year", Convert.ToInt32(tYear.Text));
                command.Parameters.AddWithValue("@countEpisodes", Convert.ToInt32(tCountEpisode.Text));
                command.Parameters.AddWithValue("@durationEpisodes", tDurationEpisode.Text);
                command.Parameters.AddWithValue("@status", tStatus.Text);
                command.Parameters.AddWithValue("@statusX", tStatusX.Text);
                command.Parameters.AddWithValue("@rating", Convert.ToDouble(tRaiting.Text));
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

                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);

                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        // Метод для конвертації зображення в масив байтів
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

        private void label8_Click(object sender, EventArgs e)
        {
            mainAdmin OpenMainAdmin = new mainAdmin();
            OpenMainAdmin.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string dataAnonce = tDataAnonce.Text;

                connection.Open();

                string query = "UPDATE anime SET data_announce = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", dataAnonce);
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE anime SET statusX = @new WHERE ID_anime = @idAnime";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", Convert.ToString(tStatusX.Text));
                command.Parameters.AddWithValue("@idAnime", tIDanime.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadAnime();
            }
        }
    }
}
