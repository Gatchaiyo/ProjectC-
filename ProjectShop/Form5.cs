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
namespace ProjectShop
{
    public partial class Form5 : Form
    {
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
            cmd.CommandText = "SELECT Id ,Name ,Amount,Price FROM stanimal";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            showdataanimal.DataSource = ds.Tables[0].DefaultView;

        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showStorck();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO stanimal (Name,Amount,Price) VALUES('" + nameBox.Text + "','" + numberBox.Text + "','" + priceBox.Text + "' )";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
            }
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            int selectedRow = showdataanimal.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(showdataanimal.Rows[selectedRow].Cells["Id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM stanimal WHERE Id = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
                showStorck();
            }
        }

        private void showdataanimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdataanimal.CurrentRow.Selected = true;
            nameBox.Text = showdataanimal.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            numberBox.Text = showdataanimal.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
            priceBox.Text = showdataanimal.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
        }

        private void changeBut_Click(object sender, EventArgs e)
        {
            int selectedRow = showdataanimal.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(showdataanimal.Rows[selectedRow].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE stanimal SET Name = '" + nameBox.Text + "',Amount='" + numberBox.Text + "',Price='" + priceBox.Text + "' WHERE Id = '" + editId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                showStorck();
            }
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            Form3 otherForm = new Form3();
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
