using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_KTX
{
    public partial class FormquanlyUser : Form
    {
        public FormquanlyUser()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");

        private void laydulieu()
        {
            ketnoi.Open();
            string sql = "SELECT DANGNHAP.TAIKHOAN, DANGNHAP.MATKHAU, DANGNHAP.MANHANVIEN,NHANVIEN.TENNHANVIEN, DANGNHAP.GHICHU FROM NHANVIEN INNER JOIN DANGNHAP ON NHANVIEN.MANHANVIEN = DANGNHAP.MANHANVIEN ";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            dataGridUser.DataSource = khodl;
        }
        private void txt()
        {
            textBoxTK.DataBindings.Clear();
            textBoxTK.DataBindings.Add("Text", dataGridUser.DataSource, "taikhoan");
            textBoxMK.DataBindings.Clear();
            textBoxMK.DataBindings.Add("Text", dataGridUser.DataSource, "matkhau");
            comboBoxCanBo.DataBindings.Clear();
            comboBoxCanBo.DataBindings.Add("Text",dataGridUser.DataSource, "tennhanvien");
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridUser.DataSource, "ghichu");
        }
        private void cbbcanbo()
        {
            ketnoi.Open();
            string sql = "select * from nhanvien";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            comboBoxCanBo.DataSource = khodl;
            comboBoxCanBo.DisplayMember = "tennhanvien";
            comboBoxCanBo.ValueMember = "MAnhanvien";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "  SELECT DANGNHAP.TAIKHOAN, DANGNHAP.MATKHAU, DANGNHAP.MANHANVIEN, NHANVIEN.TENNHANVIEN, DANGNHAP.GHICHU FROM  DANGNHAP INNER JOIN  NHANVIEN ON DANGNHAP.MANHANVIEN = NHANVIEN.MANHANVIEN WHERE TAIKHOAN = '" + textBoxTK.Text + "' OR MATKHAU = '" + textBoxMK.Text + "' OR dangnhap.MAnhanvien='" + comboBoxCanBo.SelectedValue + "' OR GHICHU = '" + textBox1.Text + "'";
            SqlCommand tim = new SqlCommand(t, ketnoi);
            tim.CommandType = CommandType.Text;
            SqlDataAdapter tk = new SqlDataAdapter(tim);
            DataTable khodl = new DataTable();
            tk.Fill(khodl);
            ketnoi.Close();
            dataGridUser.DataSource = khodl;
            buttonHuy.Enabled = false;
            buttonThem.Enabled = false;
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (textBoxTK.Text != "" && textBoxMK.Text != ""&&comboBoxCanBo.Text!= "")
                {
                    ketnoi.Open();
                    string add = "insert into dangnhap values('" + textBoxTK.Text + "','" + textBoxMK.Text + "','" + comboBoxCanBo.SelectedValue + "','" + textBox1.Text + "')";
                    SqlCommand them = new SqlCommand(add, ketnoi);
                    them.CommandType = CommandType.Text;
                    them.ExecuteNonQuery();
                    ketnoi.Close();
                    MessageBox.Show("Tạo tài khoản thành công !", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    laydulieu();
                    txt();
                    buttonXoa.Enabled = true;
                    buttonSua.Enabled = true;
                    buttonHuy.Enabled = false;
                    buttonThem.Enabled = false;
                    textBoxTK.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Chưa Nhập Đủ Thông Tin!", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            catch
            {
                MessageBox.Show("Tên tài Khoản đã tồn tại!", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ketnoi.Close();
            }
        }

        private void FormquanlyUser_Load(object sender, EventArgs e)
        {
            laydulieu();
            txt();
            cbbcanbo();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
             DialogResult x;
            x = MessageBox.Show("Sửa thông tin tài khoản này?", "Cập nhật thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string up = "update dangnhap set matkhau = '" + textBoxMK.Text + "',manhanvien= '" + comboBoxCanBo.SelectedValue + "',ghichu='" + textBox1.Text + "' where taikhoan = '" + textBoxTK.Text + "'";
                SqlCommand sua = new SqlCommand(up, ketnoi);
                sua.CommandType = CommandType.Text;
                sua.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Sửa thông tin thành công !","Cập nhật thông tin");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
             DialogResult x;
            x = MessageBox.Show("Xóa thông tin tài khoản này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string del = "delete from dangnhap where taikhoan = '" + textBoxTK.Text + "' ";
                SqlCommand xoa = new SqlCommand(del, ketnoi);
                xoa.CommandType = CommandType.Text;
                xoa.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Xóa thông tin thành công !", "Xóa thông tin");
            }
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            textBoxTK.Clear();
            textBoxMK.Clear();
            comboBoxCanBo.Text = "";
            textBox1.Clear();
            textBoxTK.Focus();
            buttonTim.Enabled = true;
            buttonXoa.Enabled = false;
            buttonThem.Enabled = true;
            buttonHuy.Enabled = true;
            buttonSua.Enabled = false;
            textBoxTK.Enabled = true;
            laydulieu();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            laydulieu();
            txt();
            buttonSua.Enabled = true;
            buttonHuy.Enabled = false;
            buttonThem.Enabled = false;
            buttonXoa.Enabled = true;
            textBoxTK.Enabled = false;
            buttonTim.Enabled = true;
        }
    }
}
