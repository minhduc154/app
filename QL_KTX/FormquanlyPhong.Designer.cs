namespace QL_KTX
{
    partial class FormquanlyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormquanlyPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaphong = new System.Windows.Forms.TextBox();
            this.textBoxLoaiphong = new System.Windows.Forms.TextBox();
            this.textBoxChotrong = new System.Windows.Forms.TextBox();
            this.textBoxTien = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.buttonLammoi = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTinhtrang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chỗ Trống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiền Phòng";
            // 
            // textBoxMaphong
            // 
            this.textBoxMaphong.Location = new System.Drawing.Point(128, 12);
            this.textBoxMaphong.Name = "textBoxMaphong";
            this.textBoxMaphong.Size = new System.Drawing.Size(139, 20);
            this.textBoxMaphong.TabIndex = 4;
            // 
            // textBoxLoaiphong
            // 
            this.textBoxLoaiphong.Location = new System.Drawing.Point(128, 54);
            this.textBoxLoaiphong.Name = "textBoxLoaiphong";
            this.textBoxLoaiphong.Size = new System.Drawing.Size(139, 20);
            this.textBoxLoaiphong.TabIndex = 5;
            // 
            // textBoxChotrong
            // 
            this.textBoxChotrong.Enabled = false;
            this.textBoxChotrong.Location = new System.Drawing.Point(399, 12);
            this.textBoxChotrong.Name = "textBoxChotrong";
            this.textBoxChotrong.Size = new System.Drawing.Size(145, 20);
            this.textBoxChotrong.TabIndex = 6;
            // 
            // textBoxTien
            // 
            this.textBoxTien.Location = new System.Drawing.Point(399, 53);
            this.textBoxTien.Name = "textBoxTien";
            this.textBoxTien.Size = new System.Drawing.Size(145, 20);
            this.textBoxTien.TabIndex = 7;
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonTim.Image = ((System.Drawing.Image)(resources.GetObject("buttonTim.Image")));
            this.buttonTim.Location = new System.Drawing.Point(53, 330);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 51);
            this.buttonTim.TabIndex = 8;
            this.buttonTim.Text = "Tìm Kiếm";
            this.buttonTim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // buttonLammoi
            // 
            this.buttonLammoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLammoi.Image = ((System.Drawing.Image)(resources.GetObject("buttonLammoi.Image")));
            this.buttonLammoi.Location = new System.Drawing.Point(53, 390);
            this.buttonLammoi.Name = "buttonLammoi";
            this.buttonLammoi.Size = new System.Drawing.Size(75, 51);
            this.buttonLammoi.TabIndex = 9;
            this.buttonLammoi.Text = "Làm Mới";
            this.buttonLammoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLammoi.UseVisualStyleBackColor = false;
            this.buttonLammoi.Click += new System.EventHandler(this.buttonLammoi_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonThem.Enabled = false;
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.Location = new System.Drawing.Point(260, 330);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 51);
            this.buttonThem.TabIndex = 10;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSua.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.Image")));
            this.buttonSua.Location = new System.Drawing.Point(260, 390);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 51);
            this.buttonSua.TabIndex = 11;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.Location = new System.Drawing.Point(449, 330);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 51);
            this.buttonXoa.TabIndex = 12;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 184);
            this.dataGridView1.TabIndex = 13;
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHuy.Enabled = false;
            this.buttonHuy.Image = ((System.Drawing.Image)(resources.GetObject("buttonHuy.Image")));
            this.buttonHuy.Location = new System.Drawing.Point(449, 387);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 51);
            this.buttonHuy.TabIndex = 14;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tình Trạng";
            // 
            // textBoxTinhtrang
            // 
            this.textBoxTinhtrang.Location = new System.Drawing.Point(128, 94);
            this.textBoxTinhtrang.Name = "textBoxTinhtrang";
            this.textBoxTinhtrang.Size = new System.Drawing.Size(139, 20);
            this.textBoxTinhtrang.TabIndex = 16;
            // 
            // FormquanlyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(597, 451);
            this.Controls.Add(this.textBoxTinhtrang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonLammoi);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBoxTien);
            this.Controls.Add(this.textBoxChotrong);
            this.Controls.Add(this.textBoxLoaiphong);
            this.Controls.Add(this.textBoxMaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormquanlyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.FormquanlyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaphong;
        private System.Windows.Forms.TextBox textBoxLoaiphong;
        private System.Windows.Forms.TextBox textBoxChotrong;
        private System.Windows.Forms.TextBox textBoxTien;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button buttonLammoi;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTinhtrang;
    }
}