namespace Car_Wash
{
    partial class PembayaranJasa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtKdTransaksi = new TextBox();
            txtTotal = new TextBox();
            txtSubtotal = new TextBox();
            txtHarga = new TextBox();
            cmbPelanggan = new ComboBox();
            cmbPaket = new ComboBox();
            dtpWaktu = new DateTimePicker();
            txtKendaraan = new TextBox();
            txtPajak = new TextBox();
            dgvCari = new DataGridView();
            txtCari = new TextBox();
            btnSimpan = new Button();
            btnReset = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            btnCari = new Button();
            btnCetak = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCari).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 16);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "TRANSAKSI CAR WASH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 88);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Kode Transaksi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 148);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 433);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Cari Transaksi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 260);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 5;
            label6.Text = "Pajak";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 348);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 6;
            label7.Text = "Total Bayar ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 260);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 7;
            label8.Text = "Harga          ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(84, 207);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 8;
            label9.Text = "Paket Cuci     ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(486, 207);
            label10.Name = "label10";
            label10.Size = new Size(104, 15);
            label10.TabIndex = 9;
            label10.Text = "Jumlah Kendaraan";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(486, 88);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 10;
            label11.Text = " Tanggal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(84, 308);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 11;
            label12.Text = "Subtotal       ";
            // 
            // txtKdTransaksi
            // 
            txtKdTransaksi.Location = new Point(224, 88);
            txtKdTransaksi.Margin = new Padding(3, 2, 3, 2);
            txtKdTransaksi.Name = "txtKdTransaksi";
            txtKdTransaksi.Size = new Size(69, 23);
            txtKdTransaksi.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(224, 348);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 23);
            txtTotal.TabIndex = 13;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(224, 308);
            txtSubtotal.Margin = new Padding(3, 2, 3, 2);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(83, 23);
            txtSubtotal.TabIndex = 14;
            txtSubtotal.TextChanged += textBox3_TextChanged;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(224, 254);
            txtHarga.Margin = new Padding(3, 2, 3, 2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(83, 23);
            txtHarga.TabIndex = 15;
            // 
            // cmbPelanggan
            // 
            cmbPelanggan.FormattingEnabled = true;
            cmbPelanggan.Location = new Point(224, 146);
            cmbPelanggan.Margin = new Padding(3, 2, 3, 2);
            cmbPelanggan.Name = "cmbPelanggan";
            cmbPelanggan.Size = new Size(133, 23);
            cmbPelanggan.TabIndex = 16;
            // 
            // cmbPaket
            // 
            cmbPaket.FormattingEnabled = true;
            cmbPaket.Location = new Point(224, 201);
            cmbPaket.Margin = new Padding(3, 2, 3, 2);
            cmbPaket.Name = "cmbPaket";
            cmbPaket.Size = new Size(133, 23);
            cmbPaket.TabIndex = 17;
            cmbPaket.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dtpWaktu
            // 
            dtpWaktu.Location = new Point(615, 85);
            dtpWaktu.Margin = new Padding(3, 2, 3, 2);
            dtpWaktu.Name = "dtpWaktu";
            dtpWaktu.Size = new Size(219, 23);
            dtpWaktu.TabIndex = 18;
            // 
            // txtKendaraan
            // 
            txtKendaraan.Location = new Point(615, 201);
            txtKendaraan.Margin = new Padding(3, 2, 3, 2);
            txtKendaraan.Name = "txtKendaraan";
            txtKendaraan.Size = new Size(71, 23);
            txtKendaraan.TabIndex = 19;
            // 
            // txtPajak
            // 
            txtPajak.Location = new Point(615, 254);
            txtPajak.Margin = new Padding(3, 2, 3, 2);
            txtPajak.Name = "txtPajak";
            txtPajak.Size = new Size(95, 23);
            txtPajak.TabIndex = 20;
            // 
            // dgvCari
            // 
            dgvCari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCari.Location = new Point(244, 450);
            dgvCari.Margin = new Padding(3, 2, 3, 2);
            dgvCari.Name = "dgvCari";
            dgvCari.RowHeadersWidth = 51;
            dgvCari.Size = new Size(611, 82);
            dgvCari.TabIndex = 21;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(436, 428);
            txtCari.Margin = new Padding(3, 2, 3, 2);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(191, 23);
            txtCari.TabIndex = 22;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(263, 392);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(106, 22);
            btnSimpan.TabIndex = 23;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(714, 392);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 22);
            btnReset.TabIndex = 24;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(604, 392);
            btnHapus.Margin = new Padding(3, 2, 3, 2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(82, 22);
            btnHapus.TabIndex = 25;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(395, 392);
            btnUbah.Margin = new Padding(3, 2, 3, 2);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(82, 22);
            btnUbah.TabIndex = 26;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(642, 426);
            btnCari.Margin = new Padding(3, 2, 3, 2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(67, 22);
            btnCari.TabIndex = 27;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            // 
            // btnCetak
            // 
            btnCetak.Location = new Point(816, 392);
            btnCetak.Margin = new Padding(3, 2, 3, 2);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(128, 22);
            btnCetak.TabIndex = 28;
            btnCetak.Text = "Cetak Struk";
            btnCetak.UseVisualStyleBackColor = true;
            // 
            // PembayaranJasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 534);
            Controls.Add(btnCetak);
            Controls.Add(btnCari);
            Controls.Add(btnUbah);
            Controls.Add(btnHapus);
            Controls.Add(btnReset);
            Controls.Add(btnSimpan);
            Controls.Add(txtCari);
            Controls.Add(dgvCari);
            Controls.Add(txtPajak);
            Controls.Add(txtKendaraan);
            Controls.Add(dtpWaktu);
            Controls.Add(cmbPaket);
            Controls.Add(cmbPelanggan);
            Controls.Add(txtHarga);
            Controls.Add(txtSubtotal);
            Controls.Add(txtTotal);
            Controls.Add(txtKdTransaksi);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PembayaranJasa";
            Text = "PembayaranJasa";
            Load += Pembayaran_Jasa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtKdTransaksi;
        private TextBox txtTotal;
        private TextBox txtSubtotal;
        private TextBox txtHarga;
        private ComboBox cmbPelanggan;
        private ComboBox cmbPaket;
        private DateTimePicker dtpWaktu;
        private TextBox txtKendaraan;
        private TextBox txtPajak;
        private DataGridView dgvCari;
        private TextBox txtCari;
        private Button btnSimpan;
        private Button btnReset;
        private Button btnHapus;
        private Button btnUbah;
        private Button btnCari;
        private Button btnCetak;
    }
}