namespace Car_Wash
{
    partial class Laporan
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnFilter = new Button();
            btnTutup = new Button();
            btnEXCEL = new Button();
            btnPDF = new Button();
            btnReset = new Button();
            dgvLaporan = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 74);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Periode Awal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 74);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Periode Akhir";
            label2.Click += label2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(140, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(510, 69);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(78, 146);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(149, 29);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnTutup
            // 
            btnTutup.Location = new Point(694, 146);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(94, 29);
            btnTutup.TabIndex = 5;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = true;
            // 
            // btnEXCEL
            // 
            btnEXCEL.Location = new Point(545, 146);
            btnEXCEL.Name = "btnEXCEL";
            btnEXCEL.Size = new Size(110, 29);
            btnEXCEL.TabIndex = 6;
            btnEXCEL.Text = "Export Excel";
            btnEXCEL.UseVisualStyleBackColor = true;
            btnEXCEL.Click += button3_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(407, 146);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(108, 29);
            btnPDF.TabIndex = 7;
            btnPDF.Text = "Export PDF";
            btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(274, 146);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button5_Click;
            // 
            // dgvLaporan
            // 
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(117, 264);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersWidth = 51;
            dgvLaporan.Size = new Size(610, 145);
            dgvLaporan.TabIndex = 9;
            dgvLaporan.CellContentClick += dgvLaporan_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 231);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 10;
            label3.Text = "LAPORAN TRANSAKSI";
            label3.Click += label3_Click;
            // 
            // Laporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dgvLaporan);
            Controls.Add(btnReset);
            Controls.Add(btnPDF);
            Controls.Add(btnEXCEL);
            Controls.Add(btnTutup);
            Controls.Add(btnFilter);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Laporan";
            Text = "Laporan";
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnFilter;
        private Button btnTutup;
        private Button btnEXCEL;
        private Button btnPDF;
        private Button btnReset;
        private DataGridView dgvLaporan;
        private Label label3;
    }
}