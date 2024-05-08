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
    public partial class HesapOzeti : Form
    {
        public Banka banka;
        public HesapOzeti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text=="")
            {
                MessageBox.Show("Hesap Numarası Girilmelidir!!");
            }
            else
            {
                int hesapno = Convert.ToInt32(txtHesapNo.Text);
                DateTime from = baslangicTarihi.Value.Date;
                DateTime to = bitisTarihi.Value.Date;
                dataGridView1.DataSource = banka.OzetGetir(hesapno, from, to);
            }
           
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs character)
        {
            character.Handled = !char.IsDigit(character.KeyChar) && !char.IsControl(character.KeyChar);
        }

        private void HesapOzeti_Load(object sender, EventArgs e)
        {

        }
    }
}
