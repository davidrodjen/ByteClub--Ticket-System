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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TicketPurchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter ticket purchase information in the next window.");
            OptionsForm form = new OptionsForm();
            form.ShowDialog();
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm();
            options.ShowDialog();
        }
    }
}
