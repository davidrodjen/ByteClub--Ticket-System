using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteClubGroupTicketSystem
{
    public partial class AddAttractionForm : Form
    {
        public AddAttractionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a single attraction to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAttractionNameBtn_Click(object sender, EventArgs e)
        {
            //Create an attraction object
            Attraction a = new Attraction() 
            {
                AttractionName = AttractionNameTxt.Text
            };

            try
            {
                AttractionDb.Add(a);
                MessageBox.Show("Attraction Successfully added");
                DialogResult = DialogResult.OK;
            }
            catch 
            {
                MessageBox.Show("We're currently having server issues");
            }
        }

        //TODO: Add input validation
    }
}
