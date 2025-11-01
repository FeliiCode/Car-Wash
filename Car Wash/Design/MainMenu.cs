using System;
using System.Windows.Forms;

namespace Car_Wash
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Jadikan form utama sebagai container MDI
            this.IsMdiContainer = true;

            // Opsional: tampilkan pesan selamat datang
            // MessageBox.Show("Selamat datang di Aplikasi Car Wash!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // === MENU MASTER (tidak perlu isi apapun) ===
        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kosong, hanya untuk struktur menu
        }

        // === MENU PELANGGAN ===
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer formPelanggan = new Customer();
            formPelanggan.MdiParent = this;
            formPelanggan.Show();
        }

        // === MENU PAKET CUCI ===
        private void PaketCuci_Click(object sender, EventArgs e)
        {
            PaketCuci formPaket = new PaketCuci();
            formPaket.MdiParent = this;
            formPaket.Show();
        }

        // === MENU TRANSAKSI ===
        private void PembayaranJasa_Click(object sender, EventArgs e)
        {
            PembayaranJasa formPembayaranJasa = new PembayaranJasa();
            formPembayaranJasa.MdiParent = this;
            formPembayaranJasa.Show();
        }


        // === MENU LAPORAN ===
        private void laporan_Click(object sender, EventArgs e)
        {
            Laporan formLaporan = new Laporan();
            formLaporan.MdiParent = this;
            formLaporan.Show();
        }

        // === MENU EXIT ===
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
