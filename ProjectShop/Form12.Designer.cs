
namespace ProjectShop
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.conpasswordBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.backBut = new System.Windows.Forms.Button();
            this.regisBut = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(216, 238);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(241, 39);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameBox_KeyPress);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(216, 306);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(241, 39);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordBox_KeyPress);
            // 
            // conpasswordBox
            // 
            this.conpasswordBox.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpasswordBox.Location = new System.Drawing.Point(216, 380);
            this.conpasswordBox.Name = "conpasswordBox";
            this.conpasswordBox.PasswordChar = '*';
            this.conpasswordBox.Size = new System.Drawing.Size(241, 39);
            this.conpasswordBox.TabIndex = 2;
            this.conpasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.conpasswordBox_KeyPress);
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(216, 450);
            this.phoneBox.MaxLength = 10;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(241, 39);
            this.phoneBox.TabIndex = 3;
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(124, 517);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(123, 55);
            this.backBut.TabIndex = 4;
            this.backBut.Text = "ย้อนกลับ🐾🐾";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // regisBut
            // 
            this.regisBut.BackColor = System.Drawing.Color.Coral;
            this.regisBut.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regisBut.ForeColor = System.Drawing.Color.Black;
            this.regisBut.Location = new System.Drawing.Point(274, 517);
            this.regisBut.Name = "regisBut";
            this.regisBut.Size = new System.Drawing.Size(134, 55);
            this.regisBut.TabIndex = 5;
            this.regisBut.Text = "🥦สมัครสมาชิก🥦";
            this.regisBut.UseVisualStyleBackColor = false;
            this.regisBut.Click += new System.EventHandler(this.regisBut_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(463, 402);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 670);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.regisBut);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.conpasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "Form12";
            this.Text = "ลงชื่อเข้าใช้";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox conpasswordBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button regisBut;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}