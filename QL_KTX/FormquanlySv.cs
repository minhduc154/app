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
    public partial class FormquanlySv : Form
    {
        public FormquanlySv()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");
        private void cbbphong()
        {
            ketnoi.Open();
            string sql = "select * from phong where chotrong >0";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            comboBoxPhong.DataSource = khodl;
            comboBoxPhong.DisplayMember = "maphong";
           
        }
        private void cbbdantoc()
        {
            ketnoi.Open();
            string sql = "select * from dantoc";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            comboBoxDantoc.DataSource = khodl;
            comboBoxDantoc.DisplayMember = "tendantoc";
            comboBoxDantoc.ValueMember = "madantoc";

        }
        private void cbbchinhsach()
        {
            ketnoi.Open();
            string sql = "select * from doituongchinhsach";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            comboBoxChinhsach.DataSource = khodl;
            comboBoxChinhsach.DisplayMember = "tencs";
            comboBoxChinhsach.ValueMember = "macs";

        }
        private void cbblop()
        {
            ketnoi.Open();
            string sql = "select * from lop";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            comboBoxLop.DataSource = khodl;
            comboBoxLop.DisplayMember = "tenlop";
            comboBoxLop.ValueMember = "malop";

        }
        private void laydulieu()
        {
            ketnoi.Open();
            string sql = "SELECT SINHVIEN.MASV, SINHVIEN.HOTEN, SINHVIEN.DIACHI, SINHVIEN.GIOITINH, SINHVIEN.CMND, DANTOC.TENDANTOC, SINHVIEN.MAPHONG, DOITUONGCHINHSACH.TENCS, LOP.TENLOP, SINHVIEN.SDT FROM   SINHVIEN INNER JOIN LOP ON SINHVIEN.MALOP = LOP.MALOP INNER JOIN  DANTOC ON SINHVIEN.MADANTOC = DANTOC.MADANTOC INNER JOIN  DOITUONGCHINHSACH ON SINHVIEN.MACS = DOITUONGCHINHSACH.MACS";
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
            textBoxMasv.DataBindings.Clear();
            textBoxMasv.DataBindings.Add("Text", dataGridView1.DataSource, "masv");
            textBoxHoten.DataBindings.Clear();
            textBoxHoten.DataBindings.Add("Text", dataGridView1.DataSource, "hoten");
            textBoxDiachi.DataBindings.Clear();
            textBoxDiachi.DataBindings.Add("Text", dataGridView1.DataSource, "diachi");
            textBoxCmnd.DataBindings.Clear();
            textBoxCmnd.DataBindings.Add("Text", dataGridView1.DataSource, "cmnd");
            comboBoxGioitinh.DataBindings.Clear();
            comboBoxGioitinh.DataBindings.Add("Text", dataGridView1.DataSource, "Gioitinh");
            comboBoxDantoc.DataBindings.Clear();
            comboBoxDantoc.DataBindings.Add("Text", dataGridView1.DataSource, "tendantoc");
            comboBoxPhong.DataBindings.Clear();
            comboBoxPhong.DataBindings.Add("Text", dataGridView1.DataSource, "Maphong");
            comboBoxChinhsach.DataBindings.Clear();
            comboBoxChinhsach.DataBindings.Add("Text", dataGridView1.DataSource,"tencs");
            comboBoxLop.DataBindings.Clear();
            comboBoxLop.DataBindings.Add("Text", dataGridView1.DataSource, "Tenlop");
            textBoxSdt.DataBindings.Clear();
            textBoxSdt.DataBindings.Add("Text", dataGridView1.DataSource, "sdt");
        }
        private void chotrong()
        {
            ketnoi.Open();
            string cho = "update phong set chotrong = ((select loaiphong from phong where maphong = '" + comboBoxPhong.Text + "')-(select count(masv) from sinhvien where maphong = '" + comboBoxPhong.Text + "')) where maphong = '" + comboBoxPhong.Text + "' ";
            SqlCommand giam = new SqlCommand(cho, ketnoi);
            giam.CommandType = CommandType.Text;
            giam.ExecuteNonQuery();
            ketnoi.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formquanlysv_Load(object sender, EventArgs e)
        {
            cbblop();
            laydulieu();
            cbbdantoc();
            cbbchinhsach();
            cbbphong();
            txt();
        }
        

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "SELECT SINHVIEN.MASV, SINHVIEN.HOTEN, SINHVIEN.DIACHI, SINHVIEN.GIOITINH, SINHVIEN.CMND, DANTOC.TENDANTOC, SINHVIEN.MAPHONG, DOITUONGCHINHSACH.TENCS, LOP.TENLOP, SINHVIEN.SDT FROM   SINHVIEN INNER JOIN LOP ON SINHVIEN.MALOP = LOP.MALOP INNER JOIN  DANTOC ON SINHVIEN.MADANTOC = DANTOC.MADANTOC INNER JOIN  DOITUONGCHINHSACH ON SINHVIEN.MACS = DOITUONGCHINHSACH.MACS where masv= '" + textBoxMasv.Text + "' or hoten = '" + textBoxHoten.Text + "' or diachi = '" + textBoxDiachi.Text + "' or gioitinh = '" + comboBoxGioitinh.Text + "' or cmnd = '" + textBoxCmnd.Text + "'or sinhvien.madantoc =(select dantoc.madantoc from dantoc where tendantoc = '" + comboBoxDantoc.Text + "') or sinhvien.maphong = '" + comboBoxPhong.Text + "' or sinhvien.macs =(select doituongchinhsach.macs  where tencs ='" + comboBoxChinhsach.Text + "') or sinhvien.malop = (select lop.malop where tenlop='" + comboBoxLop.Text + "') or sdt = '" + textBoxSdt.Text + "' "; SqlCommand tim = new SqlCommand(t, ketnoi);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
                string add = "insert into sinhvien values('" + textBoxMasv.Text + "','" + textBoxHoten.Text + "','" + textBoxDiachi.Text + "','" + comboBoxGioitinh.Text + "','" + textBoxCmnd.Text + "','" + comboBoxDantoc.SelectedValue + "','" + comboBoxPhong.Text + "','" + comboBoxChinhsach.SelectedValue + "','" + comboBoxLop.SelectedValue + "','" + textBoxSdt.Text + "')";
                SqlCommand them = new SqlCommand(add, ketnoi);
               them.CommandType = CommandType.Text;
                them.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Thêm sinh viên thành công !", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chotrong();
                laydulieu();
                txt();
                buttonThem.Enabled = false;
                buttonHuy.Enabled = false;
                buttonXoa.Enabled = true;
                buttonSua.Enabled = true;

                ketnoi.Open();
                string d = "update phong set chotrong = (select loaiphong from phong where maphong ='"+comboBoxPhong.Text+"')-(count(masv) from sinhvien where maphong = '"+comboBoxPhong.Text+"') where maphong = '"+comboBoxPhong.Text+"'";
                SqlCommand to = new SqlCommand(d, ketnoi);
                to.CommandType = CommandType.Text;
                to.ExecuteNonQuery();
                ketnoi.Close();
                chotrong();
                laydulieu();
                txt();
            }
            catch
            {
                MessageBox.Show("Nhập thông tin không hợp lệ !", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            textBoxMasv.Text = "";
            textBoxHoten.Text = "";
            textBoxDiachi.Text = "";
            textBoxCmnd.Text = "";
            comboBoxGioitinh.Text = "";
            comboBoxLop.Text = "";
            comboBoxPhong.Text = "";
            comboBoxDantoc.Text = "";
            comboBoxChinhsach.Text = "";
            textBoxSdt.Text = "";
            buttonXoa.Enabled = false;
            buttonThem.Enabled = true;
            buttonHuy.Enabled = true;
            buttonSua.Enabled = false;
            laydulieu();
            textBoxMasv.Enabled = true;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBoxMasv.Enabled = false;
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;
            buttonThem.Enabled = false;
            laydulieu();
            txt();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            DialogResult x;
            x = MessageBox.Show("Xóa thông tin sinh viên này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string del = "delete from SINHVIEN where masv = '" + textBoxMasv.Text + "' ";
                SqlCommand xoa = new SqlCommand(del, ketnoi);
                xoa.CommandType = CommandType.Text;
                xoa.ExecuteNonQuery();
                ketnoi.Close();
                chotrong();
                laydulieu();
                txt();

                ketnoi.Open();
                string q = "";
                SqlCommand xo = new SqlCommand(q, ketnoi);
                xo.CommandType = CommandType.Text;
                xo.ExecuteNonQuery();
                ketnoi.Close();
                chotrong();
                laydulieu();
                txt();
              

                MessageBox.Show("Xóa thông tin thành công !", "Xóa thông tin");

            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Sửa thông tin sinh viên này?", "Cập nhật thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string up = "update sinhvien set hoten = '" + textBoxHoten.Text + "', diachi = '" + textBoxDiachi.Text + "',gioitinh = '" + comboBoxGioitinh.Text + "',cmnd = '" + textBoxCmnd.Text + "',madantoc = '" + comboBoxDantoc.SelectedValue + "',maphong = '" + comboBoxPhong.Text + "',macs = '" + comboBoxChinhsach.SelectedValue + "', malop = '" + comboBoxLop.SelectedValue + "',sdt ='" + textBoxSdt.Text + "' where masv = '" + textBoxMasv.Text + "'";
                SqlCommand sua = new SqlCommand(up, ketnoi);
                sua.CommandType = CommandType.Text;
                sua.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Sửa thông tin thành công !", "Cập nhật thông tin");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormbaocaoSv formbaocaosv = new FormbaocaoSv();
            formbaocaosv.masv = textBoxMasv.Text;
            formbaocaosv.hoten = textBoxHoten.Text;
            formbaocaosv.diachi = textBoxDiachi.Text;
            formbaocaosv.gioitinh = comboBoxGioitinh.Text;
            formbaocaosv.cmnd = textBoxCmnd.Text;
            formbaocaosv.phong = comboBoxPhong.Text;
            formbaocaosv.chinhsach = comboBoxChinhsach.Text;
            formbaocaosv.dantoc = comboBoxDantoc.Text;
            formbaocaosv.sdt = textBoxSdt.Text;
            formbaocaosv.lop = comboBoxLop.Text;
            formbaocaosv.Show();

        }
    }
}
