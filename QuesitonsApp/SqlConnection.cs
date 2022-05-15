using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QuesitonsApp
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection connection = new SqlConnection("Data Source = MSI; Initial Catalog = Questions Aplication;Integrated Security = True");
            connection.Open();
            return connection;
        }


    }
}
