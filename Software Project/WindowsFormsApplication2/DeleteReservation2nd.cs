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
//Haris Aljovic part
namespace WindowsFormsApplication2
{
    public partial class DeleteReservation2nd : Form
    {
        public DeleteReservation2nd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                MessageBox.Show("Please enter firstname!");
                return;
            }
            if (textBox2.Text == " ")
            {
                MessageBox.Show("Please enter lastname!");
                return;
            }
            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=reservation";
                string Query = "DELETE FROM reservation2 where firstName='" + this.textBox1.Text + "' AND lastName='" + this.textBox2.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Reservation deleted!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteReservation2nd_Load(object sender, EventArgs e)
        {

        }
    }
}
