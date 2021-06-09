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
    public partial class Form10 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showBasket()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM basket";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            databasket.DataSource = ds.Tables[0].DefaultView;


        }
        public Form10()
        {
            InitializeComponent();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            showBasket();
            price();
        }

        private void databasket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            databasket.CurrentRow.Selected = true;
            nameBox.Text = databasket.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            numberBox.Text = databasket.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            int selectedRow = databasket.CurrentCell.RowIndex;
            string Price = Convert.ToString(databasket.Rows[selectedRow].Cells["Price"].Value);
            int editId = Convert.ToInt32(databasket.Rows[selectedRow].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE basket SET Name = '" + nameBox.Text + "',Amount='" + numberBox.Text + "',Sum = '" + numberBox.Text + "' * '" + Price + "' WHERE Id = '" + editId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขสินค้าสำเร็จ");
                showBasket();
            }
            price();
        }
        

        private void price()
        {
            if (databasket.Rows.Count > 0) ///เรียกใช้
            {
                int selected = databasket.CurrentCell.RowIndex;
                int all = 0;
                for (int i = 0; i < databasket.Rows.Count; i++)
                {
                    if (databasket.Rows[i].Cells[4].Value != null && databasket.Rows[selected].Cells[4].Value.ToString() != "") 
                    {
                        all = all + Convert.ToInt32(databasket.Rows[i].Cells[4].Value.ToString());

                    }

                }
                priceBox.Text = Convert.ToString(all);
            }
        }
        private void delBut_Click(object sender, EventArgs e)
        {
            int selectedRow = databasket.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(databasket.Rows[selectedRow].Cells["Id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM basket WHERE Id = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
                showBasket();
            }
            price();
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

        private void complsBut_Click(object sender, EventArgs e)
        {
            Form11 otherForm = new Form11();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
    }
}
