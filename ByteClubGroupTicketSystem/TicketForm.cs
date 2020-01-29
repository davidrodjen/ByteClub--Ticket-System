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
            DateTime currentTime = DateTime.Now;

            if (currentTime < open)
            {
                this.Text = $"{DateTime.Now.ToString()} (Closed)";
            }
            else 
            {
                this.Text = $"{DateTime.Now.ToString()} (Open)";
            }
        }
    }
}
