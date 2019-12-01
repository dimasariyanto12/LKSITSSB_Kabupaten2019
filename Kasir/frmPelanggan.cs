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
    

    public partial class frmPelanggan : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        DBConnection dbcon = new DBConnection();
        string title = "pelanggan";

      
        public frmPelanggan()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
           
        }
        public void autonumber()
        {
            long hitung;
            string urut;
          
            cn.Open();
            cm = new SqlCommand("select kode from Pelanggan where kode in(select max (kode) from Pelanggan) order by kode DESC ", cn);
            SqlDataReader dr;
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {

                hitung = Convert.ToInt64(dr[0].ToString().Substring(dr["kode"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "P0001";
            }
            dr.Close();
            tambahPelanggan frm = new tambahPelanggan(this);
            frm.txtKode.Enabled = false;
            frm.txtKode.Text = urut;
            cn.Close();
        }

       
        public void loadPelanggan()
        {


            this.pelangganTableAdapter.Fill(this.dbkasirDataSet22.Pelanggan);

        }


        private void DgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvPelanggan.Columns[e.ColumnIndex].Name;
            if (ColName == "ubah")
            {
                tambahPelanggan frm = new tambahPelanggan(this);
              
                frm.lblID.Text = dgvPelanggan[0, e.RowIndex].Value.ToString();             
                frm.txtKode.Text = dgvPelanggan[1, e.RowIndex].Value.ToString();
                frm.txtNama.Text = dgvPelanggan[2, e.RowIndex].Value.ToString();
                frm.cmbGender.Text = dgvPelanggan[3, e.RowIndex].Value.ToString();
                frm.txtPonsel.Text = dgvPelanggan[4, e.RowIndex].Value.ToString();
                frm.txtAlamat.Text = dgvPelanggan[5, e.RowIndex].Value.ToString();
                frm.btnSimpan.Visible = false;
                frm.txtKode.ReadOnly = true;
                frm.lblJudul.Text = "Ubah Data Pelanggan";
               
                frm.ShowDialog();

            }
            else if(MessageBox.Show("Anda yakin ingin menghapus data pelanggan ini?","Hapus Pelanggan",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("delete from Pelanggan where id like '" + dgvPelanggan[0, e.RowIndex].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Data Pelanggan berhasil dihapus");
                loadPelanggan();
             
                
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            tambahPelanggan frm = new tambahPelanggan(this);
            frm.btnUbah.Visible = false;
            frm.id();
            frm.auto_number();
            frm.ShowDialog();
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * from Pelanggan where nama like '%" + txtCari.Text + "%' OR kode like '%"+txtCari.Text+"%'", cn);
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
        }

        private void FrmPelanggan_Load(object sender, EventArgs e)
        {
          
            this.pelangganTableAdapter.Fill(this.dbkasirDataSet22.Pelanggan);
        

        }
    }
}
