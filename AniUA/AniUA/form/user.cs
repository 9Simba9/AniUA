using AniUA.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AniUA.form
{
    public partial class user : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";
        int ProfilID = Convert.ToInt32(Properties.Settings.Default.UserID);

        public user()
        {
            InitializeComponent();

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;


        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AniUA.main OpenMain = new AniUA.main();
            OpenMain.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            save.save OpenMain = new save.save();
            OpenMain.Show();

            this.Hide();
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            Font currentFont = label13.Font;
            label13.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            Font currentFont = label13.Font;
            label13.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Font currentFont = label4.Font;
            label4.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Font currentFont = label4.Font;
            label4.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
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

        private string selectedFile;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            long maxSize = 5 * 1024 * 1024; // 5 MB

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(selectedFile);

                if (fileInfo.Length > maxSize)
                {
                    MessageBox.Show("Вибраний файл завеликий. Будь ласка, виберіть файл меншого розміру. 5МБ", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Image image = Image.FromFile(selectedFile);

                if (!IsSquareImage(image))
                {
                    MessageBox.Show("Вибране зображення не має пропорцій 1:1 квадрат. Будь ласка, виберіть інше зображення.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                avatar.Image = image;
            }
        }

        private bool IsSquareImage(Image image)
        {
            return image.Width == image.Height;
        }

        string ProfilEmail = "exemp@gmail.com";
        private void button1_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = true;
            editNickname.Text = NickName.Text;

            string query = "SELECT email FROM user WHERE ID = @profilID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@profilID", MySqlDbType.Int32).Value = ProfilID;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Перевірка, чи є рядок результату
                        if (reader.Read())
                        {
                            ProfilEmail = reader.GetString(0);
                        }
                    }
                }
            }

            editEmail.Text = ProfilEmail;
        }

        //Збереження зображення без аватарки
        string imagePath = "avatar.png";
        private void saveProfil_Click(object sender, EventArgs e)
        {
            string newNickname = editNickname.Text;
            string password = PassworD.Text;
            string newEmail = editEmail.Text;

            if (newNickname == "" || password == "" || newEmail == "")
            {
                MessageBox.Show("Заповніть пусті поля!");
                return;
            }
            if (ContainsCyrillicCharacters(newNickname) || !ContainsOnlyEnglishLetters(newNickname))
            {
                MessageBox.Show("Ім'я користувача може містити лише англійські символи, та не може містити пробіли!");
                return;
            }
            if (!IsValidEmail(newEmail))
            {
                MessageBox.Show("Введіть дійсну адресу електронної пошти!");
                return;
            }

            if (selectedFile != null) //Перевірка, чи файл був вибраний
            {
                FileInfo fileInfo = new FileInfo(selectedFile);
                long maxSize = 5 * 1024 * 1024; // 5 MB

                if (fileInfo.Length > maxSize)
                {
                    MessageBox.Show("Вибраний файл завеликий. Будь ласка, виберіть файл меншого розміру (5 МБ або менше).", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] fileBytes = System.IO.File.ReadAllBytes(selectedFile);
            }

            string updateQuery = "UPDATE user SET nickname = @newNickname, email = @newEmail";

            if (selectedFile != null) //Перевірка, чи файл був вибраний
            {
                updateQuery += ", avatar = @fileBytes";
            }
            else
            {
                updateQuery += ", avatar = NULL";
                avatar.Image = Image.FromFile(imagePath);
            }

            updateQuery += " WHERE ID = @profileId AND password = @password;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.Add("@newNickname", MySqlDbType.VarChar).Value = newNickname;
                    cmd.Parameters.Add("@newEmail", MySqlDbType.VarChar).Value = newEmail;
                    cmd.Parameters.Add("@profileId", MySqlDbType.Int32).Value = ProfilID;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                    if (selectedFile != null) //Перевірка, чи файл був вибраний
                    {
                        FileInfo fileInfo = new FileInfo(selectedFile);
                        long maxSize = 5 * 1024 * 1024; // 5 MB

                        if (fileInfo.Length > maxSize)
                        {
                            MessageBox.Show("Вибраний файл завеликий. Будь ласка, виберіть файл меншого розміру (5 МБ або менше).", "Помилка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        byte[] fileBytes = System.IO.File.ReadAllBytes(selectedFile);

                        cmd.Parameters.Add("@fileBytes", MySqlDbType.LongBlob).Value = fileBytes;
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Профіль успішно оновлено");
                    }
                    else
                    {
                        MessageBox.Show("Неправильний пароль");
                    }
                }
            }

            EditPanel.Visible = false;
            LoadUserProfile();
        }


        private void user_Load(object sender, EventArgs e)
        {
            LoadUserProfile();

            LoadAnimeStatistics();
        }

        private void LoadAnimeStatistics()
        {
            string selectQuery = "SELECT watching, planned, revised, postponed, abandoned FROM anime_statistics WHERE ID_user = @userID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@userID", Properties.Settings.Default.UserID);

                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int totalWatching = 0;
                        int totalPlanned = 0;
                        int totalRevised = 0;
                        int totalPostponed = 0;
                        int totalAbandoned = 0;

                        while (reader.Read())
                        {
                            int watchingValue = Convert.ToInt32(reader["watching"]);
                            int plannedValue = Convert.ToInt32(reader["planned"]);
                            int revisedValue = Convert.ToInt32(reader["revised"]);
                            int postponedValue = Convert.ToInt32(reader["postponed"]);
                            int abandonedValue = Convert.ToInt32(reader["abandoned"]);

                            totalWatching += watchingValue;
                            totalPlanned += plannedValue;
                            totalRevised += revisedValue;
                            totalPostponed += postponedValue;
                            totalAbandoned += abandonedValue;
                        }

                        watching.Text = totalWatching.ToString();
                        planned.Text = totalPlanned.ToString();
                        revised.Text = totalRevised.ToString();
                        postponed.Text = totalPostponed.ToString();
                        abandoned.Text = totalAbandoned.ToString();

                        // Оновлення діаграми
                        Series series = statystic.Series["view"];
                        series.Points[0].YValues[0] = totalWatching;
                        series.Points[1].YValues[0] = totalPlanned;
                        series.Points[2].YValues[0] = totalRevised;
                        series.Points[3].YValues[0] = totalPostponed;
                        series.Points[4].YValues[0] = totalAbandoned;
                    }
                }
            }
        }




        private void LoadUserProfile()
        {
            string selectQuery = "SELECT nickname, avatar FROM user WHERE ID = @profileId;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.Add("@profileId", MySqlDbType.Int32).Value = ProfilID;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Зчитування значення nickname з рядка
                            string nickname = reader.GetString("nickname");
                            NickName.Text = nickname;

                            // Зчитування значення avatar з рядка
                            if (!reader.IsDBNull(reader.GetOrdinal("avatar")))
                            {
                                byte[] avatarBytes = (byte[])reader.GetValue(reader.GetOrdinal("avatar"));
                                using (MemoryStream ms = new MemoryStream(avatarBytes))
                                {
                                    avatar.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
        }


        //Функція на перевірку електроної пошти
        private bool IsValidEmail(string email)
        {
            // Регулярний вираз для перевірки електронної пошти
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        //Функції на перевірку символів нікнейму користувача
        private bool ContainsCyrillicCharacters(string text)
        {
            string pattern = @"[\p{IsCyrillic}]";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(text);
        }
        private bool ContainsOnlyEnglishLetters(string text)
        {
            string pattern = @"^[a-zA-Z]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(text);
        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StatusLogin = false;
            Properties.Settings.Default.StatusLoginAdmin = false;
            //Збереженя параметрів додатку, а саме UserID та StatusLogin
            Properties.Settings.Default.Save();

            login OpenLogin = new login();
            OpenLogin.Show();
            this.Hide();
        }

        private void textExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StatusLogin = false;
            Properties.Settings.Default.StatusLoginAdmin = false;
            //Збереженя параметрів додатку, а саме UserID та StatusLogin
            Properties.Settings.Default.Save();

            login OpenLogin = new login();
            OpenLogin.Show();
            this.Hide();
        }
    }
}