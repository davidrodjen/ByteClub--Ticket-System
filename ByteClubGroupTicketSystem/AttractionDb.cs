using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    public static class AttractionDb
    {
        /// <summary>
        /// Adds an attraction to the database
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Attraction Add(Attraction a) 
        {
            using (var context = new TicketSystemContext()) 
            {
                context.Attractions.Add(a);
                context.SaveChanges();
                return a;
            }
        }

        /// <summary>
        /// Updates an existing attraction selected by the user from the database
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Attraction Update(Attraction a) 
        {
            using (var context = new TicketSystemContext()) 
            {
                context.Attractions.Attach(a);
                context.Entry(a).State = EntityState.Modified;
                context.SaveChanges();
                return a;
            }
        }

        /// <summary>
        /// Deletes the selected attraction to the database
        /// </summary>
        /// <param name="a"></param>
        public static void Delete(Attraction a) 
        {
            using (var context = new TicketSystemContext()) 
            {
                context.Attractions.Add(a);
                context.Entry(a).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Retrieves all attractions from the database
        /// </summary>
        /// <returns></returns>
        public static List<Attraction> GetAllAttractions()
        {
            //Access the database
            TicketSystemContext db = new TicketSystemContext();

            //Get all of the attractions
            List<Attraction> attractions = (from a in db.Attractions
                                            orderby a.AttractionName
                                            select a).ToList();

            return attractions;
        }
    }
}
