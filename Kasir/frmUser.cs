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
    public partial class frmUser : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        DBConnection dbcon = new DBConnection();
       
        
        public frmUser()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            loadUser();

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            tambahUser frm = new tambahUser(this);
            frm.btnUbah.Visible = false;
            frm.LoadLevel();
            frm.ShowDialog();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbkasirDataSet28.vw_Pengguna' table. You can move, or remove it, as needed.
            this.vw_PenggunaTableAdapter.Fill(this.dbkasirDataSet28.vw_Pengguna);





            loadUser();

        }
        public void loadUser()
        {
            //int i = 0;
            //dgvUser.Rows.Clear();
            //cn.Open();
            //cm = new SqlCommand("select * from Pengguna ", cn);
            //dr = cm.ExecuteReader();
            //while (dr.Read())
            //{

            //    i += 1;
            //    dgvUser.Rows.Add( dr["id"].ToString(), dr["nama"].ToString(), dr["username"].ToString(), dr["password"].ToString(), dr["role"].ToString());
            //}
            //cn.Close();
            this.vw_PenggunaTableAdapter.Fill(this.dbkasirDataSet28.vw_Pengguna);
        }

        private void DgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvUser.Columns[e.ColumnIndex].Name;

            if (ColName == "Ubah")
            {
                tambahUser frm = new tambahUser(this);
                frm.LoadLevel();
                frm.lblID.Text = dgvUser[0, e.RowIndex].Value.ToString();
                frm.txtNama.Text = dgvUser[1, e.RowIndex].Value.ToString();
               
                frm.txtUsername.Text = dgvUser[2, e.RowIndex].Value.ToString();
                frm.cmbLevel.Text = dgvUser[5, e.RowIndex].Value.ToString();
                
                frm.btnSimpan.Visible = true;
                frm.txtPassword.ReadOnly = true;
                frm.lblJudul.Text = "Ubah Data User";
                frm.ShowDialog();
               
            }
            else if (ColName == "Hapus")
            {
                if (MessageBox.Show("Anda yakin ingin menghapus User '" + dgvUser[1, e.RowIndex].Value.ToString() + "' ", "Hapus User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from pengguna where id like '" + dgvUser[0, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data User " + dgvUser[2, e.RowIndex].Value.ToString() + " berhasil dihapus");
                    loadUser();
                }
            }
        
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * from vw_Pengguna where nama like '%" + txtCari.Text + "%' OR username like '%" + txtCari.Text + "%'", cn);
                ds = new DataSet();
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "vw_Pengguna");
                dgvUser.DataSource = ds;
                dgvUser.DataMember = "vw_Pengguna";
                dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUser.AllowUserToAddRows = false;
                dgvUser.Refresh();

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
