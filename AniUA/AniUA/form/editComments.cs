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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AniUA.form
{
    public partial class editComments : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";

        public editComments()
        {
            InitializeComponent();

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadComments()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID, ID_user, ID_anime, comment, raiting FROM comments";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                DBcomments.DataSource = dataTable;


                // Встановлення горизонтального вирівнювання для кожної колонки
                DBcomments.Columns["ID"].Width = 40;
                DBcomments.Columns["ID_user"].Width = 40;
                DBcomments.Columns["ID_anime"].Width = 40;
                DBcomments.Columns["comment"].Width = 780;
                DBcomments.Columns["raiting"].Width = 40;
            }
        }

        private void editComments_Load(object sender, EventArgs e)
        {
            LoadComments();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            mainAdmin OpenMainAdmin = new mainAdmin();
            OpenMainAdmin.Show();
            this.Hide();
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE comments SET comment = @comment, raiting = @raiting WHERE ID = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@comment", Convert.ToString(Comment.Text));
                command.Parameters.AddWithValue("@raiting", Convert.ToString(Rating.Text));
                command.Parameters.AddWithValue("@id", ID.Text);
                command.ExecuteNonQuery();

                connection.Close();

                LoadComments();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            int selectedCommId = Convert.ToInt32(DBcomments.CurrentRow.Cells["ID"].Value);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM comments WHERE ID = {selectedCommId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();

                LoadComments();
            }
        }

        private void DBcomments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Перевірити, чи було клікнуто на рядок, а не на заголовок стовпця
            if (e.RowIndex >= 0)
            {
                //Отримати дані з вибраного рядка
                DataGridViewRow selectedRow = DBcomments.Rows[e.RowIndex];
                string id = selectedRow.Cells["ID"].Value.ToString();
                string IdUser = selectedRow.Cells["ID_user"].Value.ToString();
                string IdAnime = selectedRow.Cells["ID_anime"].Value.ToString();
                string comment = selectedRow.Cells["comment"].Value.ToString();
                string raiting = selectedRow.Cells["raiting"].Value.ToString();

                //Завантажити дані у TextBox
                ID.Text = id;
                IDuser.Text = IdUser;
                IDanime.Text = IdAnime;
                Comment.Text = comment;
                Rating.Text = raiting;
            }
        }
    }
}
