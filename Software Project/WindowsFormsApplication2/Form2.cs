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
//Adnan Lucevic part
namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=account";
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();

                string querry = "INSERT INTO accounts (username, password, name, surname, birthdate) VALUES ('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                MySqlCommand comm = new MySqlCommand(querry, connect);
                int test = comm.ExecuteNonQuery();
                if (test == 1)
                {
                    MessageBox.Show ("ACCOUNT CREATED SUCCESSFULLY!");
                    LogIn login = new LogIn();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show ("REGISTRATION FAILED! TRY AGAIN!");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn home = new LogIn();
            home.Show();
            this.Hide();
        }
    }
}
