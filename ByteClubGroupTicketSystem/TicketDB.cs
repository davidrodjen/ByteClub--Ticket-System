using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    class TicketDB
    {

        public static List<Ticket> GetAllTickets()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand selectCmd = new SqlCommand();
            selectCmd.Connection = con;
            selectCmd.CommandText = "SELECT TicketId, " +
                "PurchasedBy, Price, " +
                "Price, PurchaseDate " +
                "UseDate " +
                "FROM Ticket " +
                "ORDER BY TicketId";

            con.Open();

            SqlDataReader reader = selectCmd.ExecuteReader();

            var tickets = new List<Ticket>();
            while (reader.Read())
            {
                Ticket tempTicket = new Ticket();
                tempTicket.TicketId = (int)reader["TicketId"];
                tempTicket.PurchasedBy = (string)reader["TicketId"];
                tempTicket.Price = (int)reader["TicketId"];
                tempTicket.PurchaseDate = (DateTime)reader["TicketId"];
                tempTicket.UseDate = (DateTime)reader["TicketId"];
            }

            con.Close();
            return tickets;
        }
        
    }
}
