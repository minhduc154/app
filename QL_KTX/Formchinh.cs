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
    public partial class Formchinh : Form
    {
        public Formchinh()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");

        public string tkdangnhap;
       
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
            comboBox1.DataSource = khodl;
            comboBox1.DisplayMember = "tennhanvien";
            comboBox1.ValueMember = "manhanvien";
        }
        private void laydulieuTaikhoan()
        {
            ketnoi.Open();
            string sql = "SELECT DANGNHAP.TAIKHOAN, DANGNHAP.MATKHAU, DANGNHAP.MANHANVIEN, NHANVIEN.TENNHANVIEN, DANGNHAP.GHICHU FROM NHANVIEN INNER JOIN DANGNHAP ON NHANVIEN.MANHANVIEN = DANGNHAP.MANHANVIEN where taikhoan ='"+textBoxUser.Text+"'";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            dataGridView1.DataSource = khodl;
        }
        private void txtTaikhoan()
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "taikhoan");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "matkhau");
            comboBox1.DataBindings.Clear();
            comboBox1.DataBindings.Add("Text",dataGridView1.DataSource,"tennhanvien");
        }
        private void Formchinh_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = tkdangnhap;
           
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            groupBox1.Visible = true;
            dataGridView1.Visible = true;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laydulieuTaikhoan();
            cbbcanbo();
            txtTaikhoan();

            ketnoi.Open();
            string sql = "select ghichu from dangnhap where taikhoan = '" +textBoxUser.Text+"'";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            textBoxGhichu.Text = khodl.Rows[0][0].ToString();
            
            if (textBoxGhichu.Text == "ADMIN")
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
                quảnLýNhânViênToolStripMenuItem.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormquanlyUser formuser = new FormquanlyUser();
            formuser.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formdangnhap formdn = new Formdangnhap();
            formdn.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = false;
            pictureBox1.Visible = true;
        }

        private void nghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = false;
            pictureBox1.Visible = true;
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = false;
            pictureBox1.Visible = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DialogResult x;
             x = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
             if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formthongtin formtt = new Formthongtin();
            formtt.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\minhd\Documents\Visual Studio 2013\Projects\quanlyktx\QL_KTX\Resources\filetrogiup.docx");

        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormquanlySv formqlsv = new FormquanlySv();
            formqlsv.Show();
        }

        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormquanlyPhong formquanlyphong = new FormquanlyPhong();
            formquanlyphong.Show();
        }

        private void quảnLýBiênBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormquanlyBienban formquanlybienban = new FormquanlyBienban();
            formquanlybienban.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Sửa thông tin tài khoản này?", "Cập nhật thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string up = "update dangnhap set manhanvien = '" + comboBox1.SelectedValue + "',matkhau = '" + textBox2.Text + "' where taikhoan = '" + textBox1.Text + "' ";
                SqlCommand sua = new SqlCommand(up, ketnoi);
                sua.CommandType = CommandType.Text;
                sua.ExecuteNonQuery();
                ketnoi.Close();
                laydulieuTaikhoan();
                MessageBox.Show("Cập nhật thông tin thành công !","Thông Báo");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormquanlyHoadon formquanlyhoadon = new FormquanlyHoadon();
            formquanlyhoadon.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormquanlyNhanvien formquanlynhanvien = new FormquanlyNhanvien();
            formquanlynhanvien.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
