namespace Kasir
{
    partial class frmPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPembelian));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNotrx = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKdBarang = new System.Windows.Forms.TextBox();
            this.cmbSuplier = new System.Windows.Forms.ComboBox();
            this.txtTotalHrg = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListPembelian = new System.Windows.Forms.DataGridView();
            this.txtxNmBrg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.suplier = new Kasir.Suplier();
            this.suplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplierTableAdapter = new Kasir.SuplierTableAdapters.SuplierTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 52);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1083, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEMBELIAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtxNmBrg);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtTotalHrg);
            this.groupBox1.Controls.Add(this.cmbSuplier);
            this.groupBox1.Controls.Add(this.txtKdBarang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblNotrx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Pembelian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kode Barang";
            // 
            // lblNotrx
            // 
            this.lblNotrx.AutoSize = true;
            this.lblNotrx.ForeColor = System.Drawing.Color.Red;
            this.lblNotrx.Location = new System.Drawing.Point(563, 41);
            this.lblNotrx.Name = "lblNotrx";
            this.lblNotrx.Size = new System.Drawing.Size(65, 23);
            this.lblNotrx.TabIndex = 11;
            this.lblNotrx.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Suplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "No Transaksi";
            // 
            // txtKdBarang
            // 
            this.txtKdBarang.Location = new System.Drawing.Point(248, 146);
            this.txtKdBarang.Name = "txtKdBarang";
            this.txtKdBarang.Size = new System.Drawing.Size(309, 32);
            this.txtKdBarang.TabIndex = 15;
            // 
            // cmbSuplier
            // 
            this.cmbSuplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suplierBindingSource, "id", true));
            this.cmbSuplier.DataSource = this.suplierBindingSource;
            this.cmbSuplier.DisplayMember = "nama";
            this.cmbSuplier.FormattingEnabled = true;
            this.cmbSuplier.Location = new System.Drawing.Point(248, 109);
            this.cmbSuplier.Name = "cmbSuplier";
            this.cmbSuplier.Size = new System.Drawing.Size(309, 31);
            this.cmbSuplier.TabIndex = 16;
            this.cmbSuplier.ValueMember = "id";
            // 
            // txtTotalHrg
            // 
            this.txtTotalHrg.Location = new System.Drawing.Point(729, 143);
            this.txtTotalHrg.Name = "txtTotalHrg";
            this.txtTotalHrg.Size = new System.Drawing.Size(309, 32);
            this.txtTotalHrg.TabIndex = 17;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(729, 100);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(174, 32);
            this.txtQty.TabIndex = 18;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(729, 194);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(125, 39);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListPembelian);
            this.groupBox2.Location = new System.Drawing.Point(12, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1109, 334);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Pembelian";
            // 
            // dgvListPembelian
            // 
            this.dgvListPembelian.BackgroundColor = System.Drawing.Color.White;
            this.dgvListPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPembelian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListPembelian.Location = new System.Drawing.Point(3, 28);
            this.dgvListPembelian.Name = "dgvListPembelian";
            this.dgvListPembelian.RowHeadersWidth = 62;
            this.dgvListPembelian.RowTemplate.Height = 28;
            this.dgvListPembelian.Size = new System.Drawing.Size(1103, 303);
            this.dgvListPembelian.TabIndex = 0;
            // 
            // txtxNmBrg
            // 
            this.txtxNmBrg.Location = new System.Drawing.Point(248, 184);
            this.txtxNmBrg.Name = "txtxNmBrg";
            this.txtxNmBrg.Size = new System.Drawing.Size(309, 32);
            this.txtxNmBrg.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nama Barang";
            // 
            // suplier
            // 
            this.suplier.DataSetName = "Suplier";
            this.suplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suplierBindingSource
            // 
            this.suplierBindingSource.DataMember = "Suplier";
            this.suplierBindingSource.DataSource = this.suplier;
            // 
            // suplierTableAdapter
            // 
            this.suplierTableAdapter.ClearBeforeFill = true;
            // 
            // frmPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 719);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPembelian";
            this.Load += new System.EventHandler(this.FrmPembelian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtxNmBrg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTotalHrg;
        private System.Windows.Forms.ComboBox cmbSuplier;
        private System.Windows.Forms.TextBox txtKdBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNotrx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListPembelian;
        private Suplier suplier;
        private System.Windows.Forms.BindingSource suplierBindingSource;
        private SuplierTableAdapters.SuplierTableAdapter suplierTableAdapter;
    }
}