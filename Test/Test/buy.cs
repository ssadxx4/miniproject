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
        public buy()
        {
            InitializeComponent();
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
                    label3.Text = (int.Parse(textBox1.Text) * 10 + "");
                    label8.Text = (int.Parse(textBox1.Text) * 10 + "");
                }
                else
                {
                    label3.Text = "0";
                }

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 100 + "");
                }
                else
                {
                    label3.Text = "0";
                }

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 300 + "");
                }
                else
                {
                    label3.Text = "0";
                }

            }

            else if (comboBox1.SelectedIndex == 3)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 150 + "");
                }
                else
                {
                    label3.Text = "0";
                }

            }

            else if (comboBox1.SelectedIndex == 4)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 50 + "");
                }
                else
                {
                    label3.Text = "0";
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
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text)*10 + "");
                }
                else
                {
                    label3.Text = "0";
                }
                
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 100 + "");
                }
                else
                {
                    label3.Text = "0";
                }

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 300 + "");
                }
                else
                {
                    label3.Text = "0";
                }

            }

            else if (comboBox1.SelectedIndex == 3)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 150 + "");
                }
                else
                {
                    label3.Text = "0";
                }

            }

            else if (comboBox1.SelectedIndex == 4)
            {
                if (textBox1.Text.Length != 0)
                {
                    label3.Text = (int.Parse(textBox1.Text) * 50 + "");
                }
                else
                {
                    label3.Text = "0";
                }

            }

        }

        private void buy_Load(object sender, EventArgs e)
        {
            label4.Text = "...";
            label5.Text = "...";
            label6.Text = "...";
            label7.Text = "...";
            label3.Text = "...";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 10 + "");
                    
                }
                else
                {
                    label4.Text = "0";
                }

            }

            else if (comboBox2.SelectedIndex == 1)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 100 + "");
                }
                else
                {
                    label4.Text = "0";
                }


            }

            else if (comboBox2.SelectedIndex == 2)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 300 + "");
                }
                else
                {
                    label4.Text = "0";
                }


            }

            else if (comboBox2.SelectedIndex == 3)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 150 + "");
                }
                else
                {
                    label4.Text = "0";
                }


            }

            else if (comboBox2.SelectedIndex == 4)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 50 + "");
                }
                else
                {
                    label4.Text = "0";
                }


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 10 + "");
                }
                else
                {
                    label4.Text = "0";
                }

            }

            else if (comboBox2.SelectedIndex == 1)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 100 + "");
                }
                else
                {
                    label4.Text = "0";
                }


            }

            else if (comboBox2.SelectedIndex == 2)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 300 + "");
                }
                else
                {
                    label4.Text = "0";
                }


            }

            else if (comboBox2.SelectedIndex == 3)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 150 + "");
                }
                else
                {
                    label4.Text = "0";
                }


            }

            else if (comboBox2.SelectedIndex == 4)
            {
                if (textBox2.Text.Length != 0)
                {
                    label4.Text = (int.Parse(textBox2.Text) * 50 + "");
                }
                else
                {
                    label4.Text = "0";
                }


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 10 + "");
                }
                else
                {
                    label5.Text = "0";
                }

            }
            else if (comboBox3.SelectedIndex == 1)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 100 + "");
                }
                else
                {
                    label5.Text = "0";
                }


            }

            else if (comboBox3.SelectedIndex == 2)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 300 + "");
                }
                else
                {
                    label5.Text = "0";
                }


            }

            else if (comboBox3.SelectedIndex == 3)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 150 + "");
                }
                else
                {
                    label5.Text = "0";
                }


            }

            else if (comboBox3.SelectedIndex == 4)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 50 + "");
                }
                else
                {
                    label5.Text = "0";
                }


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 10 + "");
                }
                else
                {
                    label5.Text = "0";
                }

            }
            else if (comboBox3.SelectedIndex == 1)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 100 + "");
                }
                else
                {
                    label5.Text = "0";
                }


            }

            else if (comboBox3.SelectedIndex == 2)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 300 + "");
                }
                else
                {
                    label5.Text = "0";
                }


            }

            else if (comboBox3.SelectedIndex == 3)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 150 + "");
                }
                else
                {
                    label5.Text = "0";
                }


            }

            else if (comboBox3.SelectedIndex == 4)
            {
                if (textBox3.Text.Length != 0)
                {
                    label5.Text = (int.Parse(textBox3.Text) * 50 + "");
                }
                else
                {
                    label5.Text = "0";
                }


            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 10 + "");
                }
                else
                {
                    label6.Text = "0";
                }

            }
            else if (comboBox4.SelectedIndex == 1)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 100 + "");
                }
                else
                {
                    label6.Text = "0";
                }


            }

            else if (comboBox4.SelectedIndex == 2)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 300 + "");
                }
                else
                {
                    label6.Text = "0";
                }


            }

            else if (comboBox4.SelectedIndex == 3)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 150 + "");
                }
                else
                {
                    label6.Text = "0";
                }


            }

            else if (comboBox4.SelectedIndex == 4)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 50 + "");
                }
                else
                {
                    label6.Text = "0";
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 10 + "");
                }
                else
                {
                    label6.Text = "0";
                }

            }
            else if (comboBox4.SelectedIndex == 1)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 100 + "");
                }
                else
                {
                    label6.Text = "0";
                }


            }

            else if (comboBox4.SelectedIndex == 2)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 300 + "");
                }
                else
                {
                    label6.Text = "0";
                }


            }

            else if (comboBox4.SelectedIndex == 3)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 150 + "");
                }
                else
                {
                    label6.Text = "0";
                }


            }

            else if (comboBox4.SelectedIndex == 4)
            {
                if (textBox4.Text.Length != 0)
                {
                    label6.Text = (int.Parse(textBox4.Text) * 50 + "");
                }
                else
                {
                    label6.Text = "0";
                }

            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 10 + "");
                }
                else
                {
                    label7.Text = "0";
                }

            }
            else if (comboBox5.SelectedIndex == 1)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 100 + "");
                }
                else
                {
                    label7.Text = "0";
                }
            }

            else if (comboBox5.SelectedIndex == 2)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 300 + "");
                }
                else
                {
                    label7.Text = "0";
                }
            }

            else if (comboBox5.SelectedIndex == 3)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 150 + "");
                }
                else
                {
                    label7.Text = "0";
                }
            }

            else if (comboBox5.SelectedIndex == 4)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 50 + "");
                }
                else
                {
                    label7.Text = "0";
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 10 + "");
                }
                else
                {
                    label7.Text = "0";
                }

            }
            else if (comboBox5.SelectedIndex == 1)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 100 + "");
                }
                else
                {
                    label7.Text = "0";
                }
            }

            else if (comboBox5.SelectedIndex == 2)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 300 + "");
                }
                else
                {
                    label7.Text = "0";
                }
            }

            else if (comboBox5.SelectedIndex == 3)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 150 + "");
                }
                else
                {
                    label7.Text = "0";
                }
            }

            else if (comboBox5.SelectedIndex == 4)
            {
                if (textBox5.Text.Length != 0)
                {
                    label7.Text = (int.Parse(textBox5.Text) * 50 + "");
                }
                else
                {
                    label7.Text = "0";
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
          
        }
    }
}
