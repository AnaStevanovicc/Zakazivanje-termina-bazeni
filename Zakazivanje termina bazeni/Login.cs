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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Morate uneti email i lozinku.");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.connect();
                    SqlCommand komanda = new SqlCommand("Select * from Korisnik where email = @username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (string.Compare(tabela.Rows[0]["pass"].ToString(), txt_pass.Text) == 0)
                        {
                            MessageBox.Show("Login successful!!!");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            this.Hide();
                            Glavna frm_Glavna = new Glavna();
                            frm_Glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Neispravna lozinka");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci email.");
                    }
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }

        private void btn_ok1_Click(object sender, EventArgs e)
        {
            if (txt_ime.Text == "" || txt_prezime.Text == "" || txt_email.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Morate uneti sve podatke.");
                return;
            }
            else
            {
                StringBuilder Naredba = new StringBuilder("INSERT INTO Korisnik (ime, prezime, email, pass) " +
                    "VALUES('");
                Naredba.Append(txt_ime.Text + "', '");
                Naredba.Append(txt_prezime.Text + "', '");
                Naredba.Append(txt_email.Text + "', '");
                Naredba.Append(txt_password.Text + "')");
                SqlConnection veza = Konekcija.connect();
                SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
                this.Hide();
                Glavna frm_Glavna = new Glavna();
                frm_Glavna.Show();
            }
        }
    }
}
