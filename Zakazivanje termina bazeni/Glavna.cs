using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakazivanje_termina_bazeni
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnik frm_Korisnik = new Korisnik();
            frm_Korisnik.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvodi frm_Proizvodi = new Proizvodi();
            frm_Proizvodi.Show();
        }

        private void lokacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Lokacija");
            frm_sifarnik.Show();
        }

        private void tipKarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Tip_karte");
            frm_sifarnik.Show();
        }

        private void prodavnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Proizvodi");
            frm_sifarnik.Show();
        }

        private void dgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zakazivanje frm_zakazati = new Zakazivanje();
            frm_zakazati.Show();
        }
    }
}
