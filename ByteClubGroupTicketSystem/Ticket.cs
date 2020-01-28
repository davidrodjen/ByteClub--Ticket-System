using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public string PurchasedBy { get; set; }

        /// <summary>
        /// This will need to be set as a float int for price and calculated with sales tax
        /// </summary>
        public int Price { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime UseDate { get; set; }

    }
}
