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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button8.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button8.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sl = "SELECT * FROM customers WHERE CustomerName ='" + textBox1.Text + "'AND CustomerTelno ='" + textBox2.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd = new MySqlCommand(sl, con);
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                buy b = new buy();
                b.ShowDialog();
                //MessageBox.Show("dasd");
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sl = "SELECT * FROM staffs WHERE StaffID ='" + textBox3.Text + "'AND StaffPassword ='" + textBox4.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd = new MySqlCommand(sl, con);
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("dasd");
                con.Close();
            }
            else
            {
                MessageBox.Show("sssssss");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button8.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            textBox3.Clear();
            textBox4.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button8.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            regis reg = new regis();
            reg.ShowDialog();
        }
    }
}
