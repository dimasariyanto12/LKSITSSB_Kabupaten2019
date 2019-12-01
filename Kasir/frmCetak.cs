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
    public partial class frmCetak : Form
    {
        public frmCetak()
        {
            InitializeComponent();
            lblTgl.Text=DateTime.Now.ToString();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCetak_Load(object sender, EventArgs e)
        {

        }

        private void LblKasir_Click(object sender, EventArgs e)
        {

        }
    }
}
