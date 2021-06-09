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
    public partial class Form13 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void Showhistory()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM history";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            showhistory.DataSource = ds.Tables[0].DefaultView;

        }
        public Form13()
        {
            InitializeComponent();
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

        private void Form13_Load(object sender, EventArgs e)
        {
            Showhistory();
        }
    }
    
}
