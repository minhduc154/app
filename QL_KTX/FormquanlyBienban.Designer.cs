namespace QL_KTX
{
    partial class FormquanlyBienban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormquanlyBienban));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMabb = new System.Windows.Forms.TextBox();
            this.comboBoxMasv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTensv = new System.Windows.Forms.TextBox();
            this.textBoxNoidung = new System.Windows.Forms.TextBox();
            this.textBoxGhichu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonLammoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Biên Bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi Chú";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội Dung\r\nBiên Bản\r\n\r\n";
            // 
            // textBoxMabb
            // 
            this.textBoxMabb.Location = new System.Drawing.Point(94, 21);
            this.textBoxMabb.Name = "textBoxMabb";
            this.textBoxMabb.Size = new System.Drawing.Size(156, 20);
            this.textBoxMabb.TabIndex = 4;
            // 
            // comboBoxMasv
            // 
            this.comboBoxMasv.FormattingEnabled = true;
            this.comboBoxMasv.Location = new System.Drawing.Point(94, 57);
            this.comboBoxMasv.Name = "comboBoxMasv";
            this.comboBoxMasv.Size = new System.Drawing.Size(156, 21);
            this.comboBoxMasv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên SV";
            // 
            // textBoxTensv
            // 
            this.textBoxTensv.Enabled = false;
            this.textBoxTensv.Location = new System.Drawing.Point(94, 90);
            this.textBoxTensv.Name = "textBoxTensv";
            this.textBoxTensv.Size = new System.Drawing.Size(156, 20);
            this.textBoxTensv.TabIndex = 7;
            // 
            // textBoxNoidung
            // 
            this.textBoxNoidung.Location = new System.Drawing.Point(344, 24);
            this.textBoxNoidung.Multiline = true;
            this.textBoxNoidung.Name = "textBoxNoidung";
            this.textBoxNoidung.Size = new System.Drawing.Size(219, 97);
            this.textBoxNoidung.TabIndex = 8;
            // 
            // textBoxGhichu
            // 
            this.textBoxGhichu.Location = new System.Drawing.Point(94, 156);
            this.textBoxGhichu.Name = "textBoxGhichu";
            this.textBoxGhichu.Size = new System.Drawing.Size(156, 20);
            this.textBoxGhichu.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonIn
            // 
            this.buttonIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonIn.Image = ((System.Drawing.Image)(resources.GetObject("buttonIn.Image")));
            this.buttonIn.Location = new System.Drawing.Point(488, 138);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(75, 48);
            this.buttonIn.TabIndex = 16;
            this.buttonIn.Text = "In Biên Bản";
            this.buttonIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIn.UseVisualStyleBackColor = false;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHuy.Enabled = false;
            this.buttonHuy.Image = ((System.Drawing.Image)(resources.GetObject("buttonHuy.Image")));
            this.buttonHuy.Location = new System.Drawing.Point(449, 407);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 51);
            this.buttonHuy.TabIndex = 17;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonTim.Image = ((System.Drawing.Image)(resources.GetObject("buttonTim.Image")));
            this.buttonTim.Location = new System.Drawing.Point(51, 350);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 51);
            this.buttonTim.TabIndex = 15;
            this.buttonTim.Text = "Tìm Kiếm";
            this.buttonTim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSua.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.Image")));
            this.buttonSua.Location = new System.Drawing.Point(255, 407);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 51);
            this.buttonSua.TabIndex = 13;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonThem.Enabled = false;
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.Location = new System.Drawing.Point(255, 350);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 51);
            this.buttonThem.TabIndex = 12;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLammoi
            // 
            this.buttonLammoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLammoi.Image = ((System.Drawing.Image)(resources.GetObject("buttonLammoi.Image")));
            this.buttonLammoi.Location = new System.Drawing.Point(51, 407);
            this.buttonLammoi.Name = "buttonLammoi";
            this.buttonLammoi.Size = new System.Drawing.Size(75, 51);
            this.buttonLammoi.TabIndex = 11;
            this.buttonLammoi.Text = "Làm Mới";
            this.buttonLammoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLammoi.UseVisualStyleBackColor = false;
            this.buttonLammoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.Location = new System.Drawing.Point(449, 350);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 51);
            this.buttonXoa.TabIndex = 14;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngày Lập";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormquanlyBienban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(575, 462);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonLammoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxGhichu);
            this.Controls.Add(this.textBoxNoidung);
            this.Controls.Add(this.textBoxTensv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMasv);
            this.Controls.Add(this.textBoxMabb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormquanlyBienban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Biên Bản";
            this.Load += new System.EventHandler(this.FormquanlyBienban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMabb;
        private System.Windows.Forms.ComboBox comboBoxMasv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTensv;
        private System.Windows.Forms.TextBox textBoxNoidung;
        private System.Windows.Forms.TextBox textBoxGhichu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonLammoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}