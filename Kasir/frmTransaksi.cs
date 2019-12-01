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
    public partial class frmTransaksi : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
    

        public frmTransaksi()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            lblDate.Text = DateTime.Now.ToLongDateString();
          
            this.KeyPreview = true;
            txtSearch.Enabled = false;
            txtNamaPlg.Enabled = false;
            btnCariBrg.Enabled = false;
            btnCariPlg.Enabled = false;
            
        }

        public void loadBarang()
        {
            try
            {
                int i = 0;
                dgvListBarang.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT cart.id, cart.kode_brg, Barang.nama, cart.kode_plg, Pelanggan.nama AS namaplg, cart.harga, cart.qty, cart.disc ,cart.qty*cart.harga AS Total FROM   cart INNER JOIN    Pelanggan ON cart.kode_plg = Pelanggan.kode INNER JOIN  Barang ON cart.kode_brg = Barang.kode where transno like '" + lblNoTrx.Text+"' ",cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvListBarang.Rows.Add(i,dr["id"].ToString(), dr["kode_brg"].ToString(), dr["nama"].ToString(), dr["namaPlg"].ToString(), dr["qty"].ToString(), dr["harga"].ToString(), dr["disc"].ToString(),dr["Total"].ToString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
     

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin keluar dari form Transaksi","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {

            }
        }
        public void clear()
        {
            txtNamaPlg.Enabled = true;
            btnCariPlg.Enabled = true;
            btnCariBrg.Enabled = true;
            btnAdd.Enabled = false;
            btnSimpan.Enabled = false;
            btnCancel.Enabled = false;
            txtSearch.Enabled = true;
            txtSearch.Focus();
        }
        private void BtnNewTrx_Click(object sender, EventArgs e)
        {
            GetTransNo();
            Baru();
        }
        public void Baru()
        {
           
            txtNamaPlg.Enabled = true;
            btnCariPlg.Enabled = true;
            btnCariBrg.Enabled = true; 
           
            btnAdd.Enabled = true;
            btnSimpan.Enabled = true;
            btnCancel.Enabled = true;
            txtSearch.Enabled = true;
            txtQty.Text = "1";
            txtSearch.Focus();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //Pangil form cari pelanggan
            CariBarang frm = new CariBarang();
            frm.refreshBarang();
            frm.ShowDialog();
            lblHarga.Text = frm.getHargabrg;
         
            txtSearch.Text = frm.getKodebrg;
        }
        private void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("select top 1 transno from cart where transno like '" + sdate + "%'order by transno desc ", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblNoTrx.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblNoTrx.Text = transno;
                    dr.Close();
                }
                cn.Close();
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TxtBarcode_TextChanged(object sender, EventArgs e)
        {
           
    }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin ingin keluar dari Form Transaksi?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {

            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    MessageBox.Show("Kode Barcode Belum diisi!");
                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("select * from Barang where kode like '%" + txtSearch.Text + "%' ", cn);
                    dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        frmQty frm = new frmQty(this);
                        frm.ShowDialog();
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
          
        }

        private void FrmTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {
           

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCariPlg_Click(object sender, EventArgs e)
        {
            //Pangil form cari pelanggan
            CariPelanggan frm = new CariPelanggan();
            frm.refresh_barang();
            frm.ShowDialog();
            lblkodePlg.Text = frm.getKodePlg;
            txtNamaPlg.Text = frm.getNamaplg;
        }

        private void BtnCariBrg_Click(object sender, EventArgs e)
        {
            //Pangil form cari pelanggan
            CariBarang frm = new CariBarang();
            frm.refreshBarang();
            frm.ShowDialog();
            lblHarga.Text = frm.getHargabrg;
            txtSearch.Text = frm.getKodebrg;
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
      
        
        public void simpanPenjualan()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO cart (transno, tgl, kode_brg, kode_plg, harga, qty) values (@transno, @tgl, @kode_brg, @kode_plg, @harga, @qty) ", cn);
                cm.Parameters.AddWithValue("@transno", lblNoTrx.Text);
                cm.Parameters.AddWithValue("@tgl", DateTime.Now);
                cm.Parameters.AddWithValue("@kode_brg", txtSearch.Text);
                cm.Parameters.AddWithValue("@kode_plg", lblkodePlg.Text);
                cm.Parameters.AddWithValue("@harga", lblHarga.Text);
                cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));

                cm.ExecuteNonQuery();

                cn.Close();
                txtNamaPlg.Enabled = false;
                txtSearch.Clear();
                Baru();

                loadBarang();


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
       
        private void Button17_Click_1(object sender, EventArgs e)
        {
            simpanPenjualan();
        }

        private void DgvListBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cn.Close();
            string colName = dgvListBarang.Columns[e.ColumnIndex].Name;
            if (colName=="tambah")
            {
                cn.Open();
                cm = new SqlCommand("update cart set qty=(qty+1)  where id ='" + dgvListBarang[1, e.RowIndex].Value.ToString() + "' AND kode_brg ='" + dgvListBarang[2, e.RowIndex].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
               
                cn.Close();
                loadBarang();
                
            }else if (colName == "kurang")
            {


                cn.Open();
                    cm = new SqlCommand("update cart  set qty=(qty-1) where id ='" +dgvListBarang[1,e.RowIndex].Value.ToString() + "' AND kode_brg ='" + dgvListBarang[2,e.RowIndex].Value.ToString() + "'", cn);                 
                    cm.ExecuteNonQuery();
                cn.Close();
                    loadBarang();                   

            }else if (colName == "hapus")
            {
                cn.Open();
                cm = new SqlCommand("delete from cart where id='" + dgvListBarang[1, e.RowIndex].Value.ToString() + "' AND kode_brg ='" + dgvListBarang[2, e.RowIndex].Value.ToString() + "' ", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                loadBarang();
            }
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
      
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                
                simpanPenjualan();
                loadBarang();
            }
        }
    }
    }
