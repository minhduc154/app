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
    public partial class FormbaocaoSv : Form
    {
        public FormbaocaoSv()
        {
            InitializeComponent();
        }
        public string masv;
        public string hoten;
        public string diachi;
        public string gioitinh;
        public string cmnd;
        public string dantoc;
        public string phong;
        public string chinhsach;
        public string lop;
        public string sdt;

        SqlConnection ketnoi = new SqlConnection(@"Data Source=DUC1504;Initial Catalog=Quanlyktx;Integrated Security=True");
        private void FormbaocaoSv_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            string t = "SELECT SINHVIEN.MASV, SINHVIEN.HOTEN, SINHVIEN.DIACHI, SINHVIEN.GIOITINH, SINHVIEN.CMND, DANTOC.TENDANTOC, SINHVIEN.MAPHONG, DOITUONGCHINHSACH.TENCS, LOP.TENLOP,  SINHVIEN.SDT FROm  DANTOC INNER JOIN SINHVIEN ON DANTOC.MADANTOC = SINHVIEN.MADANTOC INNER JOIN DOITUONGCHINHSACH ON SINHVIEN.MACS = DOITUONGCHINHSACH.MACS INNER JOIN  LOP ON SINHVIEN.MALOP = LOP.MALOP where masv= '" + masv + "' or hoten = '" + hoten + "' or diachi = '" + diachi + "' or gioitinh = '" + gioitinh + "' or cmnd = '" + cmnd + "'or sinhvien.madantoc =(select dantoc.madantoc from dantoc where tendantoc = '" + dantoc + "') or sinhvien.maphong = '" + phong + "' or sinhvien.macs =(select doituongchinhsach.macs  where tencs ='" + chinhsach + "') or sinhvien.malop = (select lop.malop where tenlop='" + lop + "') or sdt = '" + sdt + "' "; SqlCommand tim = new SqlCommand(t, ketnoi);
            tim.CommandType = CommandType.Text;
            SqlDataAdapter tk = new SqlDataAdapter(tim);
            DataTable khodl = new DataTable();
            tk.Fill(khodl);
            ketnoi.Close();
            CrystalReport3 cr = new CrystalReport3();
            cr.SetDataSource(khodl);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
