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
    public partial class TicketForm : Form
    {
        //Keeps track of the outstanding tickets issued
        int outstandingTickets = 0;

        //Keeps track of the minutes to be added
        int minutes;

        //Keeps track of the current entry time
        DateTime nextEntryTime;

        //Keeps track of the last entry time
        DateTime nextEntryTimeDisplay;

        //Keeps track of the next ticket to be issued
        int nextTicket;

        public TicketForm()
        {
            InitializeComponent();
            OptionsForm options = new OptionsForm();
            DialogResult result = options.ShowDialog();

            //Once user is done inputting all the necessary inputs, and clicks ok
            //Start the time
            if (result == DialogResult.OK) 
            {
                TitleBarTime.Start();
            }

            //Display the guests with following tickets that can enter
            GuestsEnterLabel.Text = $"{OptionsForm.UserInput.FirstTicketNumber.ToString()} - " +
                                    $"{(OptionsForm.UserInput.GuestsPerWindow + OptionsForm.UserInput.FirstTicketNumber - 1).ToString()}";

            //Display next available entry
            NextEntryLabel.Text = DateTime.Now.AddMinutes(OptionsForm.UserInput.MinutesPerWindow).ToShortTimeString().ToString();
        }

        /// <summary>
        /// Executed upon first form boot up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicketForm_Load(object sender, EventArgs e)
        {
            //Set the amount of minuted to be added based on the user input in the OptionsForm
            minutes = OptionsForm.UserInput.MinutesPerWindow;

            //Set next entry time based on minutes per window that the user input in the options form
            nextEntryTime = DateTime.Now.AddMinutes(minutes).AddSeconds(-DateTime.Now.Second);

            //Set the next entry time display (only used for the list box)
            nextEntryTimeDisplay = nextEntryTime;

            //Set the next ticket to be issued
            nextTicket = OptionsForm.UserInput.GuestsPerWindow + OptionsForm.UserInput.FirstTicketNumber;

            //Display the guests with following tickets that can enter
            GuestsEnterLabel.Text = $"{OptionsForm.UserInput.FirstTicketNumber.ToString()} - " +
                                    $"{(OptionsForm.UserInput.GuestsPerWindow + OptionsForm.UserInput.FirstTicketNumber - 1).ToString()}";

            //Display next available entry
            NextEntryLabel.Text = DateTime.Now.AddMinutes(OptionsForm.UserInput.MinutesPerWindow).ToShortTimeString().ToString();
        }

        /// <summary>
        /// Displays current time in the title bar. Updates once per second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBarTime_Tick(object sender, EventArgs e)
        {
            //Grab the current time, start time from the Options from
            DateTime open = OptionsForm.UserInput.StartTime;
            DateTime currentTime = DateTime.Now.AddSeconds(-DateTime.Now.Second);

            if (currentTime < open)
            {
                this.Text = $"{DateTime.Now.ToString()} (Closed)";
            }
            else 
            {
                this.Text = $"{DateTime.Now.ToString()} (Open)";
            }

            //Only update "guests with the following tickets may now enter" only when the next available entry time has been reached
            //and when the list box isnt empty
            if (currentTime.ToString().Equals(nextEntryTime.ToString()) && listBox1.Items.Count != 0)
            {
                GuestsEnterLabel.Text = (nextTicket - outstandingTickets).ToString();

                nextEntryTime = nextEntryTime.AddMinutes(minutes);
                NextEntryLabel.Text = nextEntryTime.ToShortTimeString().ToString();

                //Remove the first item in the listBox since that time has now passed and decrement total tickets outstanding
                listBox1.Items.RemoveAt(0);
                outstandingTickets--;
                TotalTicketsLabel.Text = outstandingTickets.ToString();
            }
        }

        /// <summary>
        /// Closes the ticket form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Issues the next ticket and adds it to the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IssueTicketBtn_Click(object sender, EventArgs e)
        {
            //Only add more minutes if there are outstanding tickets issued
            if (outstandingTickets > 0)
            {
                //Add more minutes to the last entry time
                nextEntryTimeDisplay = nextEntryTimeDisplay.AddMinutes(minutes);
            }

            //Add the next ticket and their time slot to the listbox
            listBox1.Items.Add($"Ticket {nextTicket.ToString()}: " +
                $"{nextEntryTimeDisplay.ToShortTimeString().ToString()}");

            //Add one to total tickets outstanding everytime the issue button gets clicked
            outstandingTickets++;
            TotalTicketsLabel.Text = outstandingTickets.ToString();

            //Increment the next ticket to be issued
            nextTicket++;
        }
    }
}
