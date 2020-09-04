using Journal;
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
    public partial class JournalsListForm : Form
    {
        public JournalsListForm()
        {
            InitializeComponent();
            LoadJournalsData();
        }

        private void LoadJournalsData()
        {
            string journalsDataDB = "SELECT * FROM groups ORDER BY groups_id";

            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand(journalsDataDB, dataBase.getConnection());

            dataBase.openConnection();

            MySqlDataReader reader = command.ExecuteReader();
            var data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();
            dataBase.closeConnection();
            foreach (string[] line in data)
                tableJournalsList.Rows.Add(line);
        }

        private void buttonCreateNewJournal_Click(object sender, EventArgs e)
        {
            NewJournalForm newJournal = new NewJournalForm();
            this.Hide();
            newJournal.Show();
        }

        private void intoJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsListForm journalsList = new JournalsListForm();
            journalsList.Show();
        }

        private void buttonToJournalForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalForm journalForm = new JournalForm();
            journalForm.journalData = GetJournalId(journalName.Text.ToString());
            journalForm.Hide();
        }

        private string GetJournalId(string journalName)
        {
            string journalID = string.Empty;
            for (int symbol = 0; Char.IsDigit(journalName[symbol]); symbol++)
            {
                journalID += journalName[symbol];
            }
            return journalID;
        }

        private void tableJournalsList_Click(object sender, EventArgs e)
        {
            string selectedRows = string.Empty;

            for (int i = 0; i < tableJournalsList.Columns.Count; i++)
            {
                selectedRows += tableJournalsList[i, tableJournalsList.CurrentRow.Index].Value + " | ";
            }
            journalName.Text = selectedRows;
        }
    }
}
