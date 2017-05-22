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
    public partial class LogIn : Form
    {
        public static string user;
        public LogIn()
        {
           
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            string connectionString = "server=localhost;uid=root;pwd=;database=account";
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();

                string querry = "SELECT * FROM accounts WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                MySqlCommand comm = new MySqlCommand(querry, connect);
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("SUCCESSFULLY LOGED IN!");
                    Profile home = new Profile();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("INCORRECT USERNAME OR PASSWORD!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
