namespace Car_Wash
{
    partial class PaketCuci
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
            label5 = new Label();
            label6 = new Label();
            txtNamaPaket = new TextBox();
            txtKdPaket = new TextBox();
            txtDurasi = new TextBox();
            txtHarga = new TextBox();
            cmbKendaraan = new ComboBox();
            btnSimpan = new Button();
            btnUbah = new Button();
            btnReset = new Button();
            btnHapus = new Button();
            btnCari = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            txtCari = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 22);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "DATA PAKET CUCI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 86);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Kode Paket";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 86);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Paket";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 148);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Harga";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 148);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "Jenis Kendaraan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 198);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "Durasi";
            // 
            // txtNamaPaket
            // 
            txtNamaPaket.Location = new Point(533, 84);
            txtNamaPaket.Margin = new Padding(3, 2, 3, 2);
            txtNamaPaket.Name = "txtNamaPaket";
            txtNamaPaket.Size = new Size(177, 23);
            txtNamaPaket.TabIndex = 6;
            txtNamaPaket.TextChanged += textBox1_TextChanged;
            // 
            // txtKdPaket
            // 
            txtKdPaket.Location = new Point(186, 86);
            txtKdPaket.Margin = new Padding(3, 2, 3, 2);
            txtKdPaket.Name = "txtKdPaket";
            txtKdPaket.Size = new Size(177, 23);
            txtKdPaket.TabIndex = 7;
            // 
            // txtDurasi
            // 
            txtDurasi.Location = new Point(186, 198);
            txtDurasi.Margin = new Padding(3, 2, 3, 2);
            txtDurasi.Name = "txtDurasi";
            txtDurasi.Size = new Size(125, 23);
            txtDurasi.TabIndex = 8;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(533, 148);
            txtHarga.Margin = new Padding(3, 2, 3, 2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(110, 23);
            txtHarga.TabIndex = 9;
            // 
            // cmbKendaraan
            // 
            cmbKendaraan.FormattingEnabled = true;
            cmbKendaraan.Location = new Point(186, 146);
            cmbKendaraan.Margin = new Padding(3, 2, 3, 2);
            cmbKendaraan.Name = "cmbKendaraan";
            cmbKendaraan.Size = new Size(177, 23);
            cmbKendaraan.TabIndex = 10;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(117, 248);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(110, 22);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(271, 248);
            btnUbah.Margin = new Padding(3, 2, 3, 2);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(82, 22);
            btnUbah.TabIndex = 12;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += button2_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(491, 248);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 22);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(604, 248);
            btnHapus.Margin = new Padding(3, 2, 3, 2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(82, 22);
            btnHapus.TabIndex = 14;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += button4_Click;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(604, 320);
            btnCari.Margin = new Padding(3, 2, 3, 2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(106, 22);
            btnCari.TabIndex = 15;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 345);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(584, 122);
            dataGridView1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 322);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 17;
            label7.Text = "Pencarian Paket";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(289, 320);
            txtCari.Margin = new Padding(3, 2, 3, 2);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(297, 23);
            txtCari.TabIndex = 18;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // PaketCuci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 484);
            Controls.Add(txtCari);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(btnCari);
            Controls.Add(btnHapus);
            Controls.Add(btnReset);
            Controls.Add(btnUbah);
            Controls.Add(btnSimpan);
            Controls.Add(cmbKendaraan);
            Controls.Add(txtHarga);
            Controls.Add(txtDurasi);
            Controls.Add(txtKdPaket);
            Controls.Add(txtNamaPaket);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaketCuci";
            Text = "PaketCuci";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNamaPaket;
        private TextBox txtKdPaket;
        private TextBox txtDurasi;
        private TextBox txtHarga;
        private ComboBox cmbKendaraan;
        private Button btnSimpan;
        private Button btnUbah;
        private Button btnReset;
        private Button btnHapus;
        private Button btnCari;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox txtCari;
    }
}