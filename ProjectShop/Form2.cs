using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void adminbot_Click(object sender, EventArgs e)
        {
            string x = useradmin;
            if (x=="admin")
            {
                Form3 otherForm = new Form3();
                otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                this.Hide();
                otherForm.Show();
            }
            else
            {
                MessageBox.Show("เมนูนี้สำหรับ Admin เท่านั้น");
            }
            
        }

        private void customerbot_Click(object sender, EventArgs e)
        {
            Form6 otherForm = new Form6();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
        public string useradmin;
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Login otherForm = new Login();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
    }
  }

