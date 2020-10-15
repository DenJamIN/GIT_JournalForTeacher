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

        public string userID; 
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
            if (disciplineNameField.Text == "")
            {
                disciplineNameField.Text = "Введите название дисциплины";
                disciplineNameField.ForeColor = Color.Gray;
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

            if (IsJournalExists(userID))
            {
                MessageBox.Show("Такой журнал уже есть");
                return;
            }

            string insertNewJournal = 
                "INSERT INTO `groups` " +
                "(`groupName`,`disciplineName`, `users_id`) " +
                "VALUES(@groupname,@discipline,@usersID)";
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand(insertNewJournal, dataBase.getConnection());
            command.Parameters.Add("@groupname", MySqlDbType.VarChar).Value = groupNameField.Text;
            command.Parameters.Add("@discipline", MySqlDbType.VarChar).Value = disciplineNameField.Text;
            command.Parameters.Add("@usersID", MySqlDbType.Int32).Value = Convert.ToInt32(userID); 

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
                journalsList.LoadJournalsData(userID);
                journalsList.Show();
            }
        }

        private bool IsJournalExists(string id)
        {
            string searchJournal = "SELECT * FROM `groups` " +
                "WHERE groupName = @groupname " +
                "AND disciplineName = @discipline " +
                "AND users_id = @userID";
            DataBase database = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(searchJournal, database.getConnection());

            command.Parameters.Add("@groupname", MySqlDbType.VarChar).Value = groupNameField.Text;
            command.Parameters.Add("@discipline", MySqlDbType.VarChar).Value = disciplineNameField.Text;
            command.Parameters.Add("@userID", MySqlDbType.Int32).Value = Convert.ToInt32(id);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsListForm journalsList = new JournalsListForm();
            journalsList.LoadJournalsData(userID);
        }
    }
}
