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

        /// <summary>
        /// Create an instance of the user's input so it can me accessed in other forms
        /// </summary>
        public static Options UserInput = new Options();

        private void OkBtn_Click(object sender, EventArgs e)
        {
            //Create an Options object and set the user's input to it's properties
            Options input = new Options()
            {
                MinutesPerWindow = Convert.ToInt32(MinutesPerWindowTxt.Text),
                GuestsPerWindow = Convert.ToInt32(GuestsPerWindowTxt.Text),
                StartTime = Convert.ToDateTime(StartTimeTxt.Text),
                EndTime = Convert.ToDateTime(EndTimeTxt.Text),
                FirstTicketNumber = Convert.ToInt32(FirstTicketNumTxt.Text)
            };

            //Assign the Options object with all the extrated user input to the UserInput instance
            //so it can be accessed in other forms
            UserInput = input;

            DialogResult = DialogResult.OK;
        }

        //TODO: Add Validation
    }
}
