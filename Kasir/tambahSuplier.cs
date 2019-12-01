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
    public partial class tambahSuplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        frmSupplier flsuplier = new frmSupplier();
        public tambahSuplier(frmSupplier frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flsuplier = frm;

        }

        public void Clear()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtPonsel.Text = "";
            txtNama.Focus();
        }
        void  validasi()
        {
            txtNama.Text = string.Empty;
            txtAlamat.Text = string.Empty;
            txtPonsel.Text = string.Empty;
        }

        private void TambahSuplier_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim()=="" || txtAlamat.Text.Trim()=="" || txtPonsel.Text.Trim()=="")
            {
                MessageBox.Show("Data belum lengkap, Lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {

                    cn.Open();
                    cm = new SqlCommand("insert into Suplier  values ('" + txtNama.Text + "','" + txtPonsel.Text + "','" + txtAlamat.Text + "')", cn);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Suplier Berhasil disimpan");
                    Clear();
                    flsuplier.Load_Supplier();
                    this.Dispose();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
        }
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin mengubah data suplier " + txtNama.Text + "", "Suplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try
                {
                    cn.Open();
                    cm = new SqlCommand("Update Suplier set Nama='" + txtNama.Text + "', Ponsel='" + txtPonsel.Text + "',Alamat='" + txtAlamat.Text + "' where id like '" + lblID.Text + "' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Suplier " + txtNama.Text + " berhasi diubah ");
                    flsuplier.Load_Supplier();
                    this.Dispose();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
