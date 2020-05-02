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

namespace Test
{
    public partial class buy : Form
    {
        public buy(string name,string tel)
        {
            InitializeComponent();
            label8.Text = "Welcome " + name;
            label9.Text = tel + "";
            label9.Hide();
            label10.Hide();
            string sql = "SELECT * FROM customer WHERE CustomerName ='" + name + "'AND CustomerTelno = '" + tel+ "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label10.Text = "" + reader.GetString("CustomerID");
            }
            con.Close();
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox1.SelectedIndex == 3)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox1.SelectedIndex == 4)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }



        }
private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string sl = "SELECT * FROM customer WHERE CustomerID ='" + label10.Text + "'AND Credit <'" + label12.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cm = new MySqlCommand(sl, con);
            con.Open();
            MySqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("ยอดเงินไม่เพียงพอ");
            }
            else 
            {
                string sql = "SELECT * FROM sale";
                sql = "INSERT INTO sale(SaleDate,CustomerID,GrandTotal) VALUES('" + dateTimePicker1.Text + "','" + label10.Text + "','" + label12.Text + "')";
                MySqlConnection co = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
                MySqlCommand cmd = new MySqlCommand(sql, co);

                co.Open();
                cmd.ExecuteNonQuery();


                string sqll = "SELECT * FROM customer";
                sqll = "UPDATE customer SET Credit = Credit-" + label12.Text + " WHERE CustomerID =" + label10.Text + "";
                MySqlConnection coo = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
                MySqlCommand cmdd = new MySqlCommand(sqll, coo);

                coo.Open();
                cmdd.ExecuteNonQuery();



                MessageBox.Show("ซื้อสินค้าเรียบร้อย");
                co.Close();
                coo.Close();
            }
            
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text)*50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox1.SelectedIndex == 3)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox1.SelectedIndex == 4)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label3.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

        }

        private void buy_Load(object sender, EventArgs e)
        {
            

            label3.Text = (0 + "");
            label4.Text = (0 + "");
            label5.Text = (0 + "");
            label6.Text = (0 + "");
            label7.Text = (0 + "");
            label12.Text = (0 + "");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));

                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox2.SelectedIndex == 1)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox2.SelectedIndex == 2)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox2.SelectedIndex == 3)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox2.SelectedIndex == 4)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }

            else if (comboBox2.SelectedIndex == 1)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox2.SelectedIndex == 2)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox2.SelectedIndex == 3)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox2.SelectedIndex == 4)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label4.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }
            else if (comboBox3.SelectedIndex == 1)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox3.SelectedIndex == 2)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox3.SelectedIndex == 3)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox3.SelectedIndex == 4)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }
            else if (comboBox3.SelectedIndex == 1)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox3.SelectedIndex == 2)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox3.SelectedIndex == 3)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox3.SelectedIndex == 4)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label5.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }
            else if (comboBox4.SelectedIndex == 1)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox4.SelectedIndex == 2)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox4.SelectedIndex == 3)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox4.SelectedIndex == 4)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }
            else if (comboBox4.SelectedIndex == 1)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox4.SelectedIndex == 2)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox4.SelectedIndex == 3)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }


            }

            else if (comboBox4.SelectedIndex == 4)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label6.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }
            else if (comboBox5.SelectedIndex == 1)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
            }

            else if (comboBox5.SelectedIndex == 2)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
            }

            else if (comboBox5.SelectedIndex == 3)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
            }

            else if (comboBox5.SelectedIndex == 4)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 50 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }

            }
            else if (comboBox5.SelectedIndex == 1)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 65 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
            }

            else if (comboBox5.SelectedIndex == 2)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 45 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
            }

            else if (comboBox5.SelectedIndex == 3)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 40 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
            }

            else if (comboBox5.SelectedIndex == 4)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 55 + "");
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
                else
                {
                    label7.Text = "0";
                    label12.Text = ("" + (int.Parse(label3.Text) + int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text) + int.Parse(label7.Text)));
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
