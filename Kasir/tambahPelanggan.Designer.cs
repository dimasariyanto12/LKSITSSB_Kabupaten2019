namespace Kasir
{
    partial class tambahPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tambahPelanggan));
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblJudul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPonsel = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbkasirDataSet1 = new Kasir.dbkasirDataSet1();
            this.pelangganTableAdapter = new Kasir.dbkasirDataSet1TableAdapters.PelangganTableAdapter();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Orange;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Location = new System.Drawing.Point(301, 356);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(106, 33);
            this.btnUbah.TabIndex = 40;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(413, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(301, 356);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(106, 33);
            this.btnSimpan.TabIndex = 38;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Alamat :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(24, 117);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(83, 23);
            this.lblNama.TabIndex = 32;
            this.lblNama.Text = "Nama :";
            this.lblNama.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(33, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 23);
            this.lblID.TabIndex = 31;
            this.lblID.Visible = false;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(126, 79);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(393, 32);
            this.txtKode.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Kode :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "No HP :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(179, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(205, 23);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Tambah Pelanggan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblJudul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 37);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(492, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(126, 118);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(393, 32);
            this.txtNama.TabIndex = 47;
            // 
            // txtPonsel
            // 
            this.txtPonsel.Location = new System.Drawing.Point(126, 198);
            this.txtPonsel.Name = "txtPonsel";
            this.txtPonsel.Size = new System.Drawing.Size(393, 32);
            this.txtPonsel.TabIndex = 48;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(126, 236);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(393, 91);
            this.txtAlamat.TabIndex = 49;
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.dbkasirDataSet1;
            // 
            // dbkasirDataSet1
            // 
            this.dbkasirDataSet1.DataSetName = "dbkasirDataSet1";
            this.dbkasirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // cmbGender
            // 
            this.cmbGender.DisplayMember = "1,0";
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cmbGender.Location = new System.Drawing.Point(126, 161);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(393, 31);
            this.cmbGender.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Jenis Kelamin :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tambahPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(536, 405);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtPonsel);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "tambahPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tambahPelanggan";
            this.Load += new System.EventHandler(this.TambahPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkasirDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblNama;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtKode;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtAlamat;
        public System.Windows.Forms.TextBox txtPonsel;
        public System.Windows.Forms.TextBox txtNama;
        private dbkasirDataSet1 dbkasirDataSet1;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private dbkasirDataSet1TableAdapters.PelangganTableAdapter pelangganTableAdapter;
        public System.Windows.Forms.ComboBox cmbGender;
        public System.Windows.Forms.Label label1;
    }
}