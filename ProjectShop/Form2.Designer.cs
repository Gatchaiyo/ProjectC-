
namespace ProjectShop
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.adminbot = new System.Windows.Forms.Button();
            this.customerbot = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "ต้องการเลือกเมนูสำหรับ?";
            // 
            // adminbot
            // 
            this.adminbot.BackColor = System.Drawing.Color.PaleGreen;
            this.adminbot.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbot.Location = new System.Drawing.Point(199, 235);
            this.adminbot.Name = "adminbot";
            this.adminbot.Size = new System.Drawing.Size(295, 56);
            this.adminbot.TabIndex = 3;
            this.adminbot.Text = "🍅ผู้ให้บริการ(เข้าสู่หลังร้าน)🍅";
            this.adminbot.UseVisualStyleBackColor = false;
            this.adminbot.Click += new System.EventHandler(this.adminbot_Click);
            // 
            // customerbot
            // 
            this.customerbot.BackColor = System.Drawing.Color.Peru;
            this.customerbot.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbot.Location = new System.Drawing.Point(199, 338);
            this.customerbot.Name = "customerbot";
            this.customerbot.Size = new System.Drawing.Size(295, 56);
            this.customerbot.TabIndex = 4;
            this.customerbot.Text = "🛒ลูกค้า(เข้าสู่หน้าร้านค้า)🛒";
            this.customerbot.UseVisualStyleBackColor = false;
            this.customerbot.Click += new System.EventHandler(this.customerbot_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(552, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(137, 62);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Logout";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(701, 496);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.customerbot);
            this.Controls.Add(this.adminbot);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "How are you?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminbot;
        private System.Windows.Forms.Button customerbot;
        private System.Windows.Forms.Button Exit;
    }
}