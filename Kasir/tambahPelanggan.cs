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
    public partial class tambahPelanggan : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string title = "Pelanggan";
        frmPelanggan fpelanggan = new frmPelanggan();


        public tambahPelanggan(frmPelanggan frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fpelanggan = frm;
            
           
        }
        public void auto_number()
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
          
            txtKode.Enabled = false;
          
            txtKode.Text = urut;
            cn.Close();
        }


        public void Clear()
        {
          
            
            txtNama.Clear();
            txtPonsel.Clear();
            txtAlamat.Clear();
        }

        public bool Validasi()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtKode.Text))
            {
                ep.Clear();
                ep.SetError(txtKode, "Kode wajib di isi!");
            }
            else if (string.IsNullOrEmpty(txtNama.Text))
            {
                ep.Clear();
                ep.SetError(txtNama, "Nama Pelanggan wajib di isi!");
            }
            else if (cmbGender.SelectedIndex == -1)
            {
                ep.Clear();
                ep.SetError(cmbGender, "Pilih Jenis Kelamin");
            }else if (string.IsNullOrEmpty(txtPonsel.Text))
            {
                ep.Clear();
                ep.SetError(txtPonsel, "No HP wajib di isi!");
            }

            else if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                ep.Clear();
                ep.SetError(txtAlamat, "Alamat wajib di isi!");
            }
            else
            {
                ep.Clear();
                result = true;
            }
            return result;
        }
        

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            

          
        }
        private void BtnUbah_Click(object sender, EventArgs e)
        {

        }

        private void TambahPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbkasirDataSet1.Pelanggan' table. You can move, or remove it, as needed.
          

       


        }

        private void BtnUbah_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("update Pelanggan set kode='"+txtKode.Text+"', nama='"+txtNama.Text+"',gender='"+cmbGender.Text+"',ponsel='"+txtPonsel.Text+"',alamat='"+txtAlamat.Text+"' where id like '"+lblID.Text+"' ",cn);
                cm.ExecuteNonQuery();

                cn.Close();
                MessageBox.Show("Data Pelanggan berhasil diubah");
                this.Dispose();
                fpelanggan.loadPelanggan();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void id()
        {
            cn.Open();
            cm = new SqlCommand("select * from Pelanggan order by id DESC ", cn);
            SqlDataReader dr;
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {

             
            }
            cn.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSimpan_Click_1(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtPonsel.Text.Trim() == "" || txtAlamat.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, Lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO Pelanggan values ('" + txtKode.Text + "','" + txtNama.Text + "','" + cmbGender.Text + "','" + txtPonsel.Text + "','" + txtAlamat.Text + "')", cn);

                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Data Pelanggan berhasil disimpan!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                    fpelanggan.loadPelanggan();
                    this.Dispose();

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

        }

        private void CmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
