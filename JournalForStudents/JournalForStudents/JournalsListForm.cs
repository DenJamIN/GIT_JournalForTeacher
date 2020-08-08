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
    public partial class JournalsListForm : Form
    {
        public JournalsListForm()
        {
            InitializeComponent();
        }

        private void buttonCreateNewJournal_Click(object sender, EventArgs e)
        {
            JournalForm journalForm = new JournalForm();
            this.Hide();
            journalForm.Show();
        }

        private void intoJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsListForm journalsList = new JournalsListForm();
            journalsList.Show();
        }
    }
}
