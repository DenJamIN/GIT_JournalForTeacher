using Journal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JournalForStudents
{
    public partial class SummationForm : Form
    {
        public SummationForm()
        {
            InitializeComponent();
        }

        public void GetGeneralDate(string firstDate, string secondDate)
        {
            textBoxFirstDate.Text = firstDate;
            textBoxSecondDate.Text = secondDate;
        }

        private void buttonConfirmDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalForm journal = new JournalForm();
            journal.SummationDate(textBoxFirstDate.Text.ToString(),textBoxSecondDate.Text.ToString());
            
        }
    }
}
