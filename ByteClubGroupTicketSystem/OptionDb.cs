using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    class OptionDb
    {
        /// <summary>
        /// Adds an option setting to the database
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Option Add(Option o)
        {
            using (var context = new TicketSystemContext())
            {
                context.Options.Add(o);
                context.SaveChanges();
                return o;
            }
        }

        /// <summary>
        /// Updates an existing option from the database
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Option Update(Option o)
        {
            using (var context = new TicketSystemContext())
            {
                context.Options.Attach(o);
                context.Entry(o).State = EntityState.Modified;
                context.SaveChanges();
                return o;
            }
        }

        /// <summary>
        /// Deletes a selected existing option from the database
        /// </summary>
        /// <param name="o"></param>
        public static void Delete(Option o)
        {
            using (var context = new TicketSystemContext())
            {
                context.Options.Add(o);
                context.Entry(o).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public static List<Option> GetAllOptions()
        {
            //Access the database
            TicketSystemContext db = new TicketSystemContext();

            //Get all of the attractions
            List<Option> options = (from o in db.Options
                                        orderby o.OptionsId
                                        select o).ToList();

            return options;
        }
    }
}
