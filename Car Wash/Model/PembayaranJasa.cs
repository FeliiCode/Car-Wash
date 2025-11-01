using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Wash.Model
{
    public class PembayaranJasa
    {
        public string KodeTransaksi { get; set; }
        public string NamaPelanggan { get; set; }
        public string PaketCuci { get; set; }
        public double Harga { get; set; }
        public double SubTotal { get; set; }
        public double TotalBayar { get; set; }
      
        public DateTime Tanggal { get; set; }
        public int JumlahKendaraan { get; set; }

        public double Pajak { get; set; }



    }
}
