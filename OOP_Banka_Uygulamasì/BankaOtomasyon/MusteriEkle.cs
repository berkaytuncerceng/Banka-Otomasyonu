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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        
        public Banka banka1;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMusteriNo.Text==""|| txtAd.Text=="" || txtSoyad.Text=="" || cmbTur.Text=="")
            {
                MessageBox.Show("Bilgiler Eksiksiz Girilmelidir!");
            }

            else
            {
                BireyselMusteri musteri1 = new BireyselMusteri();
                musteri1.Ad = txtAd.Text;
                musteri1.Soyad = txtSoyad.Text;
                musteri1.Tur = cmbTur.Text;
                musteri1.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                banka1.MusteriNoKontrol(Convert.ToInt32(txtMusteriNo.Text));
                if (banka1.Kontrol == 1)
                {
                    banka1.MusteriEkle(musteri1);
                    MessageBox.Show("Müşteri Numarası Eklendi");
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = banka1.MusteriListe();
            }
            
        }
        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs character) // textboxa yalnızca sayı girilecek şekilde ayarlar.
        {
            character.Handled = !char.IsDigit(character.KeyChar) && !char.IsControl(character.KeyChar);
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
