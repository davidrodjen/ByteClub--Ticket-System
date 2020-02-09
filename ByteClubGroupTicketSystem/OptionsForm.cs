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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            PopulateAttractionList();
            PopulateTimeSlotList();
            AttractionNameCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            TimeSlotCbox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (IsPresent() == true && IsNumberOfGuestsAValidInteger() == true)
            {
                //Grab the selected attraction
                Attraction a = (Attraction)AttractionNameCbox.SelectedItem;

                //Grab the selected time slot
                TimeSlot t = (TimeSlot)TimeSlotCbox.SelectedItem;

                //Create the option object
                Option o = new Option()
                {
                    Attraction = a.AttractionName,
                    TimeSlot = t.StartTime,
                    NumberOfGuests = Convert.ToInt32(NumberOfGuestsTxt.Text)
                };

                try
                {
                    OptionDb.Add(o);
                    MessageBox.Show("Option was successfully added");
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("We are having server issues");
                }
            }
        }

        private bool IsPresent()
        {
            if (string.IsNullOrWhiteSpace(AttractionNameCbox.Text) ||
                string.IsNullOrWhiteSpace(TimeSlotCbox.Text) || 
                string.IsNullOrWhiteSpace(NumberOfGuestsTxt.Text)) 
            {
                MessageBox.Show("Please fill out all of the required fields");
                return false;
            }
            return true;
        }

        private bool IsNumberOfGuestsAValidInteger()
        {
            //Used to test if user input for number of guests is a valid integer
            int validInteger;
            if (!int.TryParse(NumberOfGuestsTxt.Text, out validInteger)) 
            {
                MessageBox.Show("Please enter a valid integer for the number of guests");
                return false;
            }
            return true;
        }

        private void AddAttractionBtn_Click(object sender, EventArgs e)
        {
            //Create an add attraction object
            AddAttractionForm addAttraction = new AddAttractionForm();

            //Display the add attraction form
            DialogResult result = addAttraction.ShowDialog();

            //If user adds an attraction
            if (result == DialogResult.OK)
            {
                PopulateAttractionList();
            }
            else 
            {
                MessageBox.Show("No attraction was added");
            }
        }

        private void EditAttractionBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AttractionNameCbox.Text)) 
            {
                MessageBox.Show("Please select an attraction to edit");
                return;
            }

            Attraction attraction = (Attraction)AttractionNameCbox.SelectedItem;

            EditAttractionForm editAttraction = new EditAttractionForm(attraction);
            DialogResult result = editAttraction.ShowDialog();

            //If the attraction was successfully updated, display a success message
            //and refresh the combo box
            if (result == DialogResult.OK)
            {
                AttractionNameCbox.Text = "";
                MessageBox.Show("Attraction was successfully updated");
                PopulateAttractionList();
            }
            else 
            {
                MessageBox.Show("Nothing was edited");
            }
        }

        private void DeleteAttractionBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AttractionNameCbox.Text)) 
            {
                MessageBox.Show("Please select an attraction to delete");
                return;
            }

            //Grab the selected attraction
            Attraction selectedAttraction = (Attraction)AttractionNameCbox.SelectedItem;

            string message = $"Are you sure you want to delete {selectedAttraction.AttractionName}?";
            DialogResult result = MessageBox.Show(text: message,
                                                  caption: "Delete?",
                                                  buttons: MessageBoxButtons.YesNo,
                                                  icon: MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                try
                {
                    //Remove in database
                    AttractionDb.Delete(selectedAttraction);

                    //Remove it from the list
                    AttractionNameCbox.Items.Remove(selectedAttraction);

                    MessageBox.Show("Attraction deleted");

                    PopulateAttractionList();

                    AttractionNameCbox.Text = "";
                }
                catch (Exception) 
                {
                    MessageBox.Show("No attractions deleted");
                }
            }
        }

        private void PopulateAttractionList()
        {
            //Create an allAttraction list that is opoulated from the database
            List<Attraction> allAttractions = AttractionDb.GetAllAttractions();

            //Clear the list before adding to avoid duplicates
            AttractionNameCbox.Items.Clear();

            //Add all the attractions in the attraction combo box
            foreach (Attraction a in allAttractions)
            {
                AttractionNameCbox.Items.Add(a);
            }
        }

        private void AddTimeSlotBtn_Click(object sender, EventArgs e)
        {
            //Create an add attraction object
            AddTimeSlotForm addTimeSlot = new AddTimeSlotForm();

            //Display the add attraction form
            DialogResult result = addTimeSlot.ShowDialog();

            //If user adds an attraction
            if (result == DialogResult.OK)
            {
                PopulateTimeSlotList();
            }
            else
            {
                MessageBox.Show("No attraction was added");
            }
        }

        private void EditTimeSlotBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TimeSlotCbox.Text))
            {
                MessageBox.Show("Please select a time slot to edit");
                return;
            }

            TimeSlot timeSlot = (TimeSlot)TimeSlotCbox.SelectedItem;

            EditTimeSlotForm editTimeSlot = new EditTimeSlotForm(timeSlot);
            DialogResult result = editTimeSlot.ShowDialog();

            //If the attraction was successfully updated, display a success message
            //and refresh the combo box
            if (result == DialogResult.OK)
            {
                TimeSlotCbox.Text = "";
                MessageBox.Show("Time slot was successfully updated");
                PopulateTimeSlotList();
            }
            else
            {
                MessageBox.Show("Nothing was edited");
            }
        }

        private void DeleteTimeSlotBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TimeSlotCbox.Text))
            {
                MessageBox.Show("Please select a time slot to delete");
                return;
            }

            //Grab the selected attraction
            TimeSlot selectedTimeSlot = (TimeSlot)TimeSlotCbox.SelectedItem;

            string message = $"Are you sure you want to delete {selectedTimeSlot.StartTime.ToShortTimeString()} - " +
                             $"{selectedTimeSlot.EndTime.ToShortTimeString()}?";

            DialogResult result = MessageBox.Show(text: message,
                                                  caption: "Delete?",
                                                  buttons: MessageBoxButtons.YesNo,
                                                  icon: MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //Remove in database
                    TimeSlotDb.Delete(selectedTimeSlot);

                    //Remove it from the list
                    TimeSlotCbox.Items.Remove(selectedTimeSlot);

                    MessageBox.Show("Time slot deleted");

                    PopulateTimeSlotList();

                    TimeSlotCbox.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("No time slots deleted");
                }
            }
        }

        private void PopulateTimeSlotList()
        {
            //Create an allAttraction list that is opoulated from the database
            List<TimeSlot> allTimeSlots = TimeSlotDb.GetAllTimeSlots();

            //Clear the list before adding to avoid duplicates
            TimeSlotCbox.Items.Clear();

            //Add all the attractions in the attraction combo box
            foreach (TimeSlot t in allTimeSlots)
            {
                TimeSlotCbox.Items.Add(t);
            }
        }
    }
}