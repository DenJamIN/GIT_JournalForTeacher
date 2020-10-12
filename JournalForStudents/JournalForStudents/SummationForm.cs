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
            FillField();
        }

        private void FillField()
        {
            textBoxFirstDate.Text = "начала";
            textBoxFirstDate.ForeColor = Color.Gray;
            textBoxSecondDate.Text = "конца";
            textBoxSecondDate.ForeColor = Color.Gray;
        }

        public string GetFirstDate()
        {
            return textBoxFirstDate.Text;
        }

        public  string GetSecondDate()
        {
            return textBoxSecondDate.Text;
        }

        private void buttonConfirmDate_Click(object sender, EventArgs e)
        {
            this.Hide();           
        }

        private void textBoxFirstDate_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstDate.Text == "начала")
            {
                textBoxFirstDate.Text = "";
                textBoxFirstDate.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstDate_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstDate.Text == "")
            {
                textBoxFirstDate.Text = "начала";
                textBoxFirstDate.ForeColor = Color.Gray;
            }
        }

        private void textBoxSecondDate_Enter(object sender, EventArgs e)
        {
            if (textBoxSecondDate.Text == "конца")
            {
                textBoxSecondDate.Text = "";
                textBoxSecondDate.ForeColor = Color.Black;
            }
        }

        private void textBoxSecondDate_Leave(object sender, EventArgs e)
        {
            if (textBoxSecondDate.Text == "")
            {
                textBoxSecondDate.Text = "конца";
                textBoxSecondDate.ForeColor = Color.Gray;
            }
        }
    }
}
