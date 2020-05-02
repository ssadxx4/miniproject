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
    public partial class regis : Form
    {
        public regis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM customer";
            sql = "INSERT INTO customer(CustomerName,CustomerTelno) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            MySqlConnection con = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ลงทะเบียนเรียบร้อย");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }
    }
}
