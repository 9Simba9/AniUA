using AniUA.DB;
using AniUA.form;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniUA
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            imgEyeOff.Hide();

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            buttClose.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            buttClose.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            buttTurn.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            buttTurn.BackColor = Color.FromArgb(25, 25, 25);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Збереженя параметрів додатку, а саме UserID та StatusLogin
            Properties.Settings.Default.Save();

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clickThis_Click(object sender, EventArgs e)
        {
            regist OpenRegist = new regist();
            OpenRegist.Show();

            this.Hide();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            //Створення зміних з полів нікнейму та паролю для перевірки в БД
            String nicknameUser = textNickname.Text;
            String PasswordUser = textPassword.Text;

            //перевірка введених даних
            if(nicknameUser == "")
            {
                MessageBox.Show("Введіть нікнейм");
                return;
            }
            if (PasswordUser == "")
            {
                MessageBox.Show("Введіть пароль");
                return;
            }

            //створеня БД
            DBregLog db = new DBregLog();

            //створення таблиці
            DataTable table = new DataTable();

            //створення адаптера
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //Створення команди (Sql команда)
            //ВИДРАТИ все (в таблиці user) де нікнейм = введеному нікнейму І пароль = введеному паролю, підключеня до БД
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `user` WHERE `nickname` = @nickUser AND `password` = @pasUser", db.GetConnection());//@nickUser та @pasUser це заглушки для того щоб було ваще взловати БД
            
            //Створення даних для заглушок (зверненя до команти)
            cmd.Parameters.Add("@nickUser", MySqlDbType.VarChar).Value = nicknameUser;
            cmd.Parameters.Add("@pasUser", MySqlDbType.VarChar).Value = PasswordUser;
            
            //зверненя до адаптера для виконання команди "cmd"
            adapter.SelectCommand = cmd;
            //заповнення даних в таблицю з тих які отримали через команду "cmd"
            adapter.Fill(table);

            //Звернення до таблиці і рахуємо кількість рядків
            //якщо їх більше 0, то користувач існує, і виводиться повідомлення
            if (table.Rows.Count > 0)
            {
                // Отримання ідентифікатора користувача з першого рядка результату запиту
                int userId = Convert.ToInt32(table.Rows[0]["id"]);

                //Збереження параметру id користувач, ID = 1
                Properties.Settings.Default.UserID = userId.ToString();

                // Перевірка статусу користувача
                string status = table.Rows[0]["status"].ToString();
                if (status == "admin" && nicknameUser == table.Rows[0]["nickname"].ToString() && PasswordUser == table.Rows[0]["password"].ToString())
                {
                    Properties.Settings.Default.StatusLoginAdmin = true;
                    Properties.Settings.Default.StatusLogin = false;
                    Properties.Settings.Default.Save();

                    mainAdmin OpenMainAdmin = new mainAdmin();
                    OpenMainAdmin.Show();
                    this.Hide();
                }
                else if (status != "admin")
                {
                    Properties.Settings.Default.StatusLogin = true;
                    Properties.Settings.Default.StatusLoginAdmin = false;
                    Properties.Settings.Default.Save();

                    main OpenMain = new main();
                    OpenMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Перевірте введені дані");
                }
            }
            else if(nicknameUser != "" || PasswordUser != "")
                MessageBox.Show("Перевірте введені дані");
            else
                MessageBox.Show("Перевірте введені дані");
        }

        private void login_Load(object sender, EventArgs e)
        {
            // Перевірка входу користувача
            if (Properties.Settings.Default.StatusLoginAdmin == true)
            {
                mainAdmin OpenMainAdmin = new mainAdmin();
                OpenMainAdmin.Show();
                this.Hide();
            }
            else if (Properties.Settings.Default.StatusLoginAdmin == false)
            {
                if (Properties.Settings.Default.StatusLogin == true)
                {
                    main OpenMain = new main();
                    OpenMain.Show();
                    this.Hide();
                }
            }
            
        }


        private void imgEye_Click(object sender, EventArgs e)
        {
            imgEyeOff.Show();
            imgEyeOn.Hide();

            textPassword.UseSystemPasswordChar = false;
        }
        private void imgEyeOff_Click(object sender, EventArgs e)
        {
            imgEyeOn.Show();
            imgEyeOff.Hide();

            textPassword.UseSystemPasswordChar = true;
        }
    }
}
