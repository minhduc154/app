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
    public partial class FormquanlyBienban : Form
    {
        public FormquanlyBienban()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");
        private void cbbmasv()
        {
            ketnoi.Open();
            string sql = "select * from sinhvien";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            comboBoxMasv.DataSource = khodl;
            comboBoxMasv.DisplayMember = "masv";
            textBoxTensv.DataBindings.Clear();
            textBoxTensv.DataBindings.Add("Text",comboBoxMasv.DataSource,"hoten");
        }
        private void laydulieu()
        {
            ketnoi.Open();
            string sql = "SELECT BIENBAN.MABIENBAN, BIENBAN.MASV,BIENBAN.NGAYLAP, SINHVIEN.HOTEN, BIENBAN.NOIDUNG, BIENBAN.GHICHU FROM BIENBAN INNER JOIN  SINHVIEN ON BIENBAN.MASV = SINHVIEN.MASV";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            dataGridView1.DataSource = khodl;
        }
        private void txt()
        {
            textBoxMabb.DataBindings.Clear();
            textBoxMabb.DataBindings.Add("Text", dataGridView1.DataSource, "mabienban");
            textBoxTensv.DataBindings.Clear();
            textBoxTensv.DataBindings.Add("Text", dataGridView1.DataSource, "hoten");
            comboBoxMasv.DataBindings.Clear();
            comboBoxMasv.DataBindings.Add("Text", dataGridView1.DataSource, "masv");
            textBoxGhichu.DataBindings.Clear();
            textBoxGhichu.DataBindings.Add("Text", dataGridView1.DataSource, "ghichu");
            textBoxNoidung.DataBindings.Clear();
            textBoxNoidung.DataBindings.Add("Text", dataGridView1.DataSource, "noidung");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dataGridView1.DataSource, "ngaylap");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMabb.Text = "";
            textBoxNoidung.Text = "";
            textBoxGhichu.Text = "";
            comboBoxMasv.Text = "";
            textBoxTensv.Text = "";
            buttonXoa.Enabled = false;
            buttonThem.Enabled = true;
            buttonHuy.Enabled = true;
            buttonSua.Enabled = false;
            laydulieu();
        }

        private void FormquanlyBienban_Load(object sender, EventArgs e)
        {
            cbbmasv();
            laydulieu();
            txt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string add = "insert into bienban values('"+textBoxMabb.Text+"','"+dateTimePicker1.Text+"','"+comboBoxMasv.Text+"','"+textBoxNoidung.Text+"','"+textBoxGhichu.Text+"')";
            SqlCommand them = new SqlCommand(add, ketnoi);
            them.CommandType = CommandType.Text;
            them.ExecuteNonQuery();
            ketnoi.Close();
            MessageBox.Show("Thêm biên bản thành công !", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            laydulieu();
            txt();
            buttonThem.Enabled = false;
            buttonHuy.Enabled = false;
            buttonXoa.Enabled = true;
            buttonSua.Enabled = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Sửa thông tin biên bản này?", "Cập nhật thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string up = "update bienban set masv='" + comboBoxMasv.Text + "',noidung = '" + textBoxNoidung.Text + "',ghichu ='" + textBoxGhichu.Text + "',ngaylap='" + dateTimePicker1.Text + "' where mabienban = '" + textBoxMabb.Text + "'";
                SqlCommand sua = new SqlCommand(up, ketnoi);
                sua.CommandType = CommandType.Text;
                sua.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Sửa thông tin thành công !", "Cập nhật thông tin");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Xóa thông tin biên bản này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string del = "delete from bienban where mabienban = '" + textBoxMabb.Text + "' ";
                SqlCommand xoa = new SqlCommand(del, ketnoi);
                xoa.CommandType = CommandType.Text;
                xoa.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Xóa thông tin thành công !", "Xóa thông tin");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "SELECT BIENBAN.MABIENBAN,BIENBAN.NGAYLAP, BIENBAN.MASV, SINHVIEN.HOTEN, BIENBAN.NOIDUNG, BIENBAN.GHICHU FROM BIENBAN INNER JOIN  SINHVIEN ON BIENBAN.MASV = SINHVIEN.MASV where mabienban = '"+textBoxMabb.Text+"' or Bienban.masv = '"+comboBoxMasv.Text+"' or noidung = '"+textBoxNoidung.Text+"' or ghichu = '"+textBoxGhichu.Text+"' or ngaylap = '"+dateTimePicker1.Text+"'";
            SqlCommand tim = new SqlCommand(t, ketnoi);
            tim.CommandType = CommandType.Text;
            SqlDataAdapter tk = new SqlDataAdapter(tim);
            DataTable khodl = new DataTable();
            tk.Fill(khodl);
            ketnoi.Close();
            dataGridView1.DataSource = khodl;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;
            buttonThem.Enabled = false;
            buttonHuy.Enabled = false;
            laydulieu();
            txt();
           
        }

       

        private void buttonIn_Click(object sender, EventArgs e)
        {
            FormbaocaoBienban formbienban = new FormbaocaoBienban();
            formbienban.mabienban = textBoxMabb.Text;
            formbienban.masinhvien = comboBoxMasv.Text;
            formbienban.hoten = textBoxTensv.Text;
            formbienban.noidung = textBoxNoidung.Text;
            formbienban.ghichu = textBoxGhichu.Text;
            formbienban.ngay = dateTimePicker1.Text;
            formbienban.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
