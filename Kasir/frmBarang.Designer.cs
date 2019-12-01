namespace Kasir
{
    partial class frmBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTambah = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.Barang = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.vwBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbkasirDataSet23 = new Kasir.dbkasirDataSet23();
            this.vw_BarangTableAdapter = new Kasir.dbkasirDataSet23TableAdapters.vw_BarangTableAdapter();
            this.viewbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbkasirDataSet27 = new Kasir.dbkasirDataSet27();
            this.view_barangTableAdapter = new Kasir.dbkasirDataSet27TableAdapters.view_barangTableAdapter();
            this.dbkasirDataSet29 = new Kasir.dbkasirDataSet29();
            this.viewbarangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_barangTableAdapter1 = new Kasir.dbkasirDataSet29TableAdapters.view_barangTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ubah = new System.Windows.Forms.DataGridViewImageColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewbarangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SpringGreen;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Location = new System.Drawing.Point(18, 58);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(135, 33);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCari);
            this.panel2.Controls.Add(this.Barang);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 52);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cari :";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(569, 15);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(304, 32);
            this.txtCari.TabIndex = 12;
            this.txtCari.TextChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // Barang
            // 
            this.Barang.AutoSize = true;
            this.Barang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barang.Location = new System.Drawing.Point(58, 12);
            this.Barang.Name = "Barang";
            this.Barang.Size = new System.Drawing.Size(97, 30);
            this.Barang.TabIndex = 1;
            this.Barang.Text = "Barang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.AutoGenerateColumns = false;
            this.dgvBarang.BackgroundColor = System.Drawing.Color.White;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodeDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.hargajualDataGridViewTextBoxColumn,
            this.hargabeliDataGridViewTextBoxColumn,
            this.kategori,
            this.suplier,
            this.detail,
            this.Ubah,
            this.Hapus});
            this.dgvBarang.DataSource = this.viewbarangBindingSource1;
            this.dgvBarang.Location = new System.Drawing.Point(12, 97);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarang.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarang.RowHeadersVisible = false;
            this.dgvBarang.RowHeadersWidth = 62;
            this.dgvBarang.RowTemplate.Height = 28;
            this.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarang.Size = new System.Drawing.Size(861, 551);
            this.dgvBarang.TabIndex = 8;
            this.dgvBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKategori_CellContentClick);
            // 
            // vwBarangBindingSource
            // 
            this.vwBarangBindingSource.DataMember = "vw_Barang";
            this.vwBarangBindingSource.DataSource = this.dbkasirDataSet23;
            // 
            // dbkasirDataSet23
            // 
            this.dbkasirDataSet23.DataSetName = "dbkasirDataSet23";
            this.dbkasirDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_BarangTableAdapter
            // 
            this.vw_BarangTableAdapter.ClearBeforeFill = true;
            // 
            // viewbarangBindingSource
            // 
            this.viewbarangBindingSource.DataMember = "view_barang";
            this.viewbarangBindingSource.DataSource = this.dbkasirDataSet27;
            // 
            // dbkasirDataSet27
            // 
            this.dbkasirDataSet27.DataSetName = "dbkasirDataSet27";
            this.dbkasirDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_barangTableAdapter
            // 
            this.view_barangTableAdapter.ClearBeforeFill = true;
            // 
            // dbkasirDataSet29
            // 
            this.dbkasirDataSet29.DataSetName = "dbkasirDataSet29";
            this.dbkasirDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewbarangBindingSource1
            // 
            this.viewbarangBindingSource1.DataMember = "view_barang";
            this.viewbarangBindingSource1.DataSource = this.dbkasirDataSet29;
            // 
            // view_barangTableAdapter1
            // 
            this.view_barangTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // kodeDataGridViewTextBoxColumn
            // 
            this.kodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodeDataGridViewTextBoxColumn.DataPropertyName = "kode";
            this.kodeDataGridViewTextBoxColumn.HeaderText = "Kode";
            this.kodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeDataGridViewTextBoxColumn.Name = "kodeDataGridViewTextBoxColumn";
            this.kodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 86;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.ReadOnly = true;
            this.deskripsiDataGridViewTextBoxColumn.Visible = false;
            this.deskripsiDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargajualDataGridViewTextBoxColumn
            // 
            this.hargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual";
            this.hargajualDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargajualDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargajualDataGridViewTextBoxColumn.Name = "hargajualDataGridViewTextBoxColumn";
            this.hargajualDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargajualDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargabeliDataGridViewTextBoxColumn
            // 
            this.hargabeliDataGridViewTextBoxColumn.DataPropertyName = "harga_beli";
            this.hargabeliDataGridViewTextBoxColumn.HeaderText = "harga_beli";
            this.hargabeliDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargabeliDataGridViewTextBoxColumn.Name = "hargabeliDataGridViewTextBoxColumn";
            this.hargabeliDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargabeliDataGridViewTextBoxColumn.Visible = false;
            this.hargabeliDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategori
            // 
            this.kategori.DataPropertyName = "kategori";
            this.kategori.HeaderText = "kategori";
            this.kategori.MinimumWidth = 8;
            this.kategori.Name = "kategori";
            this.kategori.ReadOnly = true;
            this.kategori.Visible = false;
            this.kategori.Width = 150;
            // 
            // suplier
            // 
            this.suplier.DataPropertyName = "suplier";
            this.suplier.HeaderText = "suplier";
            this.suplier.MinimumWidth = 8;
            this.suplier.Name = "suplier";
            this.suplier.ReadOnly = true;
            this.suplier.Visible = false;
            this.suplier.Width = 150;
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "";
            this.detail.Image = ((System.Drawing.Image)(resources.GetObject("detail.Image")));
            this.detail.MinimumWidth = 8;
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Width = 8;
            // 
            // Ubah
            // 
            this.Ubah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ubah.DataPropertyName = "Ubah";
            this.Ubah.FillWeight = 272.7273F;
            this.Ubah.HeaderText = "";
            this.Ubah.Image = ((System.Drawing.Image)(resources.GetObject("Ubah.Image")));
            this.Ubah.MinimumWidth = 8;
            this.Ubah.Name = "Ubah";
            this.Ubah.ReadOnly = true;
            this.Ubah.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ubah.Visible = false;
            this.Ubah.Width = 8;
            // 
            // Hapus
            // 
            this.Hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Hapus.DataPropertyName = "Hapus";
            this.Hapus.FillWeight = 13.63637F;
            this.Hapus.HeaderText = "";
            this.Hapus.Image = ((System.Drawing.Image)(resources.GetObject("Hapus.Image")));
            this.Hapus.MinimumWidth = 8;
            this.Hapus.Name = "Hapus";
            this.Hapus.ReadOnly = true;
            this.Hapus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hapus.Width = 8;
            // 
            // frmBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 660);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvBarang);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBarang";
            this.Load += new System.EventHandler(this.FrmBarang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewbarangBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Barang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCari;
        private dbkasirDataSet23 dbkasirDataSet23;
        private System.Windows.Forms.BindingSource vwBarangBindingSource;
        private dbkasirDataSet23TableAdapters.vw_BarangTableAdapter vw_BarangTableAdapter;
        private dbkasirDataSet27 dbkasirDataSet27;
        private System.Windows.Forms.BindingSource viewbarangBindingSource;
        private dbkasirDataSet27TableAdapters.view_barangTableAdapter view_barangTableAdapter;
        private dbkasirDataSet29 dbkasirDataSet29;
        private System.Windows.Forms.BindingSource viewbarangBindingSource1;
        private dbkasirDataSet29TableAdapters.view_barangTableAdapter view_barangTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplier;
        private System.Windows.Forms.DataGridViewImageColumn detail;
        private System.Windows.Forms.DataGridViewImageColumn Ubah;
        private System.Windows.Forms.DataGridViewImageColumn Hapus;
    }
}