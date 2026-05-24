using AniUA.DB;
using AniUA.form;
using AniUA.form.main;
using AniUA.form.save;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace AniUA
{
    public partial class main : Form
    {
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=aniua";

        private Font NAMUFont;
        public main()
        {
            InitializeComponent();
            NAMUFont = new Font("NAMU 1750", 14);

            //розгортання вікна на весь екран
            this.WindowState = FormWindowState.Maximized;

            //підкруслення "Останні" в Головній
            Font currentFont = label13.Font;
            label13.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline);

            Font currentFont1 = label3.Font;
            label3.Font = new Font(currentFont1.FontFamily, currentFont1.Size, FontStyle.Underline);
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MouseEnter_Button(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void MouseLeave_Button(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(25, 25, 25);
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label label = (Label)sender;
                Font currentFont = label.Font;
                label.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline);
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label label = (Label)sender;
                Font currentFont = label.Font;
                label.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            save OpenSaves = new save();
            OpenSaves.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            user OpenUser = new user();
            OpenUser.Show();
            this.Hide();
        }

        //Функція для назви...
        private string TruncateText(string text)
        {
            const int maxLength = 28;

            if (text.Length <= maxLength)
            {
                return text;
            }
            else
            {
                string truncatedText = text.Substring(0, maxLength - 4) + "...";
                return truncatedText;
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            LoadAllAnime();
        }
        
        //Функція для перевірки ID елементу
        private void CheckClickedElementName(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl != null)
            {
                string elementName = clickedControl.Name;
                int index = elementName.IndexOf("_ID");
                if (index != -1 && index + 3 < elementName.Length)
                {
                    string id = elementName.Substring(index + 3);
                    Properties.Settings.Default.AnimeID = id;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Ім'я елемента не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadAllAnime()
        {
            // Очистити попередні коментарі
            flowPanelAnime.Controls.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM anime";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Отримати дані коментаря з результуючого рядка
                            int animeID = reader.GetInt32("ID_anime");
                            string animeName = reader.GetString("name");
                            byte[] logo = (byte[])reader["logo"];

                            //Створеня об'єкту Image з масиву байтів logo, для зображеня
                            using (MemoryStream ms = new MemoryStream(logo))
                            {
                                Image image = Image.FromStream(ms);

                                //Виводяться дані аніме
                                Panel newPanel = new Panel
                                {
                                    BackColor = Color.FromArgb(36, 36, 36),
                                    Width = 286,
                                    Height = 438,
                                    Margin = new Padding(14, 18, 14, 18),
                                    AutoSize = false,
                                    MaximumSize = new Size(286, int.MaxValue),
                                    Name = "Panel_ID" + animeID,
                                    Cursor = Cursors.Hand
                                };

                                PictureBox newImg = new PictureBox
                                {
                                    Width = 286,
                                    Height = 402,
                                    BackColor = Color.FromArgb(36, 36, 36),
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Image = image,
                                    Name = "Img_ID" + animeID,
                                    Cursor = Cursors.Hand
                                };

                                Label newText = new Label
                                {
                                    Font = NAMUFont,
                                    ForeColor = Color.White,
                                    Location = new Point(0, 405),
                                    AutoSize = true,
                                    Text = animeName,
                                    Name = "Text_ID" + animeID,
                                    Cursor = Cursors.Hand
                                };

                                //Додавання обробник події Click до newImg
                                newImg.Click += (sender, e) => {
                                    CheckClickedElementName(sender, e);

                                    LoadAnime OpenLoadAnime = new LoadAnime();
                                    OpenLoadAnime.Show();

                                    this.Hide();
                                };

                                //Додавання обробник події Click до newText
                                newText.Click += (sender, e) => {
                                    CheckClickedElementName(sender, e);

                                    LoadAnime OpenLoadAnime = new LoadAnime();
                                    OpenLoadAnime.Show();

                                    this.Hide();
                                };

                                //Додавання обробник події Click до newPanel
                                newPanel.Click += (sender, e) => {
                                    CheckClickedElementName(sender, e);

                                    LoadAnime OpenLoadAnime = new LoadAnime();
                                    OpenLoadAnime.Show();

                                    this.Hide();
                                };

                                string editText = TruncateText(newText.Text); newText.Text = editText;

                                newPanel.Controls.Add(newImg);
                                newPanel.Controls.Add(newText);

                                flowPanelAnime.Controls.Add(newPanel);
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        private void SearchAllAnime()
        {
            //Очистити попередні коментарі
            flowPanelAnime.Controls.Clear();

            string searchText = search.Text; //Отримати текст для пошуку

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM anime WHERE name LIKE @searchText OR original_name LIKE @searchText";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int animeID = reader.GetInt32("ID_anime");
                            string animeName = reader.GetString("name");
                            byte[] logo = (byte[])reader["logo"];

                            //Створення об'єкту Image з масиву байтів logo, для зображення
                            using (MemoryStream ms = new MemoryStream(logo))
                            {
                                Image image = Image.FromStream(ms);

                                Panel newPanel = new Panel
                                {
                                    BackColor = Color.FromArgb(36, 36, 36),
                                    Width = 286,
                                    Height = 438,
                                    Margin = new Padding(14, 18, 14, 18),
                                    AutoSize = false,
                                    MaximumSize = new Size(286, int.MaxValue),
                                    Name = "Panel_ID" + animeID,
                                    Cursor = Cursors.Hand
                                };

                                PictureBox newImg = new PictureBox
                                {
                                    Width = 286,
                                    Height = 402,
                                    BackColor = Color.FromArgb(36, 36, 36),
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Image = image,
                                    Name = "Img_ID" + animeID,
                                    Cursor = Cursors.Hand
                                };

                                Label newText = new Label
                                {
                                    Font = NAMUFont,
                                    ForeColor = Color.White,
                                    Location = new Point(0, 405),
                                    AutoSize = true,
                                    Text = animeName,
                                    Name = "Text_ID" + animeID,
                                    Cursor = Cursors.Hand
                                };

                                newImg.Click += (sender, e) => {
                                    CheckClickedElementName(sender, e);

                                    LoadAnime OpenLoadAnime = new LoadAnime();
                                    OpenLoadAnime.Show();

                                    this.Hide();
                                };

                                newText.Click += (sender, e) => {
                                    CheckClickedElementName(sender, e);

                                    LoadAnime OpenLoadAnime = new LoadAnime();
                                    OpenLoadAnime.Show();

                                    this.Hide();
                                };

                                newPanel.Click += (sender, e) => {
                                    CheckClickedElementName(sender, e);

                                    LoadAnime OpenLoadAnime = new LoadAnime();
                                    OpenLoadAnime.Show();

                                    this.Hide();
                                };

                                string editText = TruncateText(newText.Text); newText.Text = editText;

                                newPanel.Controls.Add(newImg);
                                newPanel.Controls.Add(newText);

                                flowPanelAnime.Controls.Add(newPanel);
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SearchAllAnime();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            announce announce = new announce();
            announce.Show();
            this.Hide();
        }

        private void catT_Click(object sender, EventArgs e)
        {
            completed completed = new completed();
            completed.Show();
            this.Hide();
        }

        private void catO_Click(object sender, EventArgs e)
        {
            films films = new films();
            films.Show();
            this.Hide();
        }
    }
}
