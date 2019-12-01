namespace Kasir
{
    partial class frmPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_cetakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cetak = new Kasir.cetak();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rpvTransaksi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_cetakTableAdapter = new Kasir.cetakTableAdapters.vw_cetakTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_cetakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetak)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_cetakBindingSource
            // 
            this.vw_cetakBindingSource.DataMember = "vw_cetak";
            this.vw_cetakBindingSource.DataSource = this.cetak;
            // 
            // cetak
            // 
            this.cetak.DataSetName = "cetak";
            this.cetak.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 39);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1090, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // rpvTransaksi
            // 
            this.rpvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_cetakBindingSource;
            this.rpvTransaksi.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvTransaksi.LocalReport.ReportEmbeddedResource = "Kasir.cetakTransaksi.rdlc";
            this.rpvTransaksi.Location = new System.Drawing.Point(0, 39);
            this.rpvTransaksi.Name = "rpvTransaksi";
            this.rpvTransaksi.Size = new System.Drawing.Size(1132, 680);
            this.rpvTransaksi.TabIndex = 1;
            // 
            // vw_cetakTableAdapter
            // 
            this.vw_cetakTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 719);
            this.Controls.Add(this.rpvTransaksi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.FrmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_cetakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetak)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTransaksi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource vw_cetakBindingSource;
        private cetak cetak;
        private cetakTableAdapters.vw_cetakTableAdapter vw_cetakTableAdapter;
    }
}