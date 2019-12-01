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
    public partial class frmBarang : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        DBConnection dbcon = new DBConnection();

        public frmBarang()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            loadBarang();
        }

        public void loadBarang()
        {
            this.view_barangTableAdapter1.Fill(this.dbkasirDataSet29.view_barang);

        }


        private void BtnTambah_Click(object sender, EventArgs e)
        {
            detailBarang frm = new detailBarang(this);
            frm.btnUbah.Visible = false;
            frm.lblJudul.Text = "Tambah Data Barang";
            frm.loaaCMB();
            frm.txtHrgBeli.Text = "0";
            frm.txtHrgJual.Text = "0";
            frm.txtKode.Focus();
            frm.ShowDialog();
        }

        private void DgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBarang.Columns[e.ColumnIndex].Name;
            if (colName=="detail")
            {
                detailBarang frm = new detailBarang(this);
               
                frm.lblID.Text = dgvBarang[0, e.RowIndex].Value.ToString();
                frm.txtKode.Text = dgvBarang[1, e.RowIndex].Value.ToString();
                frm.txtNama.Text = dgvBarang[2, e.RowIndex].Value.ToString();
                frm.txtStock.Text = dgvBarang[3, e.RowIndex].Value.ToString();
                frm.txtDeskripsi.Text = dgvBarang[4, e.RowIndex].Value.ToString();
                frm.txtHrgBeli.Text = dgvBarang[6, e.RowIndex].Value.ToString();
                frm.txtHrgJual.Text = dgvBarang[5, e.RowIndex].Value.ToString();
           
                frm.loaaCMB();
                frm.cmbKategori.Text = dgvBarang[7, e.RowIndex].Value.ToString();
                frm.cmbSuplier.Text = dgvBarang[8, e.RowIndex].Value.ToString();

               
                frm.btnUbah.Visible = true;
                frm.btnSimpan.Visible = false;
               
                frm.Show();
            }else if (colName=="Hapus")
            {
                if (MessageBox.Show("Anda yakin ingin menghapus data Barang " + dgvBarang[2, e.RowIndex].Value.ToString() + " ", "Hapus Barang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult) ;
                {
                    cn.Open();
                    cm = new SqlCommand("delete from Barang where id like '" + dgvBarang[0, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Close();
                    MessageBox.Show("Barang " + dgvBarang[2, e.RowIndex].Value.ToString() + " berhasil dihapus ");
                }
            }
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from view_barang where  nama like '%" + txtCari.Text + "%' OR kode like '%"+txtCari.Text+"%' ", cn);
                ds = new DataSet();
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "Viewbarang");
                dgvBarang.DataSource = ds;
                dgvBarang.DataMember = "Viewbarang";
                dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBarang.AllowUserToAddRows = false;
                dgvBarang.Refresh();

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbkasirDataSet29.view_barang' table. You can move, or remove it, as needed.
            this.view_barangTableAdapter1.Fill(this.dbkasirDataSet29.view_barang);
 
          

        }
    }
}
