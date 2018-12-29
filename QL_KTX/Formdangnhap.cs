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
    public partial class Formdangnhap : Form
    {
        public Formdangnhap()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
           ;
        }

        private void Formdangnhap_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox1.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             ketnoi.Open();
            string sql = "select * from dangnhap where taikhoan = '" + textBox1.Text + "' and matkhau = '" + textBox2.Text + "' ";
            SqlCommand dn = new SqlCommand(sql, ketnoi);
            dn.CommandType = CommandType.Text;
            SqlDataReader dr = dn.ExecuteReader();
            if (dr.Read() == true)
            {
                Formchinh formchinh = new Formchinh();
                formchinh.tkdangnhap = textBox1.Text;
                formchinh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông Báo !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ketnoi.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Formdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (x == DialogResult.No)
                e.Cancel = true;
        }
    }
}
