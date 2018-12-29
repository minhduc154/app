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
    public partial class FormbaocaoHoadon : Form
    {
        public FormbaocaoHoadon()
        {
            InitializeComponent();
        }

        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");

        public string mahd;
        public string maphong;
        public string tienphong;
        public string sodiencu;
        public string sodienmoi;
        public string sonuocu;
        public string sonuocmoi;
        public string tongtien;
        public string tinhtrang;
        
        private void FormbaocaoHoadon_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "SELECT * from hoadon where mahd = '"+mahd+"' or maphong = '"+maphong+"' or tienphong = '"+tienphong+"' or sodiencu = '"+sodiencu+"' or sodienmoi = '"+sodienmoi+"' or sonuoccu = '"+sonuocu+"' or sonuocmoi = '"+sonuocmoi+"' or tongtien = '"+tongtien+"' or tinhtrang = '"+tinhtrang+"' ";
            SqlCommand tim = new SqlCommand(t, ketnoi);
            tim.CommandType = CommandType.Text;
            SqlDataAdapter tk = new SqlDataAdapter(tim);
            DataTable khodl = new DataTable();
            tk.Fill(khodl);
            ketnoi.Close();
            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(khodl);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
