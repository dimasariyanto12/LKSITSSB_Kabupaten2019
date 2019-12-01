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
    public partial class Transaksi : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public Transaksi()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            autonumber();
        }

        public void Clear()
        {

        }

        private void autonumber()
        {

            long hitung;
            string urut;

            cn.Open();
            cm = new SqlCommand("select  id_transaksi from Transaksi where id_transaksi in (select max(id_transaksi)from Transaksi) order by id_transaksi DESC",cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                hitung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_transaksi"].ToString().Length - 12, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut ="Trx-"+joinstr.Substring(joinstr.Length-4,4)+"/"+DateTime.Now.ToString("MM/yyyy");
            }
            else
            {
                urut = "trx-0001/" + DateTime.Now.ToString("MM/yyyy");
            } 
            dr.Close();
            txtIdTransaksi.Text = urut;
            txtIdTransaksi.Enabled = false;

            cn.Close();
          
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void BtnCariPel_Click(object sender, EventArgs e)
        {
            //Pangil form cari pelanggan
            CariPelanggan frm = new CariPelanggan();
            frm.refresh_barang();
            frm.ShowDialog();
            txtKodePlg.Text = frm.getKodePlg;
            txtNamaPel.Text = frm.getNamaplg;


        }

        private void BtnCariBrg_Click(object sender, EventArgs e)
        {
            //Pangil from cari barang
            CariBarang frm = new CariBarang();
            frm.refreshBarang();
            frm.ShowDialog();
            txtKodeBar.Text = frm.getKodebrg;
            txtNamaBar.Text = frm.getNamabrg;
            txtHarga.Text = frm.getHargabrg;
        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==46)
            {

            }else if (e.KeyChar == 8)
            {

            }else if ((e.KeyChar<48)|| (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (txtNamaBar.Text.Trim() == "" || txtKodeBar.Text.Trim() == "" || txtHarga.Text.Trim() == "" || txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {

            }
        }
    }
}
