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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmHome frm = new frmHome();
            sidePanel.Height = btnHome.Height;
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Show();
            
            
            
        }

      public void Clear()
        {
           
          
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            
            frmHome frm = new frmHome();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            frm.TopLevel = false;
            
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            sidePanel.Height = btnKategri.Height;
            sidePanel.Top = btnKategri.Top;
            frmKategori frm = new frmKategori();           
            frm.TopLevel = false;
           
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnPelanggan.Height;
            sidePanel.Top = btnPelanggan.Top;
            frmPelanggan frm = new frmPelanggan();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
           
            frm.BringToFront();
            frm.Show();
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSupplier.Height;
            sidePanel.Top = btnSupplier.Top;
            frmSupplier frm = new frmSupplier();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Load_Supplier();
            frm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnUser.Height;
            sidePanel.Top = btnUser.Top;
            frmUser frm = new frmUser();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnBarang.Height;
            sidePanel.Top = btnBarang.Top;
            frmBarang frm = new frmBarang();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnTransaksi_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnTransaksi.Height;
            sidePanel.Top = btnTransaksi.Top;
            frmTransaksi frm = new frmTransaksi();
            
            frm.ShowDialog();
            
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }
    }
}
