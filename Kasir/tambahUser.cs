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
    public partial class tambahUser : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmUser fuser = new frmUser();
        public tambahUser(frmUser frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fuser = frm;
            
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string key = ((KeyValuePair<string, string>)cmbLevel.SelectedItem).Key;
                string value = ((KeyValuePair<string, string>)cmbLevel.SelectedItem).Value;
                cn.Open();
                cm = new SqlCommand(" UPDATE Pengguna SET   nama ='"+txtNama.Text+"' , username ='"+txtUsername.Text+"' , role ='"+key+"' where id like '"+lblID.Text+"' ",cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Data Pengguna berhail diubah");
                fuser.loadUser();
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void LoadLevel()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("1", "Admin");
            comboSource.Add("2", "Kasir");
            cmbLevel.DataSource = new BindingSource(comboSource, null);
            cmbLevel.DisplayMember = "Value";
            cmbLevel.ValueMember = "Key";


        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {

            
            if (txtNama.Text.Trim()=="" || txtUsername.Text.Trim()=="" || txtPassword.Text.Trim()=="" || cmbLevel.Text.Trim()=="")
            {
                //Pesan data belum lengkap
                MessageBox.Show("Data belum lengkap,Lengkapi data", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                try
                {
                    string key = ((KeyValuePair<string, string>)cmbLevel.SelectedItem).Key;
                    string value = ((KeyValuePair<string, string>)cmbLevel.SelectedItem).Value;
                    cn.Open();
                    cm = new SqlCommand("insert into Pengguna  values ('" + txtNama.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "' ,'" +key + "') ", cn);
                    cm.ExecuteNonQuery();                  
                    fuser.loadUser();
                    MessageBox.Show("Data User berhasil disimpan");
                    this.Dispose();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Username sudah ada!, Silahkan coba lagi","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TambahUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbkasirDataSet9.User' table. You can move, or remove it, as needed.
           

          

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
