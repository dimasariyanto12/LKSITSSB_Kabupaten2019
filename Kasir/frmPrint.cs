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
using Microsoft.Reporting.WinForms;
using System.Drawing;




namespace Kasir
{
    public partial class frmPrint : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private string txttransno;

        public frmPrint(String transno)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            txttransno = transno;
        }
        private cetak GetData()
        {
            cn.Open();
            cm = new SqlCommand("select * from vw_cetak where transno='" + txttransno + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            cetak ds = new cetak();
            da.Fill(ds, "vw_cetak");
            return ds;
        }
        public void Cetak()
        {
            cetak ds = GetData();
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.rpvTransaksi.LocalReport.DataSources.Clear();
            this.rpvTransaksi.LocalReport.DataSources.Add(datasource);
            this.rpvTransaksi.RefreshReport();
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            
            cetak ds = GetData();
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.rpvTransaksi.LocalReport.DataSources.Clear();
            this.rpvTransaksi.LocalReport.DataSources.Add(datasource);
            this.rpvTransaksi.RefreshReport();
        }
      

      
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
