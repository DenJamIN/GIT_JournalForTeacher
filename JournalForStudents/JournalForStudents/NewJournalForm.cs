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
    public partial class NewJournalForm : Form
    {
        public NewJournalForm()
        {
            InitializeComponent();

            FiilField();
        }

        private void FiilField()
        {
            groupNameField.Text = "Введите название группы";
            groupNameField.ForeColor = Color.Gray;
            disciplineNameField.Text = "Введите название дисциплины";
            disciplineNameField.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupNameField_Enter(object sender, EventArgs e)
        {
            if (groupNameField.Text == "Введите название группы")
            {
                groupNameField.Text = "";
                groupNameField.ForeColor = Color.Black;
            }
        }

        private void groupNameField_Leave(object sender, EventArgs e)
        {
            if (groupNameField.Text == "")
            {
                groupNameField.Text = "Введите название группы";
                groupNameField.ForeColor = Color.Gray;
            }
        }

        private void disciplineNameField_Enter(object sender, EventArgs e)
        {
            if (disciplineNameField.Text == "Введите название дисциплины")
            {
                disciplineNameField.Text = "";
                disciplineNameField.ForeColor = Color.Black;
            }
        }

        private void disciplineNameField_Leave(object sender, EventArgs e)
        {
            {
                if (disciplineNameField.Text == "")
                {
                    disciplineNameField.Text = "Введите название дисциплины";
                    disciplineNameField.ForeColor = Color.Gray;
                }
            }
        }
    }
}
