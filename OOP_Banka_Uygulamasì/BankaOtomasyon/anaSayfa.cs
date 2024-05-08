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
    public partial class Form1 : Form
    {
        HesapAc frm = new HesapAc();
        public Banka b;
        public BireyselMusteri m;
        public Hesap h;
        public Havale havale;
        public GelirGider gg;
        public Form1()
        {
            InitializeComponent();
            b = new Banka();
            m = new BireyselMusteri();
            h = new Hesap();
            havale = new Havale();
            gg = new GelirGider();
        }
         
        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle frm = new MusteriEkle();
            frm.MdiParent = this;
            frm.banka1 = this.b;
            frm.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hesapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new HesapAc();
            frm.MdiParent = this;
            frm.musteri = this.m;
            frm.banka = this.b;
            frm.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaYatırma frm = new ParaYatırma();
            frm.MdiParent = this;
            frm.m = this.m;
            frm.b = this.b;
            frm.gg = this.gg;
            frm.Show();
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaCekme frm = new ParaCekme();
            frm.MdiParent = this;
            frm.m = this.m;
            frm.b = this.b;
            frm.gg = this.gg;
            frm.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavale frm = new frmHavale();
            frm.MdiParent = this;
            frm.musteri = this.m;
            frm.banka = this.b;
            frm.havale = this.havale;
            frm.Show();
        }

        private void bankaGelirGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelirGider frm = new frmGelirGider();
            frm.MdiParent = this;
            frm.gelirGider = this.gg;
            frm.Show();
        }

        private void hesapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapSil frm2 = new HesapSil();
            frm2.MdiParent = this;
            frm2.musteri = this.m;
            frm2.Show();
            frm.Hide();
        }

        private void hesapDökümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapOzeti frm = new HesapOzeti();
            frm.MdiParent = this;
            frm.banka = this.b;
            frm.Show();
        }

    }
}
