using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteClubGroupTicketSystem
{
    public partial class AddTimeSlotForm : Form
    {
        public AddTimeSlotForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a single time slot to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTimeSlotBtn_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == true) 
            {
                //Create a time slot object
                TimeSlot time = new TimeSlot()
                {
                    StartTime = Convert.ToDateTime(StartTimeTxt.Text),
                    EndTime = Convert.ToDateTime(EndTimeTxt.Text),
                    TimeSlotLength = TimeSpan.Parse((Convert.ToDateTime(EndTimeTxt.Text) - Convert.ToDateTime(StartTimeTxt.Text)).ToString())
                };

                try
                {
                    TimeSlotDb.Add(time);
                    MessageBox.Show("Time slot successfully added");
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("We're currently having server issues");
                }
            }
        }

        private bool IsDataValid()
        {
            if (IsPresent() == true && IsInputValid() == true) 
            {
                return true;
            }
            return false;
        }

        private bool IsInputValid()
        {
            //Variables to be used for testing, for valid integer and date time input
            DateTime validDateTime;

            if (!DateTime.TryParse(StartTimeTxt.Text, out validDateTime) ||
                !DateTime.TryParse(EndTimeTxt.Text, out validDateTime))
            {
                MessageBox.Show("Start time and End time must be a valid date time input. Ex: (10:00 AM/PM)");
                return false;
            }
            return true;
        }

        private bool IsPresent()
        {
            if (string.IsNullOrWhiteSpace(StartTimeTxt.Text) || string.IsNullOrWhiteSpace(EndTimeTxt.Text)) 
            {
                MessageBox.Show("Cannot submit an empty form");
                return false;
            }
            return true;
        }
    }
}
