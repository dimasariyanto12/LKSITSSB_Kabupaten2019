
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
    public partial class Login : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            clear();
        }
        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void clear()
        {

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();

        }
        private void Login_Load(object sender, EventArgs e)
        {

            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin keluar dari program?","Konfirmasi!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
               
            }
           
        }

       
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }

      
        private void BtnLogin_Click(object sender, EventArgs e)
        {   
            //jika input kosong
            if (txtUsername.Text.Trim()=="" || txtPassword.Text.Trim()=="")
            {
                MessageBox.Show("Input tidak boleh kosong", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            cn.Open();
            SqlDataReader reader = null;
            cm = new SqlCommand("SELECT id, role,nama  FROM   Pengguna where  username='" + txtUsername.Text +"' AND  password='" + txtPassword.Text + "'", cn);

            cm.ExecuteNonQuery();
            reader = cm.ExecuteReader();
            if (reader.Read())
            {

                int role = reader.GetByte(1);
                int id = reader.GetInt32(0);


                    MessageBox.Show("Login berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                if ( role == 1)
                {
                    
                    frmMain frm = new frmMain();
                        //frm.lblid.Text = id.ToString();
                    frm.Show();

                    
                }
                else 
                {
                
                    frmKasir kasir = new frmKasir();
                    kasir.Show();
                   

                }
               


            }
            else
            {
                MessageBox.Show("Username atau Password Salah !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            cn.Close();
            }
        }
        //txtUsername.Text = reader.GetString(1);
        //        txtPassword.Text = reader.GetString(2);

       

        
    }
}
