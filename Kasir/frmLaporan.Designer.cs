namespace Kasir
{
    partial class frmLaporan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.view_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbkasirDataSet29 = new Kasir.dbkasirDataSet29();
            this.vw_laporanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporanPenjualan = new Kasir.laporanPenjualan();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Barang = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_barangTableAdapter = new Kasir.dbkasirDataSet29TableAdapters.view_barangTableAdapter();
            this.vw_laporanTableAdapter = new Kasir.laporanPenjualanTableAdapters.vw_laporanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_laporanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPenjualan)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // view_barangBindingSource
            // 
            this.view_barangBindingSource.DataMember = "view_barang";
            this.view_barangBindingSource.DataSource = this.dbkasirDataSet29;
            // 
            // dbkasirDataSet29
            // 
            this.dbkasirDataSet29.DataSetName = "dbkasirDataSet29";
            this.dbkasirDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_laporanBindingSource
            // 
            this.vw_laporanBindingSource.DataMember = "vw_laporan";
            this.vw_laporanBindingSource.DataSource = this.laporanPenjualan;
            // 
            // laporanPenjualan
            // 
            this.laporanPenjualan.DataSetName = "laporanPenjualan";
            this.laporanPenjualan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Barang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 52);
            this.panel2.TabIndex = 10;
            // 
            // Barang
            // 
            this.Barang.AutoSize = true;
            this.Barang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barang.Location = new System.Drawing.Point(46, 9);
            this.Barang.Name = "Barang";
            this.Barang.Size = new System.Drawing.Size(110, 30);
            this.Barang.TabIndex = 1;
            this.Barang.Text = "Laporan";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 617);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Laporan Barang";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_barangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kasir.laporanBarnag.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(921, 575);
            this.reportViewer1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Laporan Penjualan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "laporanPenjualan";
            reportDataSource2.Value = this.vw_laporanBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Kasir.Laporan Penjualan.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(921, 575);
            this.reportViewer2.TabIndex = 0;
            // 
            // view_barangTableAdapter
            // 
            this.view_barangTableAdapter.ClearBeforeFill = true;
            // 
            // vw_laporanTableAdapter
            // 
            this.vw_laporanTableAdapter.ClearBeforeFill = true;
            // 
            // frmLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 667);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_laporanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPenjualan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Barang;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_barangBindingSource;
        private dbkasirDataSet29 dbkasirDataSet29;
        private System.Windows.Forms.TabPage tabPage2;
        private dbkasirDataSet29TableAdapters.view_barangTableAdapter view_barangTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource vw_laporanBindingSource;
        private laporanPenjualan laporanPenjualan;
        private laporanPenjualanTableAdapters.vw_laporanTableAdapter vw_laporanTableAdapter;
    }
}