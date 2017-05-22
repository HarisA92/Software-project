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
    public partial class Shop : Form
    {


        public Shop()
        {

            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Coca-Cola      250ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "','" + this.textBox4.Text + "');";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Fanta      750ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "5.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "','" + this.textBox4.Text + "');";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Popcorn Small Portion" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Jamnica     500ml Non-Carb" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "1.50" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Coca-Cola     400ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CinemaShop_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Fanta      250ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Sprite      250ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Cappy      250ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Soda      250ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Coca-Cola      500ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "4.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Coca-Cola      750ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "5.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Coca-Cola      330ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Fanta      400ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Fanta      500ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "4.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Fanta      330ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Sprite      400ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Sprite      500ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "4.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Sprite      750ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "5.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Sprite      330ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Cappy      400ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Cappy      500ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "4.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Cappy      750ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "5.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";


        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Cappy      330ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Soda      400ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Soda      500ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Soda      750ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";

        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Soda      330ml" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "1.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Popcorn Medium Portion" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "3.50" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Popcorn Big Portion" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "5.00 " + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Jamnica      500ml Carbohidrated" + Environment.NewLine;
            textBox4.Text = textBox4.Text + "2.00" + Environment.NewLine;
            string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "' , '" + this.textBox4.Text + "');";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=snacks";
                string Query = "insert into drinks(ProductName, Price) values('" + this.textBox1.Text + "','" + this.textBox4.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                if (MessageBox.Show("Are you sure, or you want more to add?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                else
                {
                    return;
                }


                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();       
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                    button5.Text = ((MyReader2["Id"].ToString() + " " + (MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString())));
                    button4.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button21.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button27.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button2.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button9.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button13.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button16.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button17.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button3.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button1.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button26.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button6.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button7.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button25.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button10.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button11.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button8.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button28.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button14.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button15.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button12.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button29.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button18.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button19.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button20.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button30.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button22.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button23.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                    button24.Text = ((MyReader2["ProductName"].ToString() + " " + MyReader2["Price"].ToString()));
                }

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=snacks";
                string Query = "delete from drinks where ProductName= '" + this.textBox1.Text + "'AND Price='" + this.textBox4 + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBox1.Text = String.Empty;
                    textBox4.Text = String.Empty;
                }
                else
                {
                    return;
                }


                MessageBox.Show("Your choosen articles has been deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = String.Empty;
            textBox4.Text = String.Empty;
        }
        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;uid=root;pwd=;database=snacks";
                string Query = "SELECT SUM(Price) FROM drinks" + this.textBox2.Text + ";";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            double txt1Value, total;
            total = 0;
            double.TryParse(textBox1.Text, out txt1Value);
            total = +txt1Value;
            textBox2.Text = total.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }
    }
}
