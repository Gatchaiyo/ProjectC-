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
    public partial class Form12 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form12()
        {
            InitializeComponent();
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void conpasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1 && phoneBox.Text.Length > 9)
            {
                e.Handled = true;
            }
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void regisBut_Click(object sender, EventArgs e)
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user  WHERE Username='" + usernameBox.Text + "'", conn);

            MySqlDataReader dr = cmd.ExecuteReader(); /// สั่่งใช้งานcmd บรรทัดที่ 26 .

            if (usernameBox.Text.Trim().Equals("") || passwordBox.Text.Trim().Equals("") || conpasswordBox.Text.Trim().Equals("") || phoneBox.Text.Trim().Equals("") )
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ"); /// Trim() คือ ลบช่องว่างหน้า-หลัง string  Equals("") คือ == "" ชุดคำสั่งสำเร็จรูป
            }
            if (conpasswordBox.Text != passwordBox.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน กรุณากรอกให้ถูกต้อง");
            }
            else
            {
                if (!dr.Read()) ///ถ้าไมเจอ username ใน database ให้สมัครได้ ถ้า dr.Read อ่านไม่ได้ เเสดงว่าไม่มีค่าที่ตรวจใน คำสั่งcmd บรรทัดที่ 26
                {
                    int a;
                    if (int.TryParse(phoneBox.Text, out a) && phoneBox.Text.Length > 9)
                    {
                        conn.Close();
                        conn.Open();
                        MySqlCommand cmd1 = new MySqlCommand("INSERT INTO `user`(`Username`, `Password`, `Phone`) " +"VALUES('" + usernameBox.Text + "','" + passwordBox.Text + "','" + phoneBox.Text + "')", conn);

                        cmd1.ExecuteNonQuery();     ///  ทำคำสั่งเcmd1 แล้วดูว่าสำเร็จหรือไม่สำเร็จ              
                        this.Close();
                        MessageBox.Show("การลงทะเบียนสำเร็จ ");
                        conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("เบอร์โทรศัพท์ไม่ถูกต้อง");


                    }
                }
                else  ///ชื่อผู้ใช้ถู
                {
                    MessageBox.Show("ชื่อผู้ใช้ถูกใช้เเล้ว กรูณาใช้ชื่ออื่น");
                }
            }
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            Login otherForm = new Login();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            conpasswordBox.PasswordChar = checkBox1.Checked ? '\0' : '*';
            
        }
    }
}
