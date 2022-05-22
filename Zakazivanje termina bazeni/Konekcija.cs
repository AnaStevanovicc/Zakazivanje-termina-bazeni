using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Zakazivanje_termina_bazeni
{
    internal class Konekcija
    {
        static public SqlConnection connect()
        {
            string cs;
            cs = "Data source = DESKTOP-UBL32UH; Initial catalog = Bazeni_prodaja_termina; Integrated security = true;MultipleActiveResultSets=true";
            SqlConnection veza = new SqlConnection(cs);
            return veza;
        }
    }
}
