namespace Kasir
{
    partial class frmKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPengaturan = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnPelanggan = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNamaToko = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnPengaturan);
            this.panel1.Controls.Add(this.btnLaporan);
            this.panel1.Controls.Add(this.btnPelanggan);
            this.panel1.Controls.Add(this.btnBarang);
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 752);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(24, 545);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(274, 56);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnPengaturan
            // 
            this.btnPengaturan.FlatAppearance.BorderSize = 0;
            this.btnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengaturan.ForeColor = System.Drawing.Color.White;
            this.btnPengaturan.Image = ((System.Drawing.Image)(resources.GetObject("btnPengaturan.Image")));
            this.btnPengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengaturan.Location = new System.Drawing.Point(24, 496);
            this.btnPengaturan.Name = "btnPengaturan";
            this.btnPengaturan.Size = new System.Drawing.Size(274, 56);
            this.btnPengaturan.TabIndex = 17;
            this.btnPengaturan.Text = "   Pengaturan";
            this.btnPengaturan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPengaturan.UseVisualStyleBackColor = true;
            // 
            // btnLaporan
            // 
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Image = ((System.Drawing.Image)(resources.GetObject("btnLaporan.Image")));
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(24, 449);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(274, 56);
            this.btnLaporan.TabIndex = 16;
            this.btnLaporan.Text = "   Laporan Penjualan";
            this.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.FlatAppearance.BorderSize = 0;
            this.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelanggan.ForeColor = System.Drawing.Color.White;
            this.btnPelanggan.Image = ((System.Drawing.Image)(resources.GetObject("btnPelanggan.Image")));
            this.btnPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelanggan.Location = new System.Drawing.Point(24, 403);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Size = new System.Drawing.Size(274, 56);
            this.btnPelanggan.TabIndex = 15;
            this.btnPelanggan.Text = "   Pelanggan";
            this.btnPelanggan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPelanggan.UseVisualStyleBackColor = true;
            this.btnPelanggan.Click += new System.EventHandler(this.BtnPelanggan_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.FlatAppearance.BorderSize = 0;
            this.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarang.ForeColor = System.Drawing.Color.White;
            this.btnBarang.Image = ((System.Drawing.Image)(resources.GetObject("btnBarang.Image")));
            this.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarang.Location = new System.Drawing.Point(24, 354);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(274, 56);
            this.btnBarang.TabIndex = 14;
            this.btnBarang.Text = "   Barang";
            this.btnBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarang.UseVisualStyleBackColor = true;
            this.btnBarang.Click += new System.EventHandler(this.BtnBarang_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaksi.Image")));
            this.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.Location = new System.Drawing.Point(22, 302);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(274, 56);
            this.btnTransaksi.TabIndex = 13;
            this.btnTransaksi.Text = "   Transaksi";
            this.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.BtnTransaksi_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Orange;
            this.sidePanel.Location = new System.Drawing.Point(2, 250);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 58);
            this.sidePanel.TabIndex = 12;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(22, 252);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(274, 56);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNamaToko);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 246);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "KASIR | POS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNamaToko
            // 
            this.lblNamaToko.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNamaToko.AutoSize = true;
            this.lblNamaToko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNamaToko.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaToko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblNamaToko.Location = new System.Drawing.Point(95, 142);
            this.lblNamaToko.Name = "lblNamaToko";
            this.lblNamaToko.Size = new System.Drawing.Size(183, 38);
            this.lblNamaToko.TabIndex = 1;
            this.lblNamaToko.Text = "INDIEMART";
            this.lblNamaToko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(309, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 36);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(841, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(315, 42);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(891, 698);
            this.pnlMain.TabIndex = 3;
            // 
            // frmKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 752);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmKasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKasir";
            this.Load += new System.EventHandler(this.FrmKasir_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNamaToko;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Button btnPengaturan;
        public System.Windows.Forms.Button btnLaporan;
        public System.Windows.Forms.Button btnPelanggan;
        public System.Windows.Forms.Button btnBarang;
        public System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Panel sidePanel;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMain;
    }
}