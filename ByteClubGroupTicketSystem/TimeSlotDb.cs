using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteClubGroupTicketSystem
{
    public static class TimeSlotDb
    {
        /// <summary>
        /// Adds a time slot to the database
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static TimeSlot Add(TimeSlot t)
        {
            using (var context = new TicketSystemContext())
            {
                context.TimeSlots.Add(t);
                context.SaveChanges();
                return t;
            }
        }

        /// <summary>
        /// Updates a selected/existing time slot 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static TimeSlot Update(TimeSlot t)
        {
            using (var context = new TicketSystemContext())
            {
                context.TimeSlots.Attach(t);
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
                return t;
            }
        }

        /// <summary>
        /// Deletes the selected/existing time slot from the database
        /// </summary>
        /// <param name="t"></param>
        public static void Delete(TimeSlot t)
        {
            using (var context = new TicketSystemContext())
            {
                context.TimeSlots.Add(t);
                context.Entry(t).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Retrieves all time slots from the database
        /// </summary>
        /// <returns></returns>
        public static List<TimeSlot> GetAllTimeSlots()
        {
            //Access the database
            TicketSystemContext db = new TicketSystemContext();

            //Get all of the time slots
            List<TimeSlot> timeSlots = (from t in db.TimeSlots
                                        orderby t.TimeSlotId
                                        select t).ToList();

            return timeSlots;
        }
    }
}
