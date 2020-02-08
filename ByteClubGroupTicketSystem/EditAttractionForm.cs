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
    public partial class EditAttractionForm : Form
    {
        private Attraction existingAttraction;

        public EditAttractionForm(Attraction a) //This parameter is passed from the OptionsForm's EditAttractionBtn_Click method
        {
            InitializeComponent();
            existingAttraction = a;
        }

        private void EditAttractionForm_Load(object sender, EventArgs e)
        {
            //Populate the existing attraction data on the edit attraction form
            AttractionNameTxt.Text = existingAttraction.AttractionName;
        }

        private void EditAttractionNameBtn_Click(object sender, EventArgs e)
        {
            if (IsPresent() == true) 
            {           
                //Grab the newly edited attraction's information
                existingAttraction.AttractionName = AttractionNameTxt.Text;

                try
                {
                    AttractionDb.Update(existingAttraction);
                    DialogResult = DialogResult.OK;
                }
                catch (ArgumentException) 
                {
                    MessageBox.Show("Attraction no longer exists");
                }
            }
        }

        private bool IsPresent()
        {
            if (string.IsNullOrWhiteSpace(AttractionNameTxt.Text)) 
            {
                MessageBox.Show("Cannot submit an empty form");
                return false;
            }
            return true;
        }
    }
}
