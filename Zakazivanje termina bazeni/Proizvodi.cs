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
    public partial class Proizvodi : Form
    {
        public Proizvodi()
        {
            InitializeComponent();
        }

        private void Proizvodi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Proizvodi", Konekcija.connect());
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }
    }
}
