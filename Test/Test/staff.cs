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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM customer";
            sql =  "UPDATE customer SET Credit = Credit+" +textBox2.Text+" WHERE CustomerID ="+textBox1.Text+"";
            MySqlConnection con = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("เติมเงินเรียบร้อย");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM sale";
            //sql1 = "SELECT SUM(Grandtotal) FROM sale";
            MySqlConnection con1 = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            con1.Open();

            DataSet dats = new DataSet();
            MySqlDataAdapter data = new MySqlDataAdapter(cmd1);
            data.Fill(dats);
            dataGridView1.DataSource = dats.Tables[0].DefaultView;
            con1.Close();

            int iTotal = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                iTotal = iTotal + Convert.ToInt32(row.Cells["Grandtotal"].Value);
            }
            label3.Text = "" + iTotal;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            string sql1 = "SELECT * FROM customer";
            MySqlConnection con1 = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            con1.Open();

            DataSet dats = new DataSet();
            MySqlDataAdapter data = new MySqlDataAdapter(cmd1);
            data.Fill(dats);
            dataGridView1.DataSource = dats.Tables[0].DefaultView;
            con1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
