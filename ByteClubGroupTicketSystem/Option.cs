using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    /// <summary>
    /// Represents the fast pass options
    /// </summary>
    public class Option
    {
        [Key]
        public int OptionsId { get; set; }

        /// <summary>
        /// The name of the attraction
        /// </summary>
        [Required]
        public string Attraction { get; set; }

        /// <summary>
        /// Represents the time slot for entry
        /// </summary>
        [Required]
        public DateTime TimeSlot { get; set; }

        /// <summary>
        /// Represents the number of guests for that entry
        /// </summary>
        [Required]
        public int NumberOfGuests { get; set; }
    }
}
