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
using System.IO;
namespace ProjectShop
{
    public partial class Form8 : Form
    {
        int Amount;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showStorck()
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id ,Name ,Amount,Price,Image FROM stseed";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                conn.Close();

                showdataseed.DataSource = ds.Tables[0].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            showStorck();
            
        }

        private void showdataseed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdataseed.CurrentRow.Selected = true;
            nameBox.Text = showdataseed.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            priceBox.Text = showdataseed.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();

            showdataseed.CurrentRow.Selected = true;
            int selectedRow = showdataseed.CurrentCell.RowIndex;
            string name = Convert.ToString(showdataseed.Rows[selectedRow].Cells["Name"].Value); ///สร้างตัวแปร

            MySqlConnection con = databaseConnection();
            MySqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT Image FROM stseed WHERE Name = '" + name + "'  ";
            showdataseed.CurrentRow.Selected = true;

            Amount = Convert.ToInt32(showdataseed.Rows[selectedRow].Cells["Amount"].Value);
            numberBox.Text = Amount.ToString();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pictureBox1.Image = new Bitmap(ms);
            }

        }

        private void addBut_Click(object sender, EventArgs e)
        {
            showdataseed.CurrentRow.Selected = true;
            int selectedRow = showdataseed.CurrentCell.RowIndex;
            string Price = Convert.ToString(showdataseed.Rows[selectedRow].Cells["Price"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO basket SET Name = '"+nameBox.Text+ "' ,Amount = '"+ numberBox.Text+"',Price = '"+priceBox.Text+ "',Sum = '" + numberBox.Text + "' * '"  + Price +  "'" ;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("เพิ่มสินค้าลงในตะกร้าสำเร็จ");
                showStorck();
                delstork();
            }
        }
        private void delstork()
        {
            Amount -= Convert.ToInt32(numberBox.Text);
            MySqlConnection conn = databaseConnection();
            string sql = "UPDATE stseed SET Amount = '" + Amount + "' WHERE Name = '" + nameBox.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            showStorck();
        }
        private void backBut_Click(object sender, EventArgs e)
        {
            Form6 otherForm = new Form6();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void showdataseed_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
