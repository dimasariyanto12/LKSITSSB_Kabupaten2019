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
    public partial class tambahKategori : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmKategori frmlkategori = new frmKategori();
        string stitle = "Kategori";
        public tambahKategori(frmKategori frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlkategori = frm;
        }

        public void Clear()
        {
            btnSimpan.Enabled = true;
            txtKategori.Clear();
            txtKategori.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
           
            if ( txtKategori.Text == string.Empty)
            {
                MessageBox.Show("Kategori wajib di isi!!", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        MessageBox.Show("Kategori Berhasil disimpan", stitle);
                        Clear();
                        frmlkategori.LoadKategori();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
              try
                {
                    if (MessageBox.Show("Anda yakin ingin Mengubah kategori ini??", "Ubah Kategori", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    {
                        cn.Open();
                        cm = new SqlCommand("update Kategori set kategori=@kategori where id like '"+lblID.Text+"' ", cn);
                        cm.Parameters.AddWithValue("@kategori", txtKategori.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Kategori Berhasil diubah", stitle);
                        Clear();
                    this.Dispose();
                        frmlkategori.LoadKategori();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
        }

        private void TambahKategori_Load(object sender, EventArgs e)
        {

        }
    }
}
