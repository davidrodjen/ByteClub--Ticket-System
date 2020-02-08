using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    /// <summary>
    /// A class that represents a single attraction
    /// </summary>
    public class Attraction
    {
        [Key]
        public int AttractionId { get; set; }

        [Required]
        [StringLength(100)]
        public string AttractionName { get; set; }

        public override string ToString()
        {
            return $"{AttractionName}";
        }
    }
}
