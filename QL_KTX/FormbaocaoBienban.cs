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
    public partial class FormbaocaoBienban : Form
    {
        public FormbaocaoBienban()
        {
            InitializeComponent();
        }
        public string mabienban;
        public string masinhvien;
        public string hoten;
        public string noidung;
        public string ghichu;
        public string ngay;

        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");
        private void FormbaocaoBienban_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "SELECT BIENBAN.MABIENBAN, BIENBAN.MASV, SINHVIEN.HOTEN, BIENBAN.NOIDUNG, BIENBAN.GHICHU FROM BIENBAN INNER JOIN  SINHVIEN ON BIENBAN.MASV = SINHVIEN.MASV where mabienban = '" + mabienban + "' or Bienban.masv = '" + masinhvien+ "' or noidung = '" + noidung + "' or ghichu = '" +ghichu+ "' or ngaylap = '"+ngay+"'";
            SqlCommand tim = new SqlCommand(t, ketnoi);
            tim.CommandType = CommandType.Text;
            SqlDataAdapter tk = new SqlDataAdapter(tim);
            DataTable khodl = new DataTable();
            tk.Fill(khodl);
            ketnoi.Close();
           CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(khodl);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
