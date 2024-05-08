using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon
{
    public class Ozet
    {
        public int islemTipi { get; set; }

        public int Kimden { get; set; }

        public string Kime { get; set; }

        public DateTime Tarih { get; set; }

        public decimal Miktar { get; set; }
        public Ozet()
        {
            this.Tarih = DateTime.Now;
        }
        public Ozet(int islemTipi, decimal miktar, int kimden, string kime="Banka")
        {
            this.Tarih = DateTime.Now;
            this.islemTipi = islemTipi;
            this.Kimden = kimden;
            this.Kime = kime;
            this.Miktar = miktar;
        }
    }
}
