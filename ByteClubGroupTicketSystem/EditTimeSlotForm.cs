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
    public partial class EditTimeSlotForm : Form
    {
        private TimeSlot existingTimeSlot;

        public EditTimeSlotForm(TimeSlot t)
        {
            InitializeComponent();
            existingTimeSlot = t;
        }

        private void EditTimeSlotForm_Load(object sender, EventArgs e)
        {
            //Populate the existing time slot data on the edit time slot form
            StartTimeTxt.Text = existingTimeSlot.StartTime.ToShortTimeString();
            EndTimeTxt.Text = existingTimeSlot.EndTime.ToShortTimeString();
        }

        private void EditTimeSlotBtn_Click(object sender, EventArgs e)
        {
            if (IsDataValid() == true) 
            {
                //Grab the newly inputted values
                existingTimeSlot.StartTime = Convert.ToDateTime(StartTimeTxt.Text);
                existingTimeSlot.EndTime = Convert.ToDateTime(EndTimeTxt.Text);
                existingTimeSlot.TimeSlotLength = TimeSpan.Parse((Convert.ToDateTime(EndTimeTxt.Text) - Convert.ToDateTime(StartTimeTxt.Text)).ToString());

                try
                {
                    TimeSlotDb.Update(existingTimeSlot);
                    DialogResult = DialogResult.OK;
                }
                catch (ArgumentException) 
                {
                    MessageBox.Show("Time slot no longer exists");
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
