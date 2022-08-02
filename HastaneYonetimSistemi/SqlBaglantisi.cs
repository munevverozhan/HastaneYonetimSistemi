using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HastaneYonetimSistemi
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-GBKS0E6;Initial Catalog=HastaneYonetimSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
      
    }
}
