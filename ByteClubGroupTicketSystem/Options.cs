using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    /// <summary>
    /// Represents the fast pass options
    /// </summary>
    public class Options
    {
        /// <summary>
        /// No argument constructor. It initializes everything to default value without having explicity
        /// </summary>
        public Options() 
        {
        }

        /// <summary>
        /// The name of the attraction
        /// </summary>
        public string Attraction { get; set; }

        /// <summary>
        /// Represents the time slot for entry
        /// </summary>
        public DateTime TimeSlot { get; set; }

        /// <summary>
        /// Represents the number of guests for that entry
        /// </summary>
        public int NumberOfGuests { get; set; }
    }
}
