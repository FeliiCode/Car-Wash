namespace Car_Wash
{
    partial class MainMenu
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
            menuStrip1 = new MenuStrip();
            masterToolStripMenuItem = new ToolStripMenuItem();
            Customer = new ToolStripMenuItem();
            PaketCuci = new ToolStripMenuItem();
            Transaksi = new ToolStripMenuItem();
            PembayaranJasa = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            laporanToolStripMenuItem = new ToolStripMenuItem();
            menuKeluar = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterToolStripMenuItem, Transaksi, historyToolStripMenuItem, menuKeluar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            masterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Customer, PaketCuci });
            masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            masterToolStripMenuItem.Size = new Size(82, 29);
            masterToolStripMenuItem.Text = "Master";
            masterToolStripMenuItem.Click += masterToolStripMenuItem_Click;
            // 
            // Customer
            // 
            Customer.Name = "Customer";
            Customer.Size = new Size(194, 34);
            Customer.Text = "Customer";
            Customer.Click += toolStripMenuItem1_Click;
            // 
            // PaketCuci
            // 
            PaketCuci.Name = "PaketCuci";
            PaketCuci.Size = new Size(194, 34);
            PaketCuci.Text = "Paket Cuci";
            PaketCuci.Click += PaketCuci_Click;
            // 
            // Transaksi
            // 
            Transaksi.DropDownItems.AddRange(new ToolStripItem[] { PembayaranJasa });
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(98, 29);
            Transaksi.Text = "Transaksi";
            // 
            // PembayaranJasa
            // 
            PembayaranJasa.Name = "PembayaranJasa";
            PembayaranJasa.Size = new Size(248, 34);
            PembayaranJasa.Text = "Pembayaran Jasa";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { laporanToolStripMenuItem });
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(85, 29);
            historyToolStripMenuItem.Text = "History";
            // 
            // laporanToolStripMenuItem
            // 
            laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            laporanToolStripMenuItem.Size = new Size(178, 34);
            laporanToolStripMenuItem.Text = "Laporan";
            // 
            // menuKeluar
            // 
            menuKeluar.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuKeluar.Name = "menuKeluar";
            menuKeluar.Size = new Size(89, 29);
            menuKeluar.Text = "Aplikasi";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainMenu";
            Text = " ";
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterToolStripMenuItem;
        private ToolStripMenuItem Customer;
        private ToolStripMenuItem PaketCuci;
        private ToolStripMenuItem Transaksi;
        private ToolStripMenuItem PembayaranJasa;
        private ToolStripMenuItem menuKeluar;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem laporanToolStripMenuItem;
    }
}