using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Main";
        }
        public void updateButton()
        {

            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=movies"))
            {
                MySqlCommand command =
                new MySqlCommand("SELECT * FROM movie1", connection);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())

                    while (reader.Read())
                    {
                        button4.Text = (reader["movieName"].ToString() + " " + reader["movieTime"].ToString());

                    }
                MySqlCommand command1 =
                new MySqlCommand("SELECT * from movie2 ", connection);

                using (MySqlDataReader reader1 = command1.ExecuteReader())
                    while (reader1.Read())
                    {
                        button5.Text = (reader1["movieName"].ToString() + " " + reader1["movieTime"].ToString());
                    }
                MySqlCommand command2 =
               new MySqlCommand("SELECT * from movie3 ", connection);

                using (MySqlDataReader reader2 = command2.ExecuteReader())
                    while (reader2.Read())
                    {
                        button6.Text = (reader2["movieName"].ToString() + " " + reader2["movieTime"].ToString());
                    }
                MySqlCommand command3 =
               new MySqlCommand("SELECT * from movie4 ", connection);

                using (MySqlDataReader reader3 = command3.ExecuteReader())
                    while (reader3.Read())
                    {
                        button7.Text = (reader3["movieName"].ToString() + " " + reader3["movieTime"].ToString());
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMovies add = new AddMovies();
            add.ShowDialog();
            updateButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TheaterView1st view = new TheaterView1st();
            view.ShowDialog();
            updateButton();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TheaterView2nd view = new TheaterView2nd();
            view.ShowDialog();
            updateButton();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TheaterView3rd view = new TheaterView3rd();
            view.ShowDialog();
            updateButton();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TheaterView4th view = new TheaterView4th();
            view.ShowDialog();
            updateButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn logout = new LogIn();
            logout.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shop snacks = new Shop();
            snacks.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Profile edit = new Profile();
            edit.Show();
            this.Hide();
        }
    }
}
