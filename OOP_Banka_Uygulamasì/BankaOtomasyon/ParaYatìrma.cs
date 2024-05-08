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
    public partial class ParaYatırma : Form
    {
        public BireyselMusteri m;
        public Banka b;
        public GelirGider gg;
        public ParaYatırma()
        {
            InitializeComponent();
        }
        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            if(txtHesapNo.Text==""|| TxtPara.Text=="")
            {
                MessageBox.Show("Bilgiler eksiksiz doldurulmalıdır.");
            }
            else
            {
                m.ParaYatir(Convert.ToInt32(txtHesapNo.Text), Convert.ToDecimal(TxtPara.Text));

                gg.GelenPara(Convert.ToDecimal(TxtPara.Text));
                Ozet yeniLog = new Ozet(1, Convert.ToDecimal(TxtPara.Text), Convert.ToInt32(txtHesapNo.Text));
                b.OzetEkle(yeniLog);
            }
        }
            

        private void TxtPara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
