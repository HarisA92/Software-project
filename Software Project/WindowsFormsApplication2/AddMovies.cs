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
    public partial class AddMovies : Form
    {
        public AddMovies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == " ")
            {
                MessageBox.Show("Please enter the movie!");
                return;
            }
            if (textBox2.Text == " ")
            {
                MessageBox.Show("Please enter time of the movie");
                return;
            }

            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=movies";
                string Query = "INSERT into movie1(movieName,movieTime,theater) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.groupBox1.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();       

                MessageBox.Show("Movie saved!");

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

        private void button4_Click(object sender, EventArgs e)
        {


            if (textBox6.Text == " ")
            {
                MessageBox.Show("Please enter the movie!");
                return;
            }
            if (textBox5.Text == " ")
            {
                MessageBox.Show("Please enter time of the movie");
                return;
            }
            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=movies";
                string Query = "INSERT into movie2(movieName,movieTime,theater) values('" + this.textBox6.Text + "','" + this.textBox5.Text + "','" + groupBox2.Text + "'); ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();       
                MessageBox.Show("Movie saved!");
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

        private void button6_Click(object sender, EventArgs e)
        {


            if (textBox9.Text == " ")
            {
                MessageBox.Show("Please enter the movie!");
                return;
            }
            if (textBox8.Text == " ")
            {
                MessageBox.Show("Please enter time of the movie");
                return;
            }
            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=movies";
                string Query = "INSERT into movie3(movieName,movieTime, theater) values('" + this.textBox9.Text + "','" + this.textBox8.Text + "','" + this.groupBox3.Text + "'); ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();      
                MessageBox.Show("Movie saved!");
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

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox12.Text == " ")
            {
                MessageBox.Show("Please enter the movie!");
                return;
            }
            if (textBox2.Text == " ")
            {
                MessageBox.Show("Please enter time of the movie");
                return;
            }

            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=movies";
                string Query = "INSERT into movie4(movieName,movieTime, theater) values('" + this.textBox12.Text + "','" + this.textBox11.Text + "','" + this.groupBox4.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();       
                MessageBox.Show("Movie saved!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
