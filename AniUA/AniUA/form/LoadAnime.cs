using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AniUA.form
{
    public partial class LoadAnime : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";
        private Font NAMUFont;

        public LoadAnime()
        {
            InitializeComponent();
            NAMUFont = new Font("NAMU 1750", 13);
        }

        private bool isUserInteraction = true;

        int animeID = int.Parse(Properties.Settings.Default.AnimeID);
        int userID = int.Parse(Properties.Settings.Default.UserID);

        private void LoadAnime_Load(object sender, EventArgs e)
        {
            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;

            tAnonce.Visible = false;

            LoadComment();             // Завантаження коментарів
            pictureBox.Invalidate();  // Примусове оновлення pictureBox_Paint для перефарбування
            UpdateStatisticsText();  // Оновлення статистики в текстових полях
            CheckSaveStatus();      // Перевірка статусу Збереженя



            //Завантаження інформації про аніме
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                
                string query = "SELECT * FROM anime WHERE ID_anime = @animeID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@animeID", animeID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id_anime = reader.GetInt32("ID_anime");
                            byte[] logo = (byte[])reader["logo"];
                            string name = reader.GetString("name");
                            string OriginalName = reader.GetString("original_name");
                            string history = reader.GetString("history");
                            string Genres = reader.GetString("genres");
                            string Director = reader.GetString("director");
                            string Country = reader.GetString("country");
                            int recommendedAge = reader.GetInt32("recommended_age");
                            int year = reader.GetInt32("year");
                            int countEpisode = reader.GetInt32("count_episodes");
                            int durationEpisode = reader.GetInt32("duration_episodes");
                            float rating = reader.GetFloat("rating");
                            string videoLink1 = reader.GetString("video_link1");
                            string videoLink2 = reader.GetString("video_link2");
                            string videoLink3 = reader.GetString("video_link3");
                            byte[] img1 = reader.IsDBNull(reader.GetOrdinal("img1")) ? null : (byte[])reader["img1"];
                            byte[] img2 = reader.IsDBNull(reader.GetOrdinal("img2")) ? null : (byte[])reader["img2"];
                            byte[] img3 = reader.IsDBNull(reader.GetOrdinal("img3")) ? null : (byte[])reader["img3"];

                            string statusX = reader.GetString("statusX");
                            string dataAnnounce = reader.IsDBNull(reader.GetOrdinal("data_announce")) ? null : reader.GetString("data_announce");

                            if (statusX == "Анонс")
                            {
                                button1.Visible = false;
                                tAnonce.Visible = true;

                                if (dataAnnounce != null)
                                {
                                    tAnonce.Text = "Анонс: " + dataAnnounce;
                                }
                                else
                                {
                                    tAnonce.Visible = false;
                                }
                            }

                            // Завантаження зображень
                            MemoryStream msl = new MemoryStream(logo);
                            pLogo.Image = Image.FromStream(msl);

                            if (img1 != null)
                            {
                                MemoryStream ms1 = new MemoryStream(img1);
                                pic1.Image = Image.FromStream(ms1);
                            }

                            if (img2 != null)
                            {
                                MemoryStream ms2 = new MemoryStream(img2);
                                pic2.Image = Image.FromStream(ms2);
                            }

                            if (img3 != null)
                            {
                                MemoryStream ms3 = new MemoryStream(img3);
                                pic3.Image = Image.FromStream(ms3);
                            }

                            //Занесення ID аніме для плеєру
                            Properties.Settings.Default.AnimeID = Convert.ToString(id_anime);


                            nameAnime.Text = name;
                            headerText.Text = "AniUA - " + name;
                            originalName.Text = OriginalName;
                            genres.Text = Genres;
                            director.Text = Director;
                            country.Text = Country;
                            recomendAge.Text = Convert.ToString(recommendedAge);
                            textYear.Text = Convert.ToString(year);
                            countEpisodes.Text = Convert.ToString(countEpisode);
                            durationEpisodes.Text = Convert.ToString(durationEpisode);
                            textRaiting.Text = Convert.ToString(rating);
                            animeHistory.Text = history;



                            // Завантаження браузеру з відеом
                            string html = "<html style='background-color: #0C0C0C;'><head><boady>";
                            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='560' height='315' frameborder='0' style='margin-top: -8px; margin-left: -8px;'></iframe>";
                            html += "</boady></head></html>";

                            this.video1.DocumentText = string.Format(html, videoLink1.Split('=')[1]);
                            this.video2.DocumentText = string.Format(html, videoLink2.Split('=')[1]);
                            this.video3.DocumentText = string.Format(html, videoLink3.Split('=')[1]);
                        }
                    }
                }
            }



            //максимум символів в назві аніме
            int maxLineLength = 124;
            //перенесення назви
            string wrappedTextName = WrapText(nameAnime.Text, maxLineLength);
            nameAnime.Text = wrappedTextName;
            //перенесення історії
            string wrappedTextHistory = WrapText(animeHistory.Text, maxLineLength);
            animeHistory.Text = wrappedTextHistory;



            //Статус у користувача
            //Заборона зміни
            statusList.DropDownStyle = ComboBoxStyle.DropDownList;

            //за замовчуванням
            statusList.Items.Add("Не дивлюсь");

            statusList.Items.Add("Дивлюсь");
            statusList.Items.Add("Заплановано");
            statusList.Items.Add("Переглянуто");
            statusList.Items.Add("Відкладено");
            statusList.Items.Add("Закинуто");


            statusList.SelectedIndexChanged -= statusList_SelectedIndexChanged;
            statusList.SelectedIndex = 0;
            SetSelectSrarus();
            statusList.SelectedIndexChanged += statusList_SelectedIndexChanged;

            CalculateAnimeRating();// Розрахунок рейтингу
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            int[] data = GetAnimeStatistics();

            int total = data.Sum();
            int x = 0;
            int width = pictureBox.Width;

            for (int i = 0; i < data.Length; i++)
            {
                int colorWidth = (int)((data[i] / (double)total) * width);
                Color color = GetColor(i);

                using (Brush brush = new SolidBrush(color))
                {
                    e.Graphics.FillRectangle(brush, x, 0, colorWidth, pictureBox.Height);
                }

                x += colorWidth;
            }
        }

        private void UpdateStatisticsText()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT SUM(watching) AS totalWatching, SUM(planned) AS totalPlanned, SUM(revised) AS totalRevised, SUM(postponed) AS totalPostponed, SUM(abandoned) AS totalAbandoned FROM anime_statistics WHERE ID_anime = @animeID";

                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@animeID", animeID);

                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cWatching.Text = reader["totalWatching"].ToString();
                            cPlanned.Text = reader["totalPlanned"].ToString();
                            cRevised.Text = reader["totalRevised"].ToString();
                            cPostponed.Text = reader["totalPostponed"].ToString();
                            cAbandoned.Text = reader["totalAbandoned"].ToString();
                        }
                    }
                }

                connection.Close();
            }
        }

        private int[] GetAnimeStatistics()
        {
            int[] data = new int[5]; // Масив для збереження статистики

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT SUM(watching) AS totalWatching, SUM(planned) AS totalPlanned, SUM(revised) AS totalRevised, SUM(postponed) AS totalPostponed, SUM(abandoned) AS totalAbandoned FROM anime_statistics WHERE ID_anime = @animeID";

                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@animeID", animeID);

                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data[0] = Convert.ToInt32(reader["totalWatching"]);
                            data[1] = Convert.ToInt32(reader["totalPlanned"]);
                            data[2] = Convert.ToInt32(reader["totalRevised"]);
                            data[3] = Convert.ToInt32(reader["totalPostponed"]);
                            data[4] = Convert.ToInt32(reader["totalAbandoned"]);
                        }
                    }
                }

                connection.Close();
            }

            return data;
        }


        //Створеня кольорів (для в списках у людей)
        private Color GetColor(int index)
        {
            Color watchingCol = Color.FromArgb(102, 255, 102);
            Color inPlansCol = Color.FromArgb(204, 0, 204);
            Color viewedCol = Color.FromArgb(51, 102, 255);
            Color postponedCol = Color.FromArgb(255, 153, 51);
            Color abandonedCol = Color.FromArgb(255, 51, 51);
            switch (index)
            {
                case 0:
                    return watchingCol;
                case 1:
                    return inPlansCol;
                case 2:
                    return viewedCol;
                case 3:
                    return postponedCol;
                case 4:
                    return abandonedCol;
                default:
                    return Color.Gray;
            }
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //функція яка переносить рядок з назвою аніме на новий рядок
        public static string WrapText(string text, int lineLength)
        {
            StringBuilder result = new StringBuilder();
            string[] words = text.Split(' ');

            int currentLineLength = 0;
            foreach (string word in words)
            {
                if (word.Length > lineLength)
                {
                    int startIndex = 0;
                    while (startIndex < word.Length)
                    {
                        int endIndex = Math.Min(startIndex + lineLength, word.Length);
                        string part = word.Substring(startIndex, endIndex - startIndex);
                        result.AppendLine(part);
                        startIndex = endIndex;
                    }
                    currentLineLength = 0;
                }
                else if (currentLineLength + word.Length <= lineLength)
                {
                    result.Append(word + " ");
                    currentLineLength += word.Length + 1;
                }
                else
                {
                    result.AppendLine();
                    result.Append(word + " ");
                    currentLineLength = word.Length + 1;
                }
            }

            return result.ToString().Trim();
        }


        private void label9_Click(object sender, EventArgs e)
        {
            AniUA.main OpenMain = new AniUA.main();
            OpenMain.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            LoadEpisodes OpenLoadEpisodes = new LoadEpisodes();
            OpenLoadEpisodes.Show();
        }

        //
        private void LoadComment()
        {
            int animeID = int.Parse(Properties.Settings.Default.AnimeID);

            // Очистити попередні коментарі
            flowPanComments.Controls.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM comments WHERE ID_anime = @animeID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@animeID", animeID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Отримати дані коментаря з результуючого рядка
                            int userID = reader.GetInt32("ID_user");
                            string commentText = reader.GetString("comment");
                            float rating = reader.GetFloat("raiting");

                            //Перевірити, чи не порожній рядок коментаря
                            if (string.IsNullOrEmpty(commentText))
                            {
                                continue; //Пропустити поточну дію, якщо коментар порожній
                            }

                            //Виводяться дані коментаря
                            Panel newPanel = new Panel
                            {
                                BackColor = Color.FromArgb(22, 22, 22),
                                Width = 419,
                                Margin = new Padding(12),
                                AutoSize = true,
                                MaximumSize = new Size(419, int.MaxValue),
                                Padding = new Padding(4, 0, 4, 8)
                            };

                            string imagePath = "avatar.png";
                            Image avatarImage = Image.FromFile(imagePath);

                            PictureBox newImg = new PictureBox
                            {
                                Width = 64,
                                Height = 64,
                                BackColor = Color.FromArgb(32, 32, 32),
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Image = avatarImage
                            };

                            Label newNickname = new Label
                            {
                                Font = NAMUFont,
                                ForeColor = Color.White
                            };

                            string selectQuery = "SELECT nickname, avatar FROM user WHERE ID = @profileId;";

                            using (MySqlConnection connectiong = new MySqlConnection(connectionString))
                            {
                                connectiong.Open();

                                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connectiong))
                                {
                                    cmd.Parameters.Add("@profileId", MySqlDbType.Int32).Value = userID;

                                    using (MySqlDataReader readerg = cmd.ExecuteReader())
                                    {
                                        if (readerg.Read())
                                        {
                                            string nickname = readerg.GetString("nickname");
                                            newNickname.Text = nickname;

                                            if (!readerg.IsDBNull(readerg.GetOrdinal("avatar")))
                                            {
                                                byte[] avatarBytes = (byte[])readerg.GetValue(readerg.GetOrdinal("avatar"));
                                                using (MemoryStream ms = new MemoryStream(avatarBytes))
                                                {
                                                    newImg.Image = Image.FromStream(ms);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            newNickname.Location = new Point(74, 24);

                            Label newRating = new Label
                            {
                                Font = NAMUFont,
                                ForeColor = Color.White,
                                Text = $"{rating} з 5",
                                Location = new Point(363, 24)
                            };

                            Label newComment = new Label
                            {
                                Font = NAMUFont,
                                ForeColor = Color.White,
                                AutoSize = true,
                                Text = commentText
                            };

                            string wrappedText = WrapText(newComment.Text, 40);
                            newComment.Text = wrappedText;
                            newComment.Location = new Point(7, 67);

                            newPanel.Controls.Add(newImg);
                            newPanel.Controls.Add(newComment);
                            newPanel.Controls.Add(newRating);
                            newPanel.Controls.Add(newNickname);

                            flowPanComments.Controls.Add(newPanel);
                        }
                    }
                }

                connection.Close();
            }

            CalculateAnimeRating();
        }


        private void CreateComments()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                int userID = int.Parse(Properties.Settings.Default.UserID);
                int animeID = int.Parse(Properties.Settings.Default.AnimeID);
                string commentText = tComment.Text;
                float ratingB = (float)trackRating.Value;

                string checkQuery = "SELECT COUNT(*) FROM comments WHERE ID_user = @userID AND ID_anime = @animeID";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@userID", userID);
                    checkCommand.Parameters.AddWithValue("@animeID", animeID);

                    int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (rowCount > 0)
                    {
                        // Оновлення існуючого коментаря
                        string updateQuery = "UPDATE comments SET comment = @comment, raiting = @raiting WHERE ID_user = @userID AND ID_anime = @animeID";

                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@userID", userID);
                            updateCommand.Parameters.AddWithValue("@animeID", animeID);
                            updateCommand.Parameters.AddWithValue("@comment", commentText);
                            updateCommand.Parameters.AddWithValue("@raiting", ratingB);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Ви вже коментували, тому коментар був оновлений.");
                            LoadComment();
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(commentText))
                        {
                            DialogResult result = MessageBox.Show("Ви впевнені, що хочете лише оцінити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // Додавання нового коментаря
                                string insertQuery = "INSERT INTO comments (ID_user, ID_anime, comment, raiting) VALUES (@userID, @animeID, @comment, @raiting)";

                                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@userID", userID);
                                    insertCommand.Parameters.AddWithValue("@animeID", animeID);
                                    insertCommand.Parameters.AddWithValue("@comment", commentText);
                                    insertCommand.Parameters.AddWithValue("@raiting", ratingB);

                                    insertCommand.ExecuteNonQuery();

                                    LoadComment();
                                }
                            }
                            else if (result == DialogResult.No)
                            {
                                return;
                            }
                        }
                        else if (!string.IsNullOrEmpty(commentText))
                        {
                            if (commentText.Length > 400)
                            {
                                MessageBox.Show("Максимум 400 символів!", "Завеликий коментарій, зменште його.");
                                return;
                            }

                            // Додавання нового коментаря
                            string insertQuery = "INSERT INTO comments (ID_user, ID_anime, comment, raiting) VALUES (@userID, @animeID, @comment, @raiting)";

                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@userID", userID);
                                insertCommand.Parameters.AddWithValue("@animeID", animeID);
                                insertCommand.Parameters.AddWithValue("@comment", commentText);
                                insertCommand.Parameters.AddWithValue("@raiting", ratingB);

                                insertCommand.ExecuteNonQuery();

                                LoadComment();
                            }
                        }
                    }
                }

                connection.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CreateComments();
        }

        //Функція збереження або оновленя стаутусу аніме
        private void SaveOrUpdateStatus(int userID, int animeID, string status)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Перевірка, чи існує рядок status для даного користувача та аніме
                string checkQuery = "SELECT COUNT(*) FROM in_list WHERE ID_user = @userID AND ID_anime = @animeID";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@userID", userID);
                    checkCommand.Parameters.AddWithValue("@animeID", animeID);

                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        //Оновлення рядка status
                        string updateQuery = "UPDATE in_list SET status = @status WHERE ID_user = @userID AND ID_anime = @animeID";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@status", status);
                            updateCommand.Parameters.AddWithValue("@userID", userID);
                            updateCommand.Parameters.AddWithValue("@animeID", animeID);

                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        //Створення нового рядка з вибраним предметом
                        string insertQuery = "INSERT INTO in_list (ID_user, ID_anime, status) VALUES (@userID, @animeID, @status)";
                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@userID", userID);
                            insertCommand.Parameters.AddWithValue("@animeID", animeID);
                            insertCommand.Parameters.AddWithValue("@status", status);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                connection.Close();
            }
        }

        //Подія відбувається якщо вибраний предмет з статусу та зберігає або оновлює його
        private void statusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = statusList.SelectedItem.ToString();
            var selectedIndex = statusList.SelectedIndex;
            int userID; int.TryParse(Properties.Settings.Default.UserID, out userID);
            int animeID; int.TryParse(Properties.Settings.Default.AnimeID, out animeID);

            if (isUserInteraction == true)
            {
                if (selectedValue != null)
                {
                    if (selectedIndex == 0)//Не дивлюсь 
                    {
                        SaveOrUpdateStatus(userID, animeID, selectedValue);
                    }
                    else if (selectedIndex == 1)//Дивлюсь
                    {
                        SaveOrUpdateStatus(userID, animeID, selectedValue);
                    }
                    else if (selectedIndex == 2)//Заплановано
                    {
                        SaveOrUpdateStatus(userID, animeID, selectedValue);
                    }
                    else if (selectedIndex == 3)//Переглянуто
                    {
                        SaveOrUpdateStatus(userID, animeID, selectedValue);
                    }
                    else if (selectedIndex == 4)//Відкладено
                    {
                        SaveOrUpdateStatus(userID, animeID, selectedValue);
                    }
                    else if (selectedIndex == 5)//Закинуто
                    {
                        SaveOrUpdateStatus(userID, animeID, selectedValue);
                    }
                }
            }

            UpdateAnimeStatistics();  // Оновлення Статистики в БД
            pictureBox.Invalidate(); // Примусове оновлення pictureBox_Paint для перефарбування
            UpdateStatisticsText(); // Оновлення статистики в текстових полях
        }

        //Функція завантаження статусу аніме
        private void SetSelectSrarus()
        {
            isUserInteraction = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT status FROM in_list WHERE ID_user = @userID AND ID_anime = @animeID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@animeID", animeID);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string status = result.ToString();
                        int index = statusList.FindString(status);
                        statusList.SelectedIndex = index;
                    }
                }
                connection.Close();

                isUserInteraction = true;
            }
        }


        private void UpdateAnimeStatistics()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM anime_statistics WHERE ID_user = @userID AND ID_anime = @animeID";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@userID", userID);
                    checkCommand.Parameters.AddWithValue("@animeID", animeID);

                    int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (rowCount > 0)
                    {
                        // Оновлення існуючого рядка
                        string updateQuery = "UPDATE anime_statistics SET ";

                        string inListQuery = "SELECT status FROM in_list WHERE ID_user = @userID AND ID_anime = @animeID";
                        using (MySqlCommand inListCommand = new MySqlCommand(inListQuery, connection))
                        {
                            inListCommand.Parameters.AddWithValue("@userID", userID);
                            inListCommand.Parameters.AddWithValue("@animeID", animeID);

                            string status = inListCommand.ExecuteScalar()?.ToString();

                            if (!string.IsNullOrEmpty(status))
                            {
                                switch (status)
                                {
                                    case "Не дивлюсь":
                                        updateQuery += "watching = 0, planned = 0, revised = 0, postponed = 0, abandoned = 0";
                                        break;
                                    case "Дивлюсь":
                                        updateQuery += "watching = 1, planned = 0, revised = 0, postponed = 0, abandoned = 0";
                                        break;
                                    case "Заплановано":
                                        updateQuery += "watching = 0, planned = 1, revised = 0, postponed = 0, abandoned = 0";
                                        break;
                                    case "Переглянуто":
                                        updateQuery += "watching = 0, planned = 0, revised = 1, postponed = 0, abandoned = 0";
                                        break;
                                    case "Відкладено":
                                        updateQuery += "watching = 0, planned = 0, revised = 0, postponed = 1, abandoned = 0";
                                        break;
                                    case "Закинуто":
                                        updateQuery += "watching = 0, planned = 0, revised = 0, postponed = 0, abandoned = 1";
                                        break;
                                    default:
                                        return;
                                }

                                updateQuery += " WHERE ID_user = @userID AND ID_anime = @animeID";

                                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@userID", userID);
                                    updateCommand.Parameters.AddWithValue("@animeID", animeID);
                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else
                    {
                        // Створення нового рядка
                        string insertQuery = "INSERT INTO anime_statistics (ID_user, ID_anime, watching, planned, revised, postponed, abandoned) " +
                                             "VALUES (@userID, @animeID, 0, 0, 0, 0, 0)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@userID", userID);
                            insertCommand.Parameters.AddWithValue("@animeID", animeID);
                            insertCommand.ExecuteNonQuery();
                        }

                        // Оновлення статусу
                        string updateStatusQuery = "UPDATE anime_statistics SET watching = @watching, planned = @planned, revised = @revised, postponed = @postponed, abandoned = @abandoned " +
                                                    "WHERE ID_user = @userID AND ID_anime = @animeID";

                        using (MySqlCommand updateStatusCommand = new MySqlCommand(updateStatusQuery, connection))
                        {
                            updateStatusCommand.Parameters.AddWithValue("@userID", userID);
                            updateStatusCommand.Parameters.AddWithValue("@animeID", animeID);
                            updateStatusCommand.Parameters.AddWithValue("@watching", 0);
                            updateStatusCommand.Parameters.AddWithValue("@planned", 0);
                            updateStatusCommand.Parameters.AddWithValue("@revised", 0);
                            updateStatusCommand.Parameters.AddWithValue("@postponed", 0);
                            updateStatusCommand.Parameters.AddWithValue("@abandoned", 0);

                            string status = updateStatusCommand.ExecuteScalar()?.ToString();

                            // Встановлення відповідних значень для полів в залежності від статусу
                            switch (status)
                            {
                                case "Не дивлюсь":
                                    updateStatusCommand.Parameters.AddWithValue("@watching", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@planned", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@revised", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@postponed", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@abandoned", 0);
                                    break;
                                case "Дивлюсь":
                                    updateStatusCommand.Parameters.AddWithValue("@watching", 1);
                                    updateStatusCommand.Parameters.AddWithValue("@planned", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@revised", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@postponed", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@abandoned", 0);
                                    break;
                                case "Заплановано":
                                    updateStatusCommand.Parameters.AddWithValue("@watching", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@planned", 1);
                                    updateStatusCommand.Parameters.AddWithValue("@revised", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@postponed", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@abandoned", 0);
                                    break;
                                case "Переглянуто":
                                    updateStatusCommand.Parameters.AddWithValue("@watching", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@planned", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@revised", 1);
                                    updateStatusCommand.Parameters.AddWithValue("@postponed", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@abandoned", 0);
                                    break;
                                case "Відкладено":
                                    updateStatusCommand.Parameters.AddWithValue("@watching", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@planned", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@revised", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@postponed", 1);
                                    updateStatusCommand.Parameters.AddWithValue("@abandoned", 0);
                                    break;
                                case "Закинуто":
                                    updateStatusCommand.Parameters.AddWithValue("@watching", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@planned", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@revised", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@postponed", 0);
                                    updateStatusCommand.Parameters.AddWithValue("@abandoned", 1);
                                    break;
                                default:
                                    return;
                            }

                            updateStatusCommand.ExecuteNonQuery();
                        }
                    }
                }

                connection.Close();
            }
        }

        //ЧекБокс Зберегти
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string saveStatus = checkBox.Checked ? "Збережено" : "Не збережено";
            SaveOrUpdateSaveStatus(saveStatus);
            CheckSaveStatus();
        }

        //Функція збереженя статусу "Збережено", або "Не збережено"
        private void SaveOrUpdateSaveStatus(string saveStatus)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM in_list WHERE ID_user = @userID AND ID_anime = @animeID";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@userID", userID);
                    checkCommand.Parameters.AddWithValue("@animeID", animeID);

                    int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (rowCount > 0)
                    {
                        //Оновлення існуючого рядка
                        string updateQuery = "UPDATE in_list SET save = @saveStatus WHERE ID_user = @userID AND ID_anime = @animeID";

                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@userID", userID);
                            updateCommand.Parameters.AddWithValue("@animeID", animeID);
                            updateCommand.Parameters.AddWithValue("@saveStatus", saveStatus);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        //Створення нового рядка
                        string insertQuery = "INSERT INTO in_list (ID_user, ID_anime, status, save) " +
                                             "VALUES (@userID, @animeID, '', @saveStatus)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@userID", userID);
                            insertCommand.Parameters.AddWithValue("@animeID", animeID);
                            insertCommand.Parameters.AddWithValue("@saveStatus", saveStatus);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                connection.Close();
            }
        }

        //Функція перевірки галочки в ЧекБоксі
        private void CheckSaveStatus()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT save FROM in_list WHERE ID_user = @userID AND ID_anime = @animeID";
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userID", userID);
                    selectCommand.Parameters.AddWithValue("@animeID", animeID);

                    string saveStatus = selectCommand.ExecuteScalar()?.ToString();

                    if (saveStatus == "Збережено")
                    {
                        checkBox.Checked = true;
                    }
                    else
                    {
                        checkBox.Checked = false;
                    }
                }

                connection.Close();
            }
        }

        //Функція яка розрахунку рейтингу
        private void CalculateAnimeRating()
        {
            int animeID = int.Parse(Properties.Settings.Default.AnimeID);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT AVG(raiting) FROM comments WHERE ID_anime = @animeID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@animeID", animeID);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        float averageRating = Convert.ToSingle(result);
                        string formattedRating = averageRating.ToString("0.0");
                        textRaiting.Text = formattedRating;
                    }
                    else
                    {
                        textRaiting.Text = "Немає рейтингу";
                    }
                }

                connection.Close();
            }
        }
    }
}
