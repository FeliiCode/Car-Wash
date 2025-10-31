namespace Car_Wash
{
    partial class Customer
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
            btnSimpan = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnReset = new Button();
            btnCari = new Button();
            dgvPencarian = new DataGridView();
            label7 = new Label();
            txtKdPelanggan = new TextBox();
            txtNmPelanggan = new TextBox();
            txtAlamat = new TextBox();
            txtNoHp = new TextBox();
            txtEmail = new TextBox();
            txtPencarian = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPencarian).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Data Pelanggan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 80);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Kode Pelanggan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 138);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama  Pelanggan";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 197);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 259);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "No.HP";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 312);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(78, 374);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(201, 374);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(75, 23);
            btnUbah.TabIndex = 7;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(364, 374);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 8;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(483, 374);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(509, 423);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(75, 23);
            btnCari.TabIndex = 10;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            // 
            // dgvPencarian
            // 
            dgvPencarian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPencarian.Location = new Point(95, 452);
            dgvPencarian.Name = "dgvPencarian";
            dgvPencarian.RowHeadersWidth = 51;
            dgvPencarian.Size = new Size(635, 150);
            dgvPencarian.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 428);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 12;
            label7.Text = "Pencarian";
            label7.Click += label7_Click;
            // 
            // txtKdPelanggan
            // 
            txtKdPelanggan.Location = new Point(201, 80);
            txtKdPelanggan.Name = "txtKdPelanggan";
            txtKdPelanggan.Size = new Size(189, 23);
            txtKdPelanggan.TabIndex = 13;
            // 
            // txtNmPelanggan
            // 
            txtNmPelanggan.Location = new Point(201, 138);
            txtNmPelanggan.Name = "txtNmPelanggan";
            txtNmPelanggan.Size = new Size(189, 23);
            txtNmPelanggan.TabIndex = 14;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(201, 197);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(189, 23);
            txtAlamat.TabIndex = 15;
            txtAlamat.TextChanged += textBox3_TextChanged;
            // 
            // txtNoHp
            // 
            txtNoHp.Location = new Point(201, 259);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(189, 23);
            txtNoHp.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(201, 312);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtPencarian
            // 
            txtPencarian.Location = new Point(302, 426);
            txtPencarian.Name = "txtPencarian";
            txtPencarian.Size = new Size(189, 23);
            txtPencarian.TabIndex = 18;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(txtPencarian);
            Controls.Add(txtEmail);
            Controls.Add(txtNoHp);
            Controls.Add(txtAlamat);
            Controls.Add(txtNmPelanggan);
            Controls.Add(txtKdPelanggan);
            Controls.Add(label7);
            Controls.Add(dgvPencarian);
            Controls.Add(btnCari);
            Controls.Add(btnReset);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnSimpan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPencarian).EndInit();
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
        private Button btnSimpan;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnReset;
        private Button btnCari;
        private DataGridView dgvPencarian;
        private Label label7;
        private TextBox txtKdPelanggan;
        private TextBox txtNmPelanggan;
        private TextBox txtAlamat;
        private TextBox txtNoHp;
        private TextBox txtEmail;
        private TextBox txtPencarian;
    }
}