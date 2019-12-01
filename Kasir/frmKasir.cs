using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class frmKasir : Form
    {
        void nonaktifkan_menu()
        {
            //login - 2.menonaktifkan beberapa menu
       
        }

        public frmKasir()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            frmHome frm = new frmHome();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void FrmKasir_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login frm = new Login();
            frm.clear();
            frm.Show();
        }

     
    private void BtnBarang_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnBarang.Height;
            sidePanel.Top = btnBarang.Top;
            frmBarang frm = new frmBarang();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.loadBarang();
            //frm.btnTambah.Visible = false;
           
            frm.Show();
        }

        private void BtnTransaksi_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnTransaksi.Height;
            sidePanel.Top = btnTransaksi.Top;
            Transaksi frm = new Transaksi();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnPelanggan_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnPelanggan.Height;
            sidePanel.Top = btnPelanggan.Top;
            frmPelanggan frm = new frmPelanggan();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.loadPelanggan();
            frm.btnTambah.Visible = false;
           
            frm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apa Anda yakin keluar dari Program?","Konfirmasi Keluar",MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString()=="Yes")
            {
                this.Dispose();
                Login frm = new Login();
                frm.clear();
                frm.Show();
            }
            else
            {

            }
        }
    }
}
