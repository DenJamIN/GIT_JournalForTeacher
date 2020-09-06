using MySql.Data.MySqlClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupNameField.Text == "Введите название группы" ||
               disciplineNameField.Text == "Введите название дисциплины")
            {
                MessageBox.Show("Вы заполнили не все поля");
                return;
            }
           
            AccountBusy accountBusy = new AccountBusy();
            if (accountBusy.isUsersExists("SELECT * FROM `groups` WHERE `discipline` = @discipline",
                                          "@discipline",
                                          Convert.ToString(disciplineNameField.Text)))
            {
                return;
            }

            DataBase dataBase = new DataBase();
            // "INSERT INTO `users` (`login`, `password`, `rank`, `name`, `lastname`) VALUES(@login,@password,@rank,@name,@lastname)"
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO `journals` (`groupname`,`discipline`) VALUES(@groupname,@discipline)",
                dataBase.getConnection());

            //command.Parameters.Add("@teacher", MySqlDbType.VarChar).Value = ;
            command.Parameters.Add("@groupname", MySqlDbType.VarChar).Value = groupNameField.Text;
            command.Parameters.Add("@discipline", MySqlDbType.VarChar).Value = disciplineNameField.Text;
            //command.Parameters.Add("@password", MySqlDbType.VarChar).Value = ;

            bool accountStatus = false;

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Журнал успешно создан");
                accountStatus = true;
            }

            else
                MessageBox.Show("Ошибка создания журнала");

            dataBase.closeConnection();

            if (accountStatus)
            {
                this.Hide();
                JournalsListForm journalsList = new JournalsListForm();
                journalsList.Show();
            }
        }

    }
}
