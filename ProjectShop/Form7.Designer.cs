
namespace ProjectShop
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.backBut = new System.Windows.Forms.Button();
            this.animalBut = new System.Windows.Forms.Button();
            this.seedBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(39, 562);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(125, 57);
            this.backBut.TabIndex = 10;
            this.backBut.Text = "🔙กลับ";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // animalBut
            // 
            this.animalBut.BackColor = System.Drawing.Color.LightSalmon;
            this.animalBut.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalBut.Location = new System.Drawing.Point(404, 406);
            this.animalBut.Name = "animalBut";
            this.animalBut.Size = new System.Drawing.Size(228, 75);
            this.animalBut.TabIndex = 9;
            this.animalBut.Text = "🐣สัตว์🐣";
            this.animalBut.UseVisualStyleBackColor = false;
            this.animalBut.Click += new System.EventHandler(this.animalBut_Click);
            // 
            // seedBut
            // 
            this.seedBut.BackColor = System.Drawing.Color.PaleGreen;
            this.seedBut.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedBut.Location = new System.Drawing.Point(403, 273);
            this.seedBut.Name = "seedBut";
            this.seedBut.Size = new System.Drawing.Size(229, 75);
            this.seedBut.TabIndex = 8;
            this.seedBut.Text = "🥕เมล็ดพันธุ์🥕";
            this.seedBut.UseVisualStyleBackColor = false;
            this.seedBut.Click += new System.EventHandler(this.seedBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "กรุณาเลือกหมวดหมู่สินค้าที่ต้องการเลือกซื้อ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 670);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.animalBut);
            this.Controls.Add(this.seedBut);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "เลือกซื้อสินค้า";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button animalBut;
        private System.Windows.Forms.Button seedBut;
        private System.Windows.Forms.Label label1;
    }
}