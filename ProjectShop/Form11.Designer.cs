﻿
namespace ProjectShop
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.databasket = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addmoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totolbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customBux = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.calcuBut = new System.Windows.Forms.Button();
            this.backBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databasket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "ใบเสร็จรับเงิน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "ชื่อลูกค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "ราการสินค้าทั้งหมด";
            // 
            // databasket
            // 
            this.databasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databasket.Location = new System.Drawing.Point(265, 136);
            this.databasket.Name = "databasket";
            this.databasket.ReadOnly = true;
            this.databasket.RowHeadersWidth = 51;
            this.databasket.RowTemplate.Height = 50;
            this.databasket.Size = new System.Drawing.Size(637, 346);
            this.databasket.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(908, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 32);
            this.label6.TabIndex = 54;
            this.label6.Text = "บาท";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.priceBox.Location = new System.Drawing.Point(679, 563);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(223, 38);
            this.priceBox.TabIndex = 53;
            this.priceBox.Text = "0.00";
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 32);
            this.label7.TabIndex = 52;
            this.label7.Text = "ราคารวม";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(908, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 32);
            this.label5.TabIndex = 57;
            this.label5.Text = "บาท";
            // 
            // addmoney
            // 
            this.addmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.addmoney.Location = new System.Drawing.Point(679, 619);
            this.addmoney.Name = "addmoney";
            this.addmoney.Size = new System.Drawing.Size(223, 38);
            this.addmoney.TabIndex = 56;
            this.addmoney.Text = "0.00";
            this.addmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(512, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 32);
            this.label8.TabIndex = 55;
            this.label8.Text = "จำนวนเงินที่รับมา";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(908, 684);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 32);
            this.label9.TabIndex = 60;
            this.label9.Text = "บาท";
            // 
            // totolbox
            // 
            this.totolbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.totolbox.Location = new System.Drawing.Point(679, 678);
            this.totolbox.Name = "totolbox";
            this.totolbox.ReadOnly = true;
            this.totolbox.Size = new System.Drawing.Size(223, 38);
            this.totolbox.TabIndex = 59;
            this.totolbox.Text = "0.00";
            this.totolbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(587, 684);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 32);
            this.label10.TabIndex = 58;
            this.label10.Text = "เงินทอน";
            // 
            // customBux
            // 
            this.customBux.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBux.Location = new System.Drawing.Point(134, 604);
            this.customBux.Name = "customBux";
            this.customBux.Size = new System.Drawing.Size(283, 39);
            this.customBux.TabIndex = 63;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // calcuBut
            // 
            this.calcuBut.BackColor = System.Drawing.Color.Salmon;
            this.calcuBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcuBut.Location = new System.Drawing.Point(189, 669);
            this.calcuBut.Name = "calcuBut";
            this.calcuBut.Size = new System.Drawing.Size(150, 60);
            this.calcuBut.TabIndex = 65;
            this.calcuBut.Text = "คิดเงิน💸💸";
            this.calcuBut.UseVisualStyleBackColor = false;
            this.calcuBut.Click += new System.EventHandler(this.calcuBut_Click);
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(12, 14);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(156, 57);
            this.backBut.TabIndex = 66;
            this.backBut.Text = "🔙กลับ";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 760);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.calcuBut);
            this.Controls.Add(this.customBux);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totolbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addmoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.databasket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "ใบเสร็จ";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView databasket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addmoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totolbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox customBux;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button calcuBut;
        private System.Windows.Forms.Button backBut;
    }
}