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
    public partial class detailBarang : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DataTable dt = new DataTable();
        DBConnection dbcon = new DBConnection();
        frmBarang fbarang = new frmBarang();

        public detailBarang(frmBarang frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fbarang = frm;
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DetailBarang_Load(object sender, EventArgs e)
        {
            
        }

        public void loaaCMB()
        {
            // TODO: This line of code loads data into the 'dbkasirDataSet26.Suplier' table. You can move, or remove it, as needed.
            this.suplierTableAdapter.Fill(this.dbkasirDataSet26.Suplier);
            // TODO: This line of code loads data into the 'dbkasirDataSet25.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.dbkasirDataSet25.Kategori);

        }
        //Ubah Data
        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin mengubah Barang "+txtNama.Text+"","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("Update Barang set nama='"+txtNama.Text+"', stock='"+txtStock.Text+"', deskripsi='"+txtDeskripsi.Text+"', harga_jual='"+txtHrgJual.Text+"', harga_beli='"+txtHrgBeli.Text+"', kategori_id='"+cmbKategori.SelectedValue+"', suplier_id = '"+cmbSuplier.SelectedValue+"' where id like '"+lblID.Text+"' ", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Data Barang berhasil diubah ");
                    this.Dispose();
                    fbarang.loadBarang();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
       
        //Simpan Data
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (txtKode.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtDeskripsi.Text.Trim() == "" || txtStock.Text.Trim() == "" || cmbKategori.Text.Trim() == "" || cmbSuplier.Text.Trim() == "")
            {
                MessageBox.Show("Harap Lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                try
                {

                    //Geting Username of logged in user

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO Barang(kode, nama, stock, deskripsi, harga_jual, harga_beli,  kategori_id, suplier_id)VALUES(@kode, @nama, @stock, @deskripsi, @harga_jual, @harga_beli, @kategori_id, @suplier_id)", cn);
                    cm.Parameters.AddWithValue("@kode", txtKode.Text);
                    cm.Parameters.AddWithValue("@nama", txtNama.Text);
                    cm.Parameters.AddWithValue("@stock", txtStock.Text);
                    cm.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                    cm.Parameters.AddWithValue("@harga_jual", txtHrgJual.Text);
                    cm.Parameters.AddWithValue("@harga_beli", txtHrgBeli.Text);
             
                    cm.Parameters.AddWithValue("@kategori_id", cmbKategori.SelectedValue);
                    cm.Parameters.AddWithValue("@suplier_id", cmbSuplier.SelectedValue);


                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Barang berhasil disimpan");
                    this.Dispose();
                    fbarang.loadBarang();
                   
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    //MessageBox.Show("Gagal disimpan,Data barang sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==46)
            {
                //accept character
            }else if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar<48) || (e.KeyChar>57))
            {
                e.Handled = true;
            }
        }
    }
}
