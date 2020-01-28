using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    /// <summary>
    /// A class that represents the time slot for assigning tickets
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Represents how many minutes it is per window
        /// </summary>
        public int MinutesPerWindow { get; set; }

        /// <summary>
        /// Represents how guests are allowed per window
        /// </summary>
        public int GuestsPerWindow { get; set; }

        /// <summary>
        /// Represents the start time 
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Represents the end time
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Represents the first ticket number to be issued
        /// </summary>
        public int FirstTicketNumber { get; set; }
    }
}
