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
    public partial class frmGelirGider : Form
    {
        public GelirGider gelirGider;
        public frmGelirGider()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            decimal Gelir = gelirGider.GelenPara(0);
            decimal Gider = gelirGider.GidenPara(0);
            decimal Toplam = gelirGider.ToplamPara(Gelir, Gider);
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = Gelir;
            dataGridView1.Rows[0].Cells[1].Value = Gider;
            dataGridView1.Rows[0].Cells[2].Value = Toplam;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmGelirGider_Load(object sender, EventArgs e)
        {

        }
    }
}
