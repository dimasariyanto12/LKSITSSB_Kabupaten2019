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
    public partial class frmPembelian : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();

        public frmPembelian()
        {
            InitializeComponent();
            autonumber();
        }

        public void autonumber()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyy/mm");
                string notrx;
                int count;
                cn.Open();
                cm = new SqlCommand("select top 1 no_transaksi from Pembelian where no_transaksi  like '" + sdate + "' order by no_transaksi desc ", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    notrx = dr[1].ToString();
                    count = int.Parse(notrx.Substring(8, 4));
                    lblNotrx.Text = sdate + (count + 1);

                }
                else
                {
                    notrx = sdate + "1001";
                    lblNotrx.Text = notrx;
                    dr.Close();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmPembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suplier._Suplier' table. You can move, or remove it, as needed.
            this.suplierTableAdapter.Fill(this.suplier._Suplier);

        }
    }
}
