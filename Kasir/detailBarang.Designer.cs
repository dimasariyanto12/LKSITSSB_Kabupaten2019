namespace Kasir
{
    partial class detailBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailBarang));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbkasirDataSet25 = new Kasir.dbkasirDataSet25();
            this.suplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbkasirDataSet26 = new Kasir.dbkasirDataSet26();
            this.kategoriTableAdapter = new Kasir.dbkasirDataSet25TableAdapters.KategoriTableAdapter();
            this.suplierTableAdapter = new Kasir.dbkasirDataSet26TableAdapters.SuplierTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHrgJual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHrgBeli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSuplier = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet26)).BeginInit();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblJudul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 47);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(934, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJudul.Location = new System.Drawing.Point(444, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(164, 28);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Ubah Barang";
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "Kategori";
            this.kategoriBindingSource.DataSource = this.dbkasirDataSet25;
            // 
            // dbkasirDataSet25
            // 
            this.dbkasirDataSet25.DataSetName = "dbkasirDataSet25";
            this.dbkasirDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suplierBindingSource
            // 
            this.suplierBindingSource.DataMember = "Suplier";
            this.suplierBindingSource.DataSource = this.dbkasirDataSet26;
            // 
            // dbkasirDataSet26
            // 
            this.dbkasirDataSet26.DataSetName = "dbkasirDataSet26";
            this.dbkasirDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // suplierTableAdapter
            // 
            this.suplierTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kode Barang ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nama";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Deskripsi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Stock";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(156, 49);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(303, 32);
            this.txtKode.TabIndex = 18;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(662, 49);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(237, 32);
            this.txtStock.TabIndex = 19;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(156, 87);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(303, 32);
            this.txtNama.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Harga Jual";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHrgJual
            // 
            this.txtHrgJual.Location = new System.Drawing.Point(662, 128);
            this.txtHrgJual.Name = "txtHrgJual";
            this.txtHrgJual.Size = new System.Drawing.Size(237, 32);
            this.txtHrgJual.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Harga Beli";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHrgBeli
            // 
            this.txtHrgBeli.Location = new System.Drawing.Point(662, 90);
            this.txtHrgBeli.Name = "txtHrgBeli";
            this.txtHrgBeli.Size = new System.Drawing.Size(237, 32);
            this.txtHrgBeli.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kategori";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Suplier";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(152, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 23);
            this.lblID.TabIndex = 31;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblID.Visible = false;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Orange;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Location = new System.Drawing.Point(768, 280);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(131, 43);
            this.btnUbah.TabIndex = 33;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(623, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 23);
            this.label12.TabIndex = 35;
            this.label12.Text = "Rp.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(623, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 23);
            this.label13.TabIndex = 36;
            this.label13.Text = "Rp.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbSuplier
            // 
            this.cmbSuplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suplierBindingSource, "id", true));
            this.cmbSuplier.DataSource = this.suplierBindingSource;
            this.cmbSuplier.DisplayMember = "nama";
            this.cmbSuplier.FormattingEnabled = true;
            this.cmbSuplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSuplier.Location = new System.Drawing.Point(627, 203);
            this.cmbSuplier.Name = "cmbSuplier";
            this.cmbSuplier.Size = new System.Drawing.Size(272, 31);
            this.cmbSuplier.TabIndex = 37;
            this.cmbSuplier.ValueMember = "id";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kategoriBindingSource, "id", true));
            this.cmbKategori.DataSource = this.kategoriBindingSource;
            this.cmbKategori.DisplayMember = "kategori";
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(627, 166);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(272, 31);
            this.cmbKategori.TabIndex = 38;
            this.cmbKategori.ValueMember = "id";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(768, 280);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(131, 43);
            this.btnSimpan.TabIndex = 39;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(156, 128);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(303, 105);
            this.txtDeskripsi.TabIndex = 40;
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.White;
            this.gb.Controls.Add(this.txtDeskripsi);
            this.gb.Controls.Add(this.btnSimpan);
            this.gb.Controls.Add(this.cmbKategori);
            this.gb.Controls.Add(this.cmbSuplier);
            this.gb.Controls.Add(this.label13);
            this.gb.Controls.Add(this.label12);
            this.gb.Controls.Add(this.btnUbah);
            this.gb.Controls.Add(this.lblID);
            this.gb.Controls.Add(this.label10);
            this.gb.Controls.Add(this.label7);
            this.gb.Controls.Add(this.txtHrgBeli);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.txtHrgJual);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.txtNama);
            this.gb.Controls.Add(this.txtStock);
            this.gb.Controls.Add(this.txtKode);
            this.gb.Controls.Add(this.label9);
            this.gb.Controls.Add(this.label8);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.label2);
            this.gb.Location = new System.Drawing.Point(21, 63);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(957, 367);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = ".::.";
            // 
            // detailBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(997, 457);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "detailBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detailBarang";
            this.Load += new System.EventHandler(this.DetailBarang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet26)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbkasirDataSet25 dbkasirDataSet25;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private dbkasirDataSet25TableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private dbkasirDataSet26 dbkasirDataSet26;
        private System.Windows.Forms.BindingSource suplierBindingSource;
        private dbkasirDataSet26TableAdapters.SuplierTableAdapter suplierTableAdapter;
        public System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox gb;
        public System.Windows.Forms.TextBox txtDeskripsi;
        public System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.ComboBox cmbKategori;
        public System.Windows.Forms.ComboBox cmbSuplier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtHrgBeli;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtHrgJual;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNama;
        public System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}