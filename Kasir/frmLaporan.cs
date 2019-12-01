using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class frmLaporan : Form
    {
        public frmLaporan()
        {
            InitializeComponent();
        }

        private void FrmLaporan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laporanPenjualan.vw_laporan' table. You can move, or remove it, as needed.
            this.vw_laporanTableAdapter.Fill(this.laporanPenjualan.vw_laporan);
            // TODO: This line of code loads data into the 'dbkasirDataSet29.view_barang' table. You can move, or remove it, as needed.
            this.view_barangTableAdapter.Fill(this.dbkasirDataSet29.view_barang);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
