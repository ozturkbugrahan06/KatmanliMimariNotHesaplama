using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FACADELAYERR
{
    class SQLBAGLANTISI
    {
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-3D56EVF;Initial Catalog=DBTESTKATMAN;Integrated Security=True");
    }
}
