using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;

namespace AniUA.form
{
    public partial class editUser : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";

        public editUser()
        {
            InitializeComponent();

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID, nickname, password, email, avatar, status FROM user";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                DBuser.DataSource = dataTable;
                

                // Встановлення горизонтального вирівнювання для кожної колонки
                DBuser.Columns["ID"].Width = 40;
                DBuser.Columns["nickname"].Width = 140;
                DBuser.Columns["password"].Width = 140;
                DBuser.Columns["email"].Width = 200;
                DBuser.Columns["avatar"].Width = 50;
                DBuser.Columns["status"].Width = 60;


            }
        }

        private void editUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void DBuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Перевірити, чи було клікнуто на рядок, а не на заголовок стовпця
            if (e.RowIndex >= 0)
            {
                //Отримати дані з вибраного рядка
                DataGridViewRow selectedRow = DBuser.Rows[e.RowIndex];
                string id = selectedRow.Cells["ID"].Value.ToString();
                string nickname = selectedRow.Cells["nickname"].Value.ToString();
                string password = selectedRow.Cells["password"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string avatar = selectedRow.Cells["avatar"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();

                //Завантажити дані у TextBox
                ID.Text = id;
                Nickname.Text = nickname;
                Password.Text = password;
                Email.Text = email;
                Status.Text = status;
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            int selectedUserId = Convert.ToInt32(DBuser.CurrentRow.Cells["ID"].Value);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Видаляємо всі записи з таблиці anime_statistics, пов'язані з вибраним користувачем
                string deleteAnimeStatisticsQuery = $"DELETE FROM anime_statistics WHERE ID_user = {selectedUserId}";
                MySqlCommand deleteAnimeStatisticsCommand = new MySqlCommand(deleteAnimeStatisticsQuery, connection);
                deleteAnimeStatisticsCommand.ExecuteNonQuery();

                //Видаляємо всі записи з таблиці in_list, пов'язані з вибраним користувачем
                string deleteInListQuery = $"DELETE FROM in_list WHERE ID_user = {selectedUserId}";
                MySqlCommand deleteInListCommand = new MySqlCommand(deleteInListQuery, connection);
                deleteInListCommand.ExecuteNonQuery();

                //Видаляємо самого користувача
                string deleteUserQuery = $"DELETE FROM user WHERE ID = {selectedUserId}";
                MySqlCommand deleteUserCommand = new MySqlCommand(deleteUserQuery, connection);
                deleteUserCommand.ExecuteNonQuery();

                connection.Close();

                LoadUsers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE user SET nickname = @newNickname WHERE ID = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@newNickname", Convert.ToString(Nickname.Text));
                command.Parameters.AddWithValue("@id", ID.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadUsers();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE user SET password = @newPassword WHERE ID = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@newPassword", Convert.ToString(Password.Text));
                command.Parameters.AddWithValue("@id", ID.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadUsers();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE user SET email = @newEmail WHERE ID = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@newEmail", Convert.ToString(Email.Text));
                command.Parameters.AddWithValue("@id", ID.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadUsers();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE user SET status = @newStatus WHERE ID = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@newStatus", Convert.ToString(Status.Text));
                command.Parameters.AddWithValue("@id", ID.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadUsers();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //перевірка введених даних
            if (Nickname.Text == "")
            {
                MessageBox.Show("Введіть нікнейм");
                return;
            }
            if (ContainsCyrillicCharacters(Nickname.Text) || !ContainsOnlyEnglishLetters(Nickname.Text))
            {
                MessageBox.Show("Ім'я користувача може містити лише англійські символи, та не може містити пробіли!");
                return;
            }
            if (Nickname.Text.Contains(" "))
            {
                MessageBox.Show("Ім'я користувача не може містити пробіли!");
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("Введіть пароль");
                return;
            }
            if (!IsValidEmail(Email.Text))
            {
                MessageBox.Show("Введіть дійсну адресу електронної пошти!");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE user SET nickname = @newNickname, password = @newPassword, email = @newEmail, status = @newStatus WHERE ID = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@newNickname", Convert.ToString(Nickname.Text));
                command.Parameters.AddWithValue("@newPassword", Convert.ToString(Password.Text));
                command.Parameters.AddWithValue("@newEmail", Convert.ToString(Email.Text));
                command.Parameters.AddWithValue("@newStatus", Convert.ToString(Status.Text));
                command.Parameters.AddWithValue("@id", ID.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadUsers();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            mainAdmin OpenMainAdmin = new mainAdmin();
            OpenMainAdmin.Show();
            this.Hide();
        }
    }
}
