using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyon
{
    public partial class HesapAc : Form
    {
        public BireyselMusteri musteri;
        public Banka banka;
        public HesapAc()
        {
            InitializeComponent();
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if(txtMusteriNo.Text=="")
            {
                MessageBox.Show("Müşteri Numarası Girilmeli!");
            }
            else
            {
                Hesap hesap1 = new Hesap();
                Random sayi = new Random();
                int no = sayi.Next(100, 1000);
                banka.HesapKontrol(Convert.ToInt16(txtMusteriNo.Text), no);
                if (banka.Kontrol2 == 1)
                {
                    hesap1.MusteriNo = Convert.ToInt16(txtMusteriNo.Text);
                    hesap1.HesapNo = no;
                    hesap1.Bakiye = 0;
                    hesap1.Tur = banka.tur;
                    MessageBox.Show("Hesap Açma Başarılı");
                    if (hesap1.Tur == "Ticari")
                    {
                        hesap1.EkHesapBakiyesi = 1000;
                    }
                    else
                    {
                        hesap1.EkHesapBakiyesi = 2000;
                    }
                    musteri.HesapOlustur(hesap1);


                }
                banka.Kontrol2 = 0;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = musteri.HesapListe();
            }
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = musteri.HesapListe();
        }

        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs character)
        {
            character.Handled = !char.IsDigit(character.KeyChar) && !char.IsControl(character.KeyChar);
        }

        private void HesapAc_Load(object sender, EventArgs e)
        {

        }
    }
}
