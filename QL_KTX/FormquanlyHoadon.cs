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
    public partial class FormquanlyHoadon : Form
    {
        public FormquanlyHoadon()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");
        private void cbbmp()
        {
            ketnoi.Open();
            string sql = "select * from phong";
            SqlCommand laydl = new SqlCommand(sql, ketnoi);
            laydl.CommandType = CommandType.Text;
            SqlDataAdapter dl = new SqlDataAdapter(laydl);
            DataTable khodl = new DataTable();
            dl.Fill(khodl);
            ketnoi.Close();
            comboBoxMaphong.DataSource = khodl;
            comboBoxMaphong.DisplayMember = "maphong";
            textBoxTienphong.DataBindings.Clear();
            textBoxTienphong.DataBindings.Add("Text", comboBoxMaphong.DataSource, "Tienphong");
        }
        private void laydulieu()
        {
            ketnoi.Open();
            string sql = "select * from hoadon";
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
            textBoxMahd.DataBindings.Clear();
            textBoxMahd.DataBindings.Add("Text", dataGridView1.DataSource, "mahd");
            comboBoxMaphong.DataBindings.Clear();
            comboBoxMaphong.DataBindings.Add("Text", dataGridView1.DataSource,"maphong");
            textBoxTienphong.DataBindings.Clear();
            textBoxTienphong.DataBindings.Add("Text", dataGridView1.DataSource, "tienphong");
            textBoxDiencu.DataBindings.Clear();
            textBoxDiencu.DataBindings.Add("Text", dataGridView1.DataSource, "sodiencu");
            textBoxNuocmoi.DataBindings.Clear();
            textBoxNuocmoi.DataBindings.Add("Text", dataGridView1.DataSource, "sonuocmoi");
            textBoxDienmoi.DataBindings.Clear();
            textBoxDienmoi.DataBindings.Add("Text", dataGridView1.DataSource, "sodienmoi");
            textBoxNuoccu.DataBindings.Clear();
            textBoxNuoccu.DataBindings.Add("Text", dataGridView1.DataSource, "sonuoccu");
            textBoxTongtien.DataBindings.Clear();
            textBoxTongtien.DataBindings.Add("Text", dataGridView1.DataSource, "tongtien");
            textBoxTinhtrang.DataBindings.Clear();
            textBoxTinhtrang.DataBindings.Add("Text", dataGridView1.DataSource, "tinhtrang");
        }
        private void FormquanlyHoadon_Load(object sender, EventArgs e)
        {
            cbbmp();
            laydulieu();
            txt();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "select * from hoadon where mahd = '" +textBoxMahd.Text + "' or maphong = '" + comboBoxMaphong.Text + "' or sodiencu = '" + textBoxDiencu.Text + "' or sodienmoi = '" + textBoxDienmoi.Text + "' or sonuoccu = '" + textBoxNuoccu.Text + "' or sonuocmoi = '" + textBoxNuocmoi.Text + "' or tongtien = '" + textBoxTongtien.Text + "' or tinhtrang = '" + textBoxTinhtrang.Text + "' ";
            SqlCommand tim = new SqlCommand(t, ketnoi);
            tim.CommandType = CommandType.Text;
            SqlDataAdapter tk = new SqlDataAdapter(tim);
            DataTable khodl = new DataTable();
            tk.Fill(khodl);
            ketnoi.Close();
            dataGridView1.DataSource = khodl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMahd.Text = "";
            comboBoxMaphong.Text = "";
            textBoxTienphong.Text = "";
            textBoxTongtien.Text = "";
            textBoxDienmoi.Text = "";
            textBoxDiencu.Text = "";
            textBoxNuoccu.Text = "";
            textBoxNuocmoi.Text = "";
            textBoxTinhtrang.Text = "";
            buttonThem.Enabled = true;
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            buttonHuy.Enabled = true;
            laydulieu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

                ketnoi.Open();
                string add = "insert into hoadon values('" + textBoxMahd.Text + "','" + comboBoxMaphong.Text + "','" + textBoxTienphong.Text + "','" + textBoxDiencu.Text + "','" + textBoxDienmoi.Text + "','" + textBoxNuoccu.Text + "','" + textBoxNuocmoi.Text + "','" + textBoxTongtien.Text + "','" + textBoxTinhtrang.Text + "')";
                SqlCommand them = new SqlCommand(add, ketnoi);
                them.CommandType = CommandType.Text;
                them.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Thêm hóa đơn thành công !", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                laydulieu();
                txt();
                buttonThem.Enabled = false;
                buttonHuy.Enabled = false;
                buttonXoa.Enabled = true;
                buttonSua.Enabled = true;
            
                
            


        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Sửa thông tin hóa đơn này?", "Cập nhật thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string up = "update hoadon set maphong = '" + comboBoxMaphong.Text + "',sodiencu = '" + textBoxDiencu.Text + "',sodienmoi = '" + textBoxDienmoi.Text + "',sonuoccu = '" + textBoxNuoccu.Text + "',sonuocmoi = '" + textBoxNuocmoi.Text + "',tongtien = '" + textBoxTongtien.Text + "', tinhtrang = '" + textBoxTinhtrang.Text + "' WHERE MAHD = '" + textBoxMahd.Text + "'";
                SqlCommand sua = new SqlCommand(up, ketnoi);
                sua.CommandType = CommandType.Text;
                sua.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Sửa thông tin thành công !", "Cập nhật thông tin");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Xóa thông tin hóa đơn này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                ketnoi.Open();
                string del = "delete from hoadon where mahd = '" + textBoxMahd.Text + "' ";
                SqlCommand xoa = new SqlCommand(del, ketnoi);
                xoa.CommandType = CommandType.Text;
                xoa.ExecuteNonQuery();
                ketnoi.Close();
                laydulieu();
                txt();
                MessageBox.Show("Xóa thông tin thành công !", "Xóa thông tin");
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBoxTienphong.Text);
            float b = float.Parse(textBoxNuoccu.Text);
            float c = float.Parse(textBoxNuocmoi.Text);
            float d = float.Parse(textBoxDiencu.Text);
            float f = float.Parse(textBoxDienmoi.Text);

            textBoxTongtien.Text = (a + (c - b) * 5000 + (f - d) * 2000).ToString();

        }

        private void textBoxTongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormbaocaoHoadon formhoadon = new FormbaocaoHoadon();
            formhoadon.mahd = textBoxMahd.Text;
            formhoadon.maphong = comboBoxMaphong.Text;
            formhoadon.tienphong = textBoxTienphong.Text;
            formhoadon.sonuocmoi = textBoxNuocmoi.Text;
            formhoadon.sodienmoi = textBoxDienmoi.Text;
            formhoadon.sodiencu = textBoxDiencu.Text;
            formhoadon.sonuocu = textBoxNuoccu.Text;
            formhoadon.tongtien = textBoxTongtien.Text;
            formhoadon.tinhtrang = textBoxTinhtrang.Text;
            formhoadon.Show();
        }

        private void textBoxMahd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
