﻿
namespace ProjectShop
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.backBut = new System.Windows.Forms.Button();
            this.changeBut = new System.Windows.Forms.Button();
            this.delBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.showdataanimal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showdataanimal)).BeginInit();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(2, 594);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(133, 57);
            this.backBut.TabIndex = 21;
            this.backBut.Text = "กลับ";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // changeBut
            // 
            this.changeBut.BackColor = System.Drawing.Color.Plum;
            this.changeBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBut.Location = new System.Drawing.Point(790, 563);
            this.changeBut.Name = "changeBut";
            this.changeBut.Size = new System.Drawing.Size(174, 70);
            this.changeBut.TabIndex = 20;
            this.changeBut.Text = "แก้ไขข้อมูล";
            this.changeBut.UseVisualStyleBackColor = false;
            this.changeBut.Click += new System.EventHandler(this.changeBut_Click);
            // 
            // delBut
            // 
            this.delBut.BackColor = System.Drawing.Color.Tomato;
            this.delBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBut.Location = new System.Drawing.Point(790, 475);
            this.delBut.Name = "delBut";
            this.delBut.Size = new System.Drawing.Size(174, 70);
            this.delBut.TabIndex = 19;
            this.delBut.Text = "ลบสินค้า";
            this.delBut.UseVisualStyleBackColor = false;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.PaleGreen;
            this.addBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.Location = new System.Drawing.Point(790, 388);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(174, 70);
            this.addBut.TabIndex = 18;
            this.addBut.Text = "เพิ่มสินค้า";
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(322, 598);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(443, 43);
            this.priceBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "ราคาสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "จำนวนสินค้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(322, 490);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(443, 43);
            this.numberBox.TabIndex = 13;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(322, 388);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(443, 43);
            this.nameBox.TabIndex = 12;
            // 
            // showdataanimal
            // 
            this.showdataanimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdataanimal.Location = new System.Drawing.Point(195, 12);
            this.showdataanimal.Name = "showdataanimal";
            this.showdataanimal.RowHeadersWidth = 51;
            this.showdataanimal.RowTemplate.Height = 24;
            this.showdataanimal.Size = new System.Drawing.Size(901, 326);
            this.showdataanimal.TabIndex = 11;
            this.showdataanimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdataanimal_CellContentClick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 654);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.changeBut);
            this.Controls.Add(this.delBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.showdataanimal);
            this.Name = "Form5";
            this.Text = "แก้ไขข้อมูลสัตว์";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdataanimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button changeBut;
        private System.Windows.Forms.Button delBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DataGridView showdataanimal;
    }
}