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
            /*string sql = "SELECT * FROM products INNER JOIN sale_details ON products.ProductID = sale_details.ProductID";
            string sql = "SELECT sale_details.SaleDetailID,products.ProductID,products.ProductName,sale_details.Quantity,products.Pricele_details.Amount FROM products INNER JOIN sale_details ON products.ProductID = sale_details.ProductID";
            MySqlConnection con = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet dats = new DataSet();
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            data.Fill(dats);
            dataGridView1.DataSource = dats.Tables[0].DefaultView;
            
            con.Close();
            */

            string sql = "SELECT * FROM customer";
            sql =  "UPDATE customer SET Credit = Credit+" +textBox2.Text+" WHERE CustomerID ="+textBox1.Text+"";
            MySqlConnection con = new MySqlConnection("host=localhost;user=termproject;password=12345678;database=termproject");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("เติมเงินเรียบร้อย");
            con.Close();
        }
    }
}
