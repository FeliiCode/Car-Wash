using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Wash.Model
{
    public class PaketCuci
    {
        public int id { get; set; }

        public string KodePaket { get; set; }
        public string JenisKendaraan { get; set; }
        public double Durasi { get; set; }
        public string NamaPaket { get; set; }
        public double Harga { get; set; }


    }
}
