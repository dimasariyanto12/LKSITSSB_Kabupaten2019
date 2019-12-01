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
    public partial class CariBarang : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        DBConnection dbcon = new DBConnection();

        public string kodeBarang, namaBarang, harga = "";
        public CariBarang()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            refreshBarang();


        }

        public void refreshBarang()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Barang",cn);
                ds = new DataSet();
                da= new SqlDataAdapter(cm);
                da.Fill(ds, "Barang");
                dgvBarang.DataSource = ds;
                dgvBarang.DataMember = "Barang";
                dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBarang.AllowUserToAddRows = false;
                dgvBarang.Refresh();
                
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
        //9.Membuat function ambilKodeBrg
        public String getKodebrg
        {
            get
            {
                return kodeBarang;
            }
        }

        //10.Membuat function ambilNamabrg
        public String getNamabrg
        {
            get
            {
                return namaBarang;

            }
        }

        //11.Membuat function ambilHargaBrg
        public String getHargabrg
        {
            get
            {
                return harga;
            }
        }

        public void cariBarang()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from barang where kode like '%" + txtCari.Text + "%' OR nama like '%" + txtCari.Text + "%'  ", cn);
                ds = new DataSet();
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "Barang");
                dgvBarang.DataSource = ds;
                dgvBarang.DataMember = "Barang";
                dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBarang.AllowUserToAddRows = false;
                dgvBarang.Refresh();
               
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
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            cariBarang();
        }

        private void DgvBarang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                //menngisi variabel yang akan diparsing di dgv
                DataGridViewRow row = this.dgvBarang.Rows[e.RowIndex];
                //variabel akan diisi berdasarkan pilihan data grid
                kodeBarang = row.Cells["kode"].Value.ToString();
                namaBarang = row.Cells["nama"].Value.ToString();
                harga = row.Cells["harga_jual"].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void CariBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbkasirDataSet31.vw_Barang' table. You can move, or remove it, as needed.
            this.vw_BarangTableAdapter.Fill(this.dbkasirDataSet31.vw_Barang);

        }

        private void DgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            }
        }
    }

