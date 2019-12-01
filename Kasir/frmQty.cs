using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class frmQty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "SIMPLE POS SYSTEM";
        frmTransaksi fTransaksi;


        //variabel detail produk
        private String transno;
        private double harga;
        private String kode_brg;
        private String kode_plg;
        public frmQty(frmTransaksi frm)
        {
           
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fTransaksi = frm;
        }

        private void Panel_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void BarangDetails(String transno, String kode_brg,String kode_plg,double harga)
        {
            this.transno = transno;
            this.harga = harga;
            this.kode_brg = kode_brg;
            this.kode_plg = kode_plg;
        }

        private void Panel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar==46)
            //{

            //}else if (e.KeyChar == 8)
            //{

            //}else if((e.KeyChar<48) || (e.KeyChar > 57))
            //{
            //    e.Handled = true;
            //}
            if ((e.KeyChar == 13) && (txtQty.Text != String.Empty))
            {
                cn.Open();
                cm = new SqlCommand("insert into cart (transno,tgl,kode_brg,kode_brg,kode_plg,harga,qty) values (@transno,@tgl,@kode_brg,@kode_brg,@kode_plg,@harga,@qty)", cn);
                cm.Parameters.AddWithValue("@transno", fTransaksi.lblNoTrx.Text);
                cm.Parameters.AddWithValue("@tgl", DateTime.Now);
                cm.Parameters.AddWithValue("@kode_brg", fTransaksi.lblKodeBrg.Text);
                cm.Parameters.AddWithValue("@kode_plg", fTransaksi.lblkodePlg.Text);
                cm.Parameters.AddWithValue("@harga", harga);
                cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                cm.ExecuteNonQuery();

                cn.Close();
                fTransaksi.clear();

                this.Dispose();


            }


        }

        private void FrmQty_Load(object sender, EventArgs e)
        {
            txtQty.Text = "0";
        }
    }
}
