using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Conecion
{
    public class Conexions
    {

        public static SqlConnection conecion()
        {
            SqlConnection conecionConnection = new SqlConnection("Data Source =DESKTOP-8IA67VT; Initial Catalog = inventario; Integrated Security = True");
            conecionConnection.Open();
            return conecionConnection;

        }
    }
}
