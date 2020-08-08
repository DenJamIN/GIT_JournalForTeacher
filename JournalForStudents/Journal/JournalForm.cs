using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal
{
    public partial class JournalForm : Form
    {
        public JournalForm()
        {
            InitializeComponent();
        }

        private void buttonCreateRows_Click(object sender, EventArgs e)
        {
            const int generalWidthColumn = 160;

            tableLessonDate.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "lessonDate",
                HeaderText = "Дата (дд/мм)", 
                Width = generalWidthColumn
            });

            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            tableLessonType.Columns.Add(comboBox);
            comboBox.Name = "lessonType";
            comboBox.HeaderText = "Тип занятий";
            comboBox.Width = generalWidthColumn;
            comboBox.Items.AddRange("Лекционное", "Практическое", "Индивидуальное", "Лабораторная");

            tableStudent.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "checkPresence",
                HeaderText = "Посещение",
                Width = 90 
            });
            tableStudent.Columns.Add(new DataGridViewTextBoxColumn() 
            { 
                Name = "scorePerLesson", 
                HeaderText = "Балл", 
                Width = 70 
            });

            tableStudent.Width += generalWidthColumn;
            tableLessonDate.Width += generalWidthColumn;
            tableLessonType.Width += generalWidthColumn;
        }
    }
}
