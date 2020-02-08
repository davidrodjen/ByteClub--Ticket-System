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
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
    }
}