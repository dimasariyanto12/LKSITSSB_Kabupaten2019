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
    public partial class frmKategori : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        DBConnection dbcon = new DBConnection();
        
        public frmKategori()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void FrmKategori_Load(object sender, EventArgs e)
        {
         
            this.kategoriTableAdapter.Fill(this.dbkasirDataSet.Kategori);
            
           

        }

        public void LoadKategori()
        {
            this.kategoriTableAdapter.Fill(this.dbkasirDataSet.Kategori);

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tambahKategori frm = new tambahKategori(this);
            
            frm.ShowDialog();
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvKategori.Columns[e.ColumnIndex].Name;
            if (ColName=="Ubah")
            {
                tambahKategori frm = new tambahKategori(this);
                frm.lblID.Text = dgvKategori[0  , e.RowIndex].Value.ToString();
                frm.txtKategori.Text = dgvKategori[1, e.RowIndex].Value.ToString();
                frm.lbljudul.Text = "Ubah Kategori";
                frm.btnSimpan.Visible = false;

                frm.ShowDialog();
            }
           else if (ColName == "Hapus")
            {
                if (MessageBox.Show("Anda yakin ingin menghapus kategori " + dgvKategori[1, e.RowIndex].Value.ToString() + "??", "",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from Kategori where id like'" + dgvKategori[0, e.RowIndex].Value.ToString() + "' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Kategori " + dgvKategori[1, e.RowIndex].Value.ToString() + " berhasil dihapus ");
                    LoadKategori();

                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnTambah_Click_1(object sender, EventArgs e)
        {
            if (txtKategori.Text.Trim() == "")
            {
                MessageBox.Show("Data Kategori belum diisi","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {


                try
                {

                    cn.Open();
                    cm = new SqlCommand("insert into Kategori (kategori) values (@kategori)", cn);
                    cm.Parameters.AddWithValue("@kategori", txtKategori.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Kategori Berhasil disimpan", "Sukses");
                    txtKategori.Text = "";
                    LoadKategori();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Kategori gagal disimpan, Kategori sudah tersedia","Peringatan!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kategoriTableAdapter.FillBy(this.dbkasirDataSet.Kategori);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * from Kategori where kategori like '%"+txtCari.Text+"%' ",cn);
                ds = new DataSet();
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "Kategori");
                dgvKategori.DataSource = ds;
                dgvKategori.DataMember = "Kategori";
                dgvKategori.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
                dgvKategori.AllowUserToAddRows = false;
                dgvKategori.Refresh();

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
