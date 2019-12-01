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
    public partial class frmSupplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        DBConnection dbcon = new DBConnection();
        

        public frmSupplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbkasirDataSet8.Suplier' table. You can move, or remove it, as needed.
            this.suplierTableAdapter.Fill(this.dbkasirDataSet8.Suplier);
            
          
          

        }

        public void Load_Supplier()
        {
            this.suplierTableAdapter.Fill(this.dbkasirDataSet8.Suplier);
        }

        private void SuplierBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            tambahSuplier frm = new tambahSuplier(this);
            frm.btnUbah.Visible = false;
            frm.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSuplier.Columns[e.ColumnIndex].Name;
            if (colName == "Ubah")
            {
                tambahSuplier frm = new tambahSuplier(this);
                frm.lblID.Text = dgvSuplier[0, e.RowIndex].Value.ToString();
                frm.txtNama.Text = dgvSuplier[1, e.RowIndex].Value.ToString();
                frm.txtPonsel.Text = dgvSuplier[2, e.RowIndex].Value.ToString();
                frm.txtAlamat.Text = dgvSuplier[3, e.RowIndex].Value.ToString();
                frm.lbljudul.Text = "Ubah Data Suplier";
                frm.btnSimpan.Visible = false;
                frm.ShowDialog();


            } else if (colName=="Hapus")
            {
                if (MessageBox.Show("Anda yakin ingin menghapus suplier ini?", "Hapus Suplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from Suplier where id like '" + dgvSuplier[0, e.RowIndex].Value.ToString() + "' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Suplier berhasil dihapus");
                    Load_Supplier();

                }
            }

            
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * from Suplier where nama like '%" + txtCari.Text + "%'", cn);
                ds = new DataSet();
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "Suplier");
                dgvSuplier.DataSource = ds;
                dgvSuplier.DataMember = "Suplier";
                dgvSuplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSuplier.AllowUserToAddRows = false;
                dgvSuplier.Refresh();

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
