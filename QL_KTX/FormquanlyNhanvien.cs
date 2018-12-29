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
    public partial class FormquanlyNhanvien : Form
    {
        public FormquanlyNhanvien()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");

        private void laydulieu()
        {
            ketnoi.Open();
            string sql = "select nhanvien.*,chucvu.tenchucvu from nhanvien inner join chucvu on nhanvien.machucvu = chucvu.machucvu";
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
            textBoxManv.DataBindings.Clear();
            textBoxManv.DataBindings.Add("Text", dataGridView1.DataSource, "manhanvien");
            textBoxTennv.DataBindings.Clear();
            textBoxTennv.DataBindings.Add("Text", dataGridView1.DataSource, "tennhanvien");
            comboBoxChucvu.DataBindings.Clear();
            comboBoxChucvu.DataBindings.Add("Text", dataGridView1.DataSource, "tenchucvu");
            textBoxCmnd.DataBindings.Clear();
            textBoxCmnd.DataBindings.Add("Text", dataGridView1.DataSource, "cmnd");
            textBoxDiachi.DataBindings.Clear();
            textBoxDiachi.DataBindings.Add("Text", dataGridView1.DataSource, "diachi");
            textBoxSdt.DataBindings.Clear();
            textBoxSdt.DataBindings.Add("Text", dataGridView1.DataSource, "sdt");
        }
        private void cbbcv()
        {
            ketnoi.Open();
            string sql = "select * from chucvu";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            comboBoxChucvu.DataSource = khodl;
            comboBoxChucvu.DisplayMember = "machucvu";
            comboBoxChucvu.ValueMember = "machucvu";

        }
        private void FormquanlyNhanvien_Load(object sender, EventArgs e)
        {
            cbbcv();
            laydulieu();
            txt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "select nhanvien.*,chucvu.tenchucvu from nhanvien inner join chucvu on nhanvien.machucvu=chucvu.machucvu where manhanvien = '" + textBoxManv.Text + "' or tennhanvien = '" + textBoxTennv.Text + "' or nhanvien.machucvu =(select machucvu from chucvu where tenchucvu = '" + comboBoxChucvu.Text + "') or cmnd = '" + textBoxCmnd.Text + "' or sdt = '" + textBoxSdt.Text + "' or diachi ='"+textBoxDiachi.Text+"'";
            SqlCommand tim = new SqlCommand(t, ketnoi);
            tim.CommandType = CommandType.Text;
            SqlDataAdapter tk = new SqlDataAdapter(tim);
            DataTable khodl = new DataTable();
            tk.Fill(khodl);
            ketnoi.Close();
            dataGridView1.DataSource = khodl;
            txt();
            buttonHuy.Enabled = false;
            buttonThem.Enabled = false;
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
                string add = "insert into nhanvien values('" + textBoxManv.Text + "','"+textBoxTennv.Text+"','" + comboBoxChucvu.SelectedValue + "','" + textBoxCmnd.Text + "','" + textBoxSdt.Text + "','" + textBoxDiachi.Text + "')";
                SqlCommand them = new SqlCommand(add, ketnoi);
                them.CommandType = CommandType.Text;
                them.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Thêm thông tin nhân viên thành công !", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                laydulieu();
                txt();
                buttonThem.Enabled = false;
                buttonHuy.Enabled = false;
                buttonXoa.Enabled = true;
                buttonSua.Enabled = true;


            }
            catch
            {
                MessageBox.Show("Nhập thông tin không hợp lệ !", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Xóa thông tin nhân viên này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string del = "delete from nhanvien where manhanvien = '" + textBoxManv.Text + "' ";
                SqlCommand xoa = new SqlCommand(del, ketnoi);
                xoa.CommandType = CommandType.Text;
                xoa.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Xóa thông tin thành công !", "Xóa thông tin");
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Sửa thông tin nhân viên này?", "Cập nhật thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string up = "update nhanvien set manhanvien = '" + textBoxManv.Text + "', tennhanvien = '" + textBoxTennv.Text + "',machucvu='" + comboBoxChucvu.SelectedValue + "',cmnd='" + textBoxCmnd.Text + "',sdt='" + textBoxSdt.Text + "',diachi = '" + textBoxDiachi.Text + "' where manhanvien = '"+textBoxManv.Text+"'";
                SqlCommand sua = new SqlCommand(up, ketnoi);
                sua.CommandType = CommandType.Text;
                sua.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Sửa thông tin thành công !", "Cập nhật thông tin");
            }
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonHuy.Enabled = false;
            buttonThem.Enabled = false;
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;
            laydulieu();
            txt();
        }

        private void buttonLammoi_Click(object sender, EventArgs e)
        {
            textBoxTennv.Text = "";
            textBoxManv.Text = "";
            comboBoxChucvu.Text = "";
            textBoxCmnd.Text = "";
            textBoxDiachi.Text = "";
            textBoxSdt.Text = "";
            buttonHuy.Enabled = true;
            buttonSua.Enabled = false;
            buttonThem.Enabled = true;
            buttonXoa.Enabled = false;
            laydulieu();
            
        }

        private void comboBoxChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
