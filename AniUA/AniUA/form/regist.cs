using AniUA.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AniUA
{
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();
            imgEyeOff.Hide();

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;
        }

        private void clickThis_Click(object sender, EventArgs e)
        {
            login OpenLogin = new login();
            OpenLogin.Show();

            this.Hide();
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isSaze = false;
        private Size previousSize;
        private void buttSize_Click(object sender, EventArgs e)
        {
            if (isSaze)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = previousSize;
            }
            else
            {
                previousSize = this.Size;
                this.WindowState = FormWindowState.Maximized;
            }

            isSaze = !isSaze;
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

        private void imgEyeOn_Click(object sender, EventArgs e)
        {
            imgEyeOff.Show();
            imgEyeOn.Hide();

            textPassword1.UseSystemPasswordChar = false;
            textPassword2.UseSystemPasswordChar = false;
        }

        private void imgEyeOff_Click(object sender, EventArgs e)
        {
            imgEyeOn.Show();
            imgEyeOff.Hide();

            textPassword1.UseSystemPasswordChar = true;
            textPassword2.UseSystemPasswordChar = true;
        }

        private void butRegist_Click(object sender, EventArgs e)
        {
            //перевірка введених даних
            if (textNickname.Text == "")
            {
                MessageBox.Show("Введіть нікнейм");
                return;
            }
            if (ContainsCyrillicCharacters(textNickname.Text) || !ContainsOnlyEnglishLetters(textNickname.Text))
            {
                MessageBox.Show("Ім'я користувача може містити лише англійські символи, та не може містити пробіли!");
                return;
            }
            if (textNickname.Text.Contains(" "))
            {
                MessageBox.Show("Ім'я користувача не може містити пробіли!");
                return;
            }

            if (textPassword1.Text == "")
            {
                MessageBox.Show("Введіть пароль");
                return;
            }
            if (textPassword2.Text == "")
            {
                MessageBox.Show("Введіть підтвердженя пароля");
                return;
            }
            if (textPassword1.Text != textPassword2.Text)
            {
                MessageBox.Show("Паролі не співпадають");
                return;
            }
            if (isUserExists() == true)
                return;

            if (!IsValidEmail(textEmail.Text))
            {
                MessageBox.Show("Введіть дійсну адресу електронної пошти!");
                return;
            }

            //Довжина поролю
            if (textPassword1.Text.Length < 4 || textPassword1.Text.Length > 20)
            {
                MessageBox.Show("Пароль повинен бути більшим за 4 символи та меншим за 20");
                return;
            }

            //створеня БД
            DBregLog db = new DBregLog();

            //Створення команди (Sql команда)
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `user` (`nickname`, `password`, `email`) VALUES (@nickUser, @pasUser, @email);", db.GetConnection());

            //Створення даних для заглушок (зверненя до команти)
            cmd.Parameters.Add("@nickUser", MySqlDbType.VarChar).Value = textNickname.Text;
            cmd.Parameters.Add("@pasUser", MySqlDbType.VarChar).Value = textPassword1.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textEmail.Text;

            //звертаня до БД для підключення
            db.OpenConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ви зареєструвались");

                login OpenLogin = new login();
                OpenLogin.Show();

                this.Hide();
            }
            else
                MessageBox.Show("Перевірте введені дані");

            //звертаня до БД для виходу
            db.CloseConnection();
        }


        //Функція на перевірку повторення нікнейму користувача
        public Boolean isUserExists()
        {
            //створеня БД
            DBregLog db = new DBregLog();

            //створення таблиці
            DataTable table = new DataTable();

            //створення адаптера
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //Створення команди (Sql команда)
            //ВИДРАТИ все (в таблиці user) де нікнейм = введеному нікнейму І пароль = введеному паролю, підключеня до БД
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `user` WHERE `nickname` = @nickUser", db.GetConnection());//@nickUser та @pasUser це заглушки для того щоб було ваще взловати БД

            //Створення даних для заглушок (зверненя до команти)
            cmd.Parameters.Add("@nickUser", MySqlDbType.VarChar).Value = textNickname.Text;

            //зверненя до адаптера для виконання команди "cmd"
            adapter.SelectCommand = cmd;
            //заповнення даних в таблицю з тих які отримали через команду "cmd"
            adapter.Fill(table);

            //Звернення до таблиці і рахуємо кількість рядків
            //якщо їх більше 0, то користувач існує, і виводиться повідомлення
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий нікнейм вже існує, використайте інший");
                return true;
            }
            else
                return false;
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
    }
}
