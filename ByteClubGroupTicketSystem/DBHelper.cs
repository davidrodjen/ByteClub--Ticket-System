using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            string con = @"Data Source=(localdb)\MSSQLLocalDB;" +
                "Initial Catalog = TicketSystem;" +
                "Integrated Security=True";

            return new SqlConnection(con);
        }
    }
}