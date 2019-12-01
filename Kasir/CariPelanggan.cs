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
    public partial class CariPelanggan : Form
    {
        //0.KONEKSI
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;

        DBConnection dbcon = new DBConnection();
        //0.1 
        public string kodeplg, namaplg = "";

        //1.prosuder refresh barang
        public void refresh_barang()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Pelanggan", cn);
                ds = new DataSet();
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "Pelanggan");
                dgvPelanggan.DataSource = ds;
                dgvPelanggan.DataMember = "Pelanggan";
                dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPelanggan.AllowUserToAddRows = false;
                dgvPelanggan.Refresh();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        //2.Prosudur Cari barang
        public void cariPelanggan()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Pelanggan where kode like '%"+txtCari.Text+"%' OR nama like '%"+txtCari.Text+"%'  ",cn);
                ds = new DataSet();
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "Pelanggan");
                dgvPelanggan.DataSource = ds;
                dgvPelanggan.DataMember = "Pelanggan";
                dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPelanggan.AllowUserToAddRows = false;
                dgvPelanggan.Refresh();

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public CariPelanggan()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            //3.Panggil prosuder cari Pelanggan
            cariPelanggan();
        }
        //5.ambil kodeplg
        public String getKodePlg
        {
            get
            {
                return kodeplg;
            }
        }
        //6.ambil nama plg
        public String getNamaplg
        {
            get
            {
                return namaplg;
            }
        }
        private void DgvPelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {       //4.
            try
            {
                DataGridViewRow row = this.dgvPelanggan.Rows[e.RowIndex];
                //variabel akan disi dari pilihan dari datagrid
                kodeplg = row.Cells["kode"].Value.ToString();
                namaplg = row.Cells["nama"].Value.ToString();
                this.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
