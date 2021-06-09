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
    public partial class Form9 : Form
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
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stanimal";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            showdataanimal.DataSource = ds.Tables[0].DefaultView;

        }
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            showStorck();
       
        }

        private void showdataanimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            showdataanimal.CurrentRow.Selected = true;
            nameBox.Text = showdataanimal.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            priceBox.Text = showdataanimal.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();

            showdataanimal.CurrentRow.Selected = true;
            int selectedRow = showdataanimal.CurrentCell.RowIndex;
            string name = Convert.ToString(showdataanimal.Rows[selectedRow].Cells["Name"].Value); ///สร้างตัวแปร

            MySqlConnection con = databaseConnection();
            MySqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT Image FROM  stanimal  WHERE Name = '" + name + "'  ";
            showdataanimal.CurrentRow.Selected = true;
           
            Amount = Convert.ToInt32(showdataanimal.Rows[selectedRow].Cells["Amount"].Value);
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
            showdataanimal.CurrentRow.Selected = true;
            int selectedRow = showdataanimal.CurrentCell.RowIndex;
            string Price = Convert.ToString(showdataanimal.Rows[selectedRow].Cells["Price"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO basket SET Name = '" + nameBox.Text + "' ,Amount = '" + numberBox.Text + "',Price = '" + priceBox.Text + "',Sum = '" + numberBox.Text + "' * '" + Price + "'";
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
            string sql = "UPDATE stanimal SET Amount = '" + Amount + "' WHERE Name = '" + nameBox.Text + "'";
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
