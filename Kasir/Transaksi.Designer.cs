namespace Kasir
{
    partial class Transaksi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtIdTransaksi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKodePlg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaPel = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKurang = new System.Windows.Forms.Button();
            this.txtKodeBar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtNamaBar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnCariBrg = new System.Windows.Forms.Button();
            this.btnCariPel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(666, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 93);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(87, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 48);
            this.label10.TabIndex = 1;
            this.label10.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rp.";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTanggal);
            this.groupBox1.Controls.Add(this.txtIdTransaksi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "::Form Transaksi Penjualan::";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(161, 73);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(246, 32);
            this.dtpTanggal.TabIndex = 3;
            this.dtpTanggal.Value = new System.DateTime(2019, 8, 18, 0, 0, 0, 0);
            // 
            // txtIdTransaksi
            // 
            this.txtIdTransaksi.Location = new System.Drawing.Point(161, 35);
            this.txtIdTransaksi.Name = "txtIdTransaksi";
            this.txtIdTransaksi.Size = new System.Drawing.Size(246, 32);
            this.txtIdTransaksi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tanggal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "No Kwitansi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1128, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 741);
            this.panel3.TabIndex = 3;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTransaksi);
            this.groupBox2.Location = new System.Drawing.Point(482, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 449);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "..::Data Barang::..";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaksi.Location = new System.Drawing.Point(3, 28);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 62;
            this.dgvTransaksi.RowTemplate.Height = 28;
            this.dgvTransaksi.Size = new System.Drawing.Size(613, 418);
            this.dgvTransaksi.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCariPel);
            this.groupBox3.Controls.Add(this.txtKodePlg);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNamaPel);
            this.groupBox3.Location = new System.Drawing.Point(12, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 138);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "::Pelanggan::";
            // 
            // txtKodePlg
            // 
            this.txtKodePlg.Location = new System.Drawing.Point(193, 44);
            this.txtKodePlg.Name = "txtKodePlg";
            this.txtKodePlg.Size = new System.Drawing.Size(146, 32);
            this.txtKodePlg.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode Pelanggan";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNamaPel
            // 
            this.txtNamaPel.Location = new System.Drawing.Point(193, 82);
            this.txtNamaPel.Name = "txtNamaPel";
            this.txtNamaPel.Size = new System.Drawing.Size(246, 32);
            this.txtNamaPel.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKurang);
            this.groupBox4.Controls.Add(this.txtKodeBar);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnTambah);
            this.groupBox4.Controls.Add(this.btnCariBrg);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtQty);
            this.groupBox4.Controls.Add(this.txtNamaBar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtHarga);
            this.groupBox4.Location = new System.Drawing.Point(12, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 266);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "::Barang::";
            // 
            // btnKurang
            // 
            this.btnKurang.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKurang.FlatAppearance.BorderSize = 0;
            this.btnKurang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKurang.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurang.ForeColor = System.Drawing.Color.White;
            this.btnKurang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKurang.Location = new System.Drawing.Point(323, 200);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(116, 39);
            this.btnKurang.TabIndex = 7;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = false;
            // 
            // txtKodeBar
            // 
            this.txtKodeBar.Location = new System.Drawing.Point(193, 48);
            this.txtKodeBar.Name = "txtKodeBar";
            this.txtKodeBar.Size = new System.Drawing.Size(146, 32);
            this.txtKodeBar.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Harga";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(193, 200);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(124, 39);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kode Barang";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Qty";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(193, 162);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(146, 32);
            this.txtQty.TabIndex = 8;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQty_KeyPress);
            // 
            // txtNamaBar
            // 
            this.txtNamaBar.Location = new System.Drawing.Point(193, 86);
            this.txtNamaBar.Name = "txtNamaBar";
            this.txtNamaBar.Size = new System.Drawing.Size(246, 32);
            this.txtNamaBar.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nama ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(193, 124);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(246, 32);
            this.txtHarga.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Lime;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Location = new System.Drawing.Point(265, 578);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(196, 33);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan Transaksi";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBaru
            // 
            this.btnBaru.BackColor = System.Drawing.Color.Aqua;
            this.btnBaru.FlatAppearance.BorderSize = 0;
            this.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaru.Location = new System.Drawing.Point(61, 578);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(196, 33);
            this.btnBaru.TabIndex = 7;
            this.btnBaru.Text = "Transaksi Baru";
            this.btnBaru.UseVisualStyleBackColor = false;
            // 
            // btnCariBrg
            // 
            this.btnCariBrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCariBrg.FlatAppearance.BorderSize = 0;
            this.btnCariBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariBrg.Image = global::Kasir.Properties.Resources.search_16px;
            this.btnCariBrg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCariBrg.Location = new System.Drawing.Point(342, 46);
            this.btnCariBrg.Name = "btnCariBrg";
            this.btnCariBrg.Size = new System.Drawing.Size(97, 28);
            this.btnCariBrg.TabIndex = 4;
            this.btnCariBrg.Text = "Pilih";
            this.btnCariBrg.UseVisualStyleBackColor = false;
            this.btnCariBrg.Click += new System.EventHandler(this.BtnCariBrg_Click);
            // 
            // btnCariPel
            // 
            this.btnCariPel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCariPel.FlatAppearance.BorderSize = 0;
            this.btnCariPel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariPel.Image = global::Kasir.Properties.Resources.search_16px;
            this.btnCariPel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCariPel.Location = new System.Drawing.Point(345, 44);
            this.btnCariPel.Name = "btnCariPel";
            this.btnCariPel.Size = new System.Drawing.Size(97, 26);
            this.btnCariPel.TabIndex = 4;
            this.btnCariPel.Text = "Pilih";
            this.btnCariPel.UseVisualStyleBackColor = false;
            this.btnCariPel.Click += new System.EventHandler(this.BtnCariPel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kasir.Properties.Resources.cancel_48px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 741);
            this.Controls.Add(this.btnBaru);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtIdTransaksi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCariBrg;
        private System.Windows.Forms.TextBox txtNamaBar;
        private System.Windows.Forms.TextBox txtKodeBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCariPel;
        private System.Windows.Forms.TextBox txtNamaPel;
        private System.Windows.Forms.TextBox txtKodePlg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Button btnBaru;
    }
}