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
    public partial class frmHavale : Form
    {
        public BireyselMusteri musteri;
        public Banka banka;
        public Havale havale;
        public frmHavale()
        {
            InitializeComponent();
        }
        public string Tur;
        public decimal Kesinti;
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtGonderenHesap.Text=="" || txtPara.Text=="" || txtAlanHesap.Text=="" ||txtGonderenHesap.Text=="")
            {
                MessageBox.Show("Bilgiler eksiksiz doldurulmalıdır!");
            }
            else
            {
                Tur = musteri.TurKontrol(Convert.ToInt32(txtGonderenHesap.Text));
                Kesinti = havale.KesintiIslem(Tur, Convert.ToDecimal(txtPara.Text));
                musteri.Havale(Convert.ToInt32(txtGonderenHesap.Text), Convert.ToInt32(txtAlanHesap.Text), Convert.ToDecimal(txtPara.Text), Kesinti);

                Ozet yeniOzet = new Ozet(3, Convert.ToDecimal(txtPara.Text), Convert.ToInt32(txtGonderenHesap.Text),(txtAlanHesap.Text));
                banka.OzetEkle(yeniOzet);
            }
            
            
        }

        private void txtGonderenHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAlanHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmHavale_Load(object sender, EventArgs e)
        {

        }
    }
}
