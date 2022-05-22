using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zakazivanje_termina_bazeni
{
    public partial class Zakazivanje : Form
    {
        public Zakazivanje()
        {
            InitializeComponent();
        }


        private void Zakazivanje_Load(object sender, EventArgs e)
        {
            cmb_korisnik_populate();
            cmb_lokacija_populate();
            cmb_tip_karte_populate();
        }

        private void cmb_korisnik_populate()
        {
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, ime + ' ' + prezime as naziv from Korisnik", veza);
            DataTable dt_korisnik = new DataTable();
            adapter.Fill(dt_korisnik);
            cmb_korisnik.DataSource = dt_korisnik;
            cmb_korisnik.ValueMember = "id";
            cmb_korisnik.DisplayMember = "naziv";
            cmb_korisnik.SelectedValue = -1;
        }

        private void cmb_tip_karte_populate()
        {
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv + ', ' + STR(cena) + 'din' as nazivi from Tip_karte", veza);
            DataTable dt_karta = new DataTable();
            adapter.Fill(dt_karta);
            cmb_tip_karte.DataSource = dt_karta;
            cmb_tip_karte.ValueMember = "id";
            cmb_tip_karte.DisplayMember = "nazivi";
            cmb_tip_karte.SelectedValue = -1;
        }
        private void cmb_tip_karte_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_tip_karte.IsHandleCreated && cmb_tip_karte.Focused)
            {
                cmb_termin_populate();
                cmb_termin.SelectedIndex = -1;
            }
        }

        private void cmb_termin_populate()
        {
            string tip_karte = cmb_tip_karte.SelectedValue.ToString();
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, cast(datepart(hh, pocetak_termina) as varchar) + ':00-' + cast(datepart(hh, kraj_termina) as varchar) + ':00' as naziv from Termini where tip_karte_id = " + tip_karte, veza);
            DataTable dt_termin = new DataTable();
            adapter.Fill(dt_termin);
            cmb_termin.DataSource = dt_termin;
            cmb_termin.ValueMember = "id";
            cmb_termin.DisplayMember = "naziv";
        }

        private void cmb_lokacija_populate()
        {
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Lokacija", veza);
            DataTable dt_lokacija = new DataTable();
            adapter.Fill(dt_lokacija);
            cmb_lokacija.DataSource = dt_lokacija;
            cmb_lokacija.ValueMember = "id";
            cmb_lokacija.DisplayMember = "grad";
            cmb_lokacija.SelectedValue = -1;
        }

        private void cmb_bazen_populate()
        {
            string lokacija = cmb_lokacija.SelectedValue.ToString();
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv from Bazeni where lokacija_id = " + lokacija, veza);
            DataTable dt_bazen = new DataTable();
            adapter.Fill(dt_bazen);
            cmb_bazen.DataSource = dt_bazen;
            cmb_bazen.ValueMember = "id";
            cmb_bazen.DisplayMember = "naziv";
        }

        private void cmb_lokacija_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_lokacija.IsHandleCreated && cmb_lokacija.Focused)
            {
                cmb_bazen_populate();
                cmb_bazen.SelectedIndex = -1;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("insert into Iznajmljivanje (korisnik_id, termin_id, datum, bazen_id) values('");
            DateTime datum = Datum.Value;
            naredba.Append(cmb_korisnik.SelectedValue.ToString() + "', '");
            naredba.Append(cmb_termin.SelectedValue.ToString() + "', '");
            naredba.Append(datum.ToString("yyyy-MM-dd") + "', '");
            naredba.Append(cmb_bazen.SelectedValue.ToString() + "')");
            SqlConnection veza = Konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                MessageBox.Show("Vas termin je zakazan.");
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
        }
    }
}
