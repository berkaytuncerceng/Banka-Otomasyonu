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
    public partial class HesapSil : Form
    {
        public BireyselMusteri musteri;
        public HesapSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text=="")
            {
                MessageBox.Show("Hesap Numarası Girilmelidir!");
            }
            else
            {
                musteri.HesapSil(Convert.ToInt16(txtHesapNo.Text));
                
            }
            
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = musteri.HesapListe();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HesapSil_Load(object sender, EventArgs e)
        {

        }
    }
}
