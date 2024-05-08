using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon
{
     public class Banka
    {
        List<BireyselMusteri> musteriler = new List<BireyselMusteri>();
        List<Ozet> ozetler = new List<Ozet>();
        public int Kontrol = 1;
        public int Kontrol2 = 0;
        public void MusteriEkle(BireyselMusteri m)
        {
            musteriler.Add(m);
        }
        public List<BireyselMusteri> MusteriListe()
        {
            return musteriler;
        }

        public void MusteriNoKontrol(int no)
        {
            foreach (BireyselMusteri m in musteriler)
            {
                if (m.MusteriNo==no)
                {
                    System.Windows.Forms.MessageBox.Show("Kullanılan Müşteri Numarası!");
                    Kontrol = 0;
                }
                else
                {
                    Kontrol = 1;
                }
            }
        }
        public string tur;
        public void HesapKontrol(int musterino,int hesapno)
        {
            foreach (BireyselMusteri m in musteriler)
            {
                if (m.MusteriNo == musterino)
                {
                    Kontrol2 = 1;
                    tur = m.Tur;
                    break;
                }
                else
                {
                    Kontrol2 = 0;
                }
            }
        }
        public void OzetEkle(Ozet o)
        {
            this.ozetler.Add(o);
        }
        public List<Ozet> OzetGetir(int hesapNo, DateTime from, DateTime to)
        {
            List<Ozet> list = new List<Ozet>();
            list = ozetler.Where(x => x.Kimden == hesapNo && (x.Tarih >= from && x.Tarih <= to)).ToList();
            
            return list;
        }

     }
}
