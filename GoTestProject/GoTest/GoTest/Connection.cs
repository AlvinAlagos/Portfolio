using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace GoTest
{
    class Connection
    { 
        
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\GoTestNewCopy\GoTest\GoTest\GoTestDatabase.mdf;Integrated Security=True");
        private static Connection connect;

        private Connection()
        {

        }

        public SqlConnection GetConnection()
        {
            return con;
        }

        public static Connection GetInstance()
        {
            if (connect == null)
            {
                connect = new Connection();
            }
            return connect;
        }
    }
}
