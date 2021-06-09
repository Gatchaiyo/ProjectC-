
namespace ProjectShop
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.datashowstorck = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.addBut = new System.Windows.Forms.Button();
            this.delBut = new System.Windows.Forms.Button();
            this.changeBut = new System.Windows.Forms.Button();
            this.backBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datashowstorck)).BeginInit();
            this.SuspendLayout();
            // 
            // datashowstorck
            // 
            this.datashowstorck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashowstorck.Location = new System.Drawing.Point(173, 26);
            this.datashowstorck.Name = "datashowstorck";
            this.datashowstorck.RowHeadersWidth = 51;
            this.datashowstorck.RowTemplate.Height = 24;
            this.datashowstorck.Size = new System.Drawing.Size(901, 326);
            this.datashowstorck.TabIndex = 0;
            this.datashowstorck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datashowstorck_CellContentClick);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(289, 392);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(443, 43);
            this.nameBox.TabIndex = 1;
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(289, 494);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(443, 43);
            this.numberBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "จำนวนสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "ราคาสินค้า";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(289, 602);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(443, 43);
            this.priceBox.TabIndex = 6;
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.PaleGreen;
            this.addBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.Location = new System.Drawing.Point(765, 392);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(174, 70);
            this.addBut.TabIndex = 7;
            this.addBut.Text = "เพิ่มสินค้า";
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // delBut
            // 
            this.delBut.BackColor = System.Drawing.Color.Tomato;
            this.delBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBut.Location = new System.Drawing.Point(765, 479);
            this.delBut.Name = "delBut";
            this.delBut.Size = new System.Drawing.Size(174, 70);
            this.delBut.TabIndex = 8;
            this.delBut.Text = "ลบสินค้า";
            this.delBut.UseVisualStyleBackColor = false;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // changeBut
            // 
            this.changeBut.BackColor = System.Drawing.Color.Plum;
            this.changeBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBut.Location = new System.Drawing.Point(765, 567);
            this.changeBut.Name = "changeBut";
            this.changeBut.Size = new System.Drawing.Size(174, 70);
            this.changeBut.TabIndex = 9;
            this.changeBut.Text = "แก้ไขข้อมูล";
            this.changeBut.UseVisualStyleBackColor = false;
            this.changeBut.Click += new System.EventHandler(this.changeBut_Click);
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(12, 585);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(133, 57);
            this.backBut.TabIndex = 10;
            this.backBut.Text = "กลับ";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.Controls.Add(this.datashowstorck);
            this.Name = "Form4";
            this.Text = "แก้ไชข้อมูลเมล็ดพันธุ์";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datashowstorck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datashowstorck;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button delBut;
        private System.Windows.Forms.Button changeBut;
        private System.Windows.Forms.Button backBut;
    }
}