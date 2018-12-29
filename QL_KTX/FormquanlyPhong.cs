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
    public partial class FormquanlyPhong : Form
    {
        public FormquanlyPhong()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");

        private void laydulieu()
        {
            ketnoi.Open();
            string sql = "select * from phong";
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
            textBoxMaphong.DataBindings.Clear();
            textBoxMaphong.DataBindings.Add("Text", dataGridView1.DataSource, "maphong");
            textBoxLoaiphong.DataBindings.Clear();
            textBoxLoaiphong.DataBindings.Add("Text", dataGridView1.DataSource, "loaiphong");
            textBoxChotrong.DataBindings.Clear();
            textBoxChotrong.DataBindings.Add("Text", dataGridView1.DataSource, "chotrong");
            textBoxTien.DataBindings.Clear();
            textBoxTien.DataBindings.Add("Text", dataGridView1.DataSource, "tienphong");
            textBoxTinhtrang.DataBindings.Clear();
            textBoxTinhtrang.DataBindings.Add("Text", dataGridView1.DataSource, "tinhtrang");
        }
        private void FormquanlyPhong_Load(object sender, EventArgs e)
        {
            laydulieu();
            txt();

        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "select * from phong where maphong = '" + textBoxMaphong.Text + "' or tinhtrang = '"+textBoxTinhtrang.Text+"' or loaiphong = '" + textBoxLoaiphong.Text + "' or chotrong = '" + textBoxChotrong.Text + "' or tienphong = '" + textBoxTien.Text + "'";
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
                string add = "insert into phong values('"+textBoxMaphong.Text+"','"+textBoxLoaiphong.Text+"','"+textBoxLoaiphong.Text+"','"+textBoxTien.Text+"','"+textBoxTinhtrang.Text+"')";
                SqlCommand them = new SqlCommand(add, ketnoi);
                them.CommandType = CommandType.Text;
                them.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Thêm thông tin phòng thành công !", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Sửa thông tin phòng này?", "Cập nhật thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string up = "update phong set loaiphong = '" + textBoxLoaiphong.Text + "', tienphong = '" + textBoxTien.Text + "',tinhtrang = '" + textBoxTinhtrang.Text + "' where maphong = '" + textBoxMaphong.Text + "' ";
                SqlCommand sua = new SqlCommand(up, ketnoi);
                sua.CommandType = CommandType.Text;
                sua.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Sửa thông tin thành công !", "Cập nhật thông tin");
            }
        }

        private void buttonLammoi_Click(object sender, EventArgs e)
        {
            textBoxTinhtrang.Text = "";
            textBoxMaphong.Text = "";
            textBoxLoaiphong.Text = "";
            textBoxChotrong.Text = "";
            textBoxTien.Text = "";
            laydulieu();
            buttonHuy.Enabled = true;
            buttonThem.Enabled = true;
            textBoxChotrong.Enabled = true;
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            laydulieu();

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult x;
            x = MessageBox.Show("Xóa thông tin phòng này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                try
                {
                    ketnoi.Open();
                    string del = "delete from phong where maphong = '" + textBoxMaphong.Text + "' ";
                    SqlCommand xoa = new SqlCommand(del, ketnoi);
                    xoa.CommandType = CommandType.Text;
                    xoa.ExecuteNonQuery();
                    ketnoi.Close();
                    laydulieu();
                    txt();
                    MessageBox.Show("Xóa thông tin thành công !", "Xóa thông tin");
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công! Phòng còn sinh viên!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonHuy.Enabled = false;
            buttonThem.Enabled = false;
            textBoxChotrong.Enabled = false;
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;
            laydulieu();
            txt();
        }
    }
}
