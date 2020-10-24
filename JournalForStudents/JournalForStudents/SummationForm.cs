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
        //Получаем первую границу даты
        public string GetFirstDate()
        {
            return textBoxFirstDate.Text;
        }
        //Получаем вторую гпаницу даты
        public  string GetSecondDate()
        {
            return textBoxSecondDate.Text;
        }
        //Скрываем форму
        private void buttonConfirmDate_Click(object sender, EventArgs e)
        {
            this.Hide();           
        }
    }
}
