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

namespace WindowsFormsApplication2
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            label1.Text = label1.Text + " " + LogIn.user.ToString() + "!";
            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=account"))
            {
                MySqlCommand command =
                new MySqlCommand("SELECT * FROM accounts WHERE username ='"+ LogIn.user.ToString()+ "'", connection);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())

                    while (reader.Read())
                    {
                        label7.Text = label7.Text + " " + (reader["name"].ToString());
                        label6.Text = label6.Text + " " + (reader["surname"].ToString());
                        label3.Text = label3.Text + " " + (reader["birthdate"].ToString());
                        label4.Text = label4.Text + " " + (reader["username"].ToString());
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=account"))
            {
                MySqlCommand command =
                new MySqlCommand("UPDATE accounts SET password ='" + textBox1.Text + "'" + " WHERE username = '" + LogIn.user.ToString() + "'", connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Password changed!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogIn logout = new LogIn();
            logout.Show();
            this.Hide();
        }
    }
}
