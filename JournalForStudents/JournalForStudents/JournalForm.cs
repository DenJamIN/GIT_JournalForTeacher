using JournalForStudents;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Journal
{
    public partial class JournalForm : Form
    {
        public JournalForm()
        {
            InitializeComponent();
        }

        public void GetStudentsDataFromDB(string journalData)
        {
            GetJournalName(journalData);
            
            //Автоматическое добавление столбцов в журнале
            GetAutoColumnsToJournal();

            //Считывание из БД
            LoadStudents();
            LoadStudentsScore();    
        }
       
        private void GetAutoColumnsToJournal()
        {
            while (tableLessonDate.Columns.Count <= ((CountColumnsDB("SELECT * FROM `studentdata`") - 2) / 4))
                CreateJournalColumns();
        }

        private void GetJournalName(string journalData)
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();

            string getNames = "SELECT * FROM `groups` " +
                "WHERE groups_id = @groups_id";

            MySqlCommand command = new MySqlCommand(getNames, dataBase.getConnection());
            MySqlParameter parameter = new MySqlParameter("@groups_id", journalData);
            command.Parameters.Add(parameter);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                labelGroupID.Text = Convert.ToString(reader["groups_id"]);
                labelGroupName.Text = Convert.ToString(reader["groupName"]);
                labelDisciplineName.Text = Convert.ToString(reader["disciplineName"]);
            }

            dataBase.closeConnection();
        }

        const int generalWidthColumn = 160;
        private void buttonCreateRows_Click(object sender, EventArgs e)
        {
            if (tableStudent.Columns.Contains("scoreSummation"))
            {
                DeleteScoreSummation();
            }

            CreateJournalColumns();

            if (tableLessonDate.Columns.Count - 1 > ((CountColumnsDB("SELECT * FROM `studentdata`") - 2) / 4))
                createColumnsIntoDb(tableLessonDate.Columns.Count - 1);
        }

        private void CreateJournalColumns()
        {
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

            SlideTables();
        }

        private void buttonForSummation_Click(object sender, EventArgs e)
        {
            if (tableStudent.Columns.Contains("scoreSummation"))
            {
                DeleteScoreSummation();
            }

            tableLessonType.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nullType",
                HeaderText = "",
                Width = generalWidthColumn
            });

            tableLessonDate.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nullDate",
                HeaderText = "",
                Width = generalWidthColumn
            });


            tableStudent.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "scoreSummation",
                HeaderText = "Набранные баллы",
                Width = generalWidthColumn
            });

            ScoreSummation();

            SlideTables();
        }

        private void ScoreSummation()
        {        
            double summa = 0;
            for (int i = 0; i < tableStudent.Rows.Count-1; i++)
            {              
                for (int j = 2; j < tableStudent.Columns.Count; j += 2)
                {
                    if (tableStudent[j, i].Value.ToString() == "")
                        tableStudent[j, i].Value = "0";
                    summa += Convert.ToDouble(tableStudent[j, i].Value.ToString());
                    if (!(tableStudent[j-1, i].Value.ToString() == "False") && !(tableStudent[j - 1, i].Value.ToString() == ""))
                    {
                        summa += Convert.ToDouble(scoresPerLesson.Text);
                    }
                }
                tableStudent["scoreSummation", i].Value = Convert.ToDouble(summa);
                summa = 0;
            }
        }

        private void SlideTables()
        {
            tableStudent.Width += generalWidthColumn;
            tableLessonDate.Width += generalWidthColumn;
            tableLessonType.Width += generalWidthColumn;
        }

        private void DeleteScoreSummation()
        {
            tableStudent.Columns.Remove("scoreSummation");
            tableLessonType.Columns.Remove("nullType");
            tableLessonDate.Columns.Remove("nullDate");

            tableStudent.Width -= generalWidthColumn;
            tableLessonDate.Width -= generalWidthColumn;
            tableLessonType.Width -= generalWidthColumn;
        }

        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonSafeChanges_Click(object sender, EventArgs e)
        {
            //Заполнение в БД
            InsertStudentToDB();//Студентов
            
            InsertScoreToDB();//Баллов
        }

        private void LoadStudents()
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();

            string loadStudentData = 
                "SELECT * FROM `students` " +
                "WHERE groups_id = @groups_id";

            MySqlCommand command = new MySqlCommand(loadStudentData, dataBase.getConnection());

            MySqlParameter param = new MySqlParameter("@groups_id", labelGroupID.Text);
            command.Parameters.Add(param);

            MySqlDataReader reader = command.ExecuteReader();
            var data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[1]);
                data[data.Count - 1][0] = reader[1].ToString();

            }
            reader.Close();
            dataBase.closeConnection();
            foreach (string[] line in data)
                tableStudent.Rows.Add(line);

            dataBase.closeConnection();
        }
        
        private void LoadStudentsScore()
        {
            for (int studentRows = 0; studentRows < tableStudent.Rows.Count-1; studentRows++)
            {
                for (int columnScore = 1; columnScore <= (CountColumnsDB("SELECT * FROM `studentdata`")-2)/4; columnScore++)
                {
                    DataBase dataBase = new DataBase();

                    dataBase.openConnection();

                    string loadStudentData =
                        "SELECT * FROM `studentdata` " +
                        "WHERE students_id = @students_id";

                    MySqlCommand command = new MySqlCommand(loadStudentData, dataBase.getConnection());

                    command.Parameters.Add("@students_id", MySqlDbType.VarChar).Value 
                        = GetStudentsID(labelGroupID.Text.ToString(), tableStudent[0, studentRows].Value.ToString());

                    MySqlDataReader reader = command.ExecuteReader();

                    string[] nameColumns = NameColumnsDB(columnScore);

                    while (reader.Read())
                    {
                        tableLessonDate[columnScore, 0].Value = Convert.ToString(reader[nameColumns[0]]);
                        tableLessonType[columnScore, 0].Value = Convert.ToString(reader[nameColumns[1]]);
                        tableStudent[columnScore*2-1, studentRows].Value = (reader[nameColumns[2]]);
                        tableStudent[columnScore*2, studentRows].Value = Convert.ToString(reader[nameColumns[3]]);
                    }
                    reader.Close();

                    dataBase.closeConnection();
                }
            }
        }

        private void InsertStudentToDB()
        {
            //Проверяем наличие студента в базе данных. Если его нет, то вписываем в базу. Если есть пропускаем
            
            for (int i = 0; i < tableStudent.Rows.Count - 1; i++)
            {
                string searchData = 
                    "SELECT * FROM students " +
                    "WHERE surname_name= '" 
                    + tableStudent[0, i].Value.ToString() + "' " +
                    "AND groups_id= '" + labelGroupID.Text.ToString() + "'";
                
                if (!IsStoredInDB(searchData))
                    InsertStudentData(tableStudent[0, i].Value.ToString());
            }
           
        }

        private static bool IsStoredInDB(string searchData)
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand(searchData, dataBase.getConnection());
            MySqlDataReader reader = command.ExecuteReader();           

            if (!reader.Read())
            {
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                return true;
            }
            
        }

        private void InsertStudentData(string studentData)
        {
            DataBase dataBase = new DataBase();
            string insertStudentData = 
                "INSERT INTO `students` (`surname_name`, `groups_id`) " +
                "VALUES (@surname_name, @groups_id)";

            MySqlCommand command = new MySqlCommand(insertStudentData, dataBase.getConnection());

            command.Parameters.Add("@surname_name", MySqlDbType.VarChar).Value = studentData;
            command.Parameters.Add("@groups_id", MySqlDbType.VarChar).Value = labelGroupID.Text;

            dataBase.openConnection();

            command.ExecuteNonQuery();

            dataBase.closeConnection();
        }

        private void createColumnsIntoDb(int i)
        {
            DataBase dataBase = new DataBase();

            //Create new columns in data base
            string createNewColumnInDb = 
                "ALTER TABLE `studentdata` " +
                "ADD COLUMN (`dateLesson" + i + "`VARCHAR(30), " + 
                "`typeLesson" + i + "`VARCHAR(20), " + 
                "`checkBox" + i + "`VARCHAR(10), " + 
                "`scoreLesson" + i + "`VARCHAR(10))";

            MySqlCommand command = new MySqlCommand(createNewColumnInDb, dataBase.getConnection());

            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        private string[] NameColumnsDB(int i)
        {
            string names = string.Empty;

            names += "dateLesson" + i + " " +
                "typeLesson" + i + " " +
                "checkBox" + i + " " +
                "scoreLesson" + i + " ";

            return names.Split(' ');
        }

        private int CountColumnsDB(string query)
        {
            DataBase dataBase = new DataBase();

            MySqlCommand command = new MySqlCommand(query, dataBase.getConnection());

            dataBase.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            int countColumns = reader.FieldCount;

            dataBase.closeConnection();

            //Without studentdata_id, students_id
            return countColumns;
        }

        private string GetStudentsID(string groupID, string studentName)
        {
            string id = string.Empty;
            string searchStudentID =
                "SELECT * FROM students " +
                "WHERE groups_id = @groups_id " +
                "AND surname_name = @surname_name";

            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand(searchStudentID, dataBase.getConnection());

            dataBase.openConnection();

            command.Parameters.Add("@groups_id", MySqlDbType.VarChar).Value = groupID;
            command.Parameters.Add("@surname_name", MySqlDbType.VarChar).Value = studentName;

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                id = reader[0].ToString();
            }
            reader.Close();

            dataBase.closeConnection();

            return id;
        }
           
        private void InsertToStudentData(string id)
        {
            string insertStudentsID = 
                "INSERT INTO studentdata(`students_id`) " +
                "VALUES(@students_id)";

            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand(insertStudentsID, dataBase.getConnection());

            dataBase.openConnection();

            command.Parameters.Add("@students_id", MySqlDbType.VarChar).Value = id;
            command.ExecuteNonQuery();

            dataBase.closeConnection();
        }

        private void InsertScoreStudentData(string[] nameColumns, int j, int i, string id)
        {             
            string insertScore = 
                "UPDATE `studentdata` " +
                "SET `" + nameColumns[0] + "`=@dateLesson, `" +
                nameColumns[1] +"`=@typeLesson, `" +
                nameColumns[2] + "`=@checkBox, `" +
                nameColumns[3] + "`=@scoreLesson " +
                "WHERE students_id =" + id;
  
            int columnNumber = j + j - 1;
            if (tableStudent[columnNumber, i].Value == null)
                tableStudent[columnNumber, i].Value = false;

            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand(insertScore, dataBase.getConnection());

            command.Parameters.Add("@dateLesson", MySqlDbType.VarChar).Value = tableLessonDate[j,0].Value;
            command.Parameters.Add("@typeLesson", MySqlDbType.VarChar).Value = tableLessonType[j,0].Value;
            command.Parameters.Add("@checkBox", MySqlDbType.VarChar).Value = tableStudent[columnNumber,i].Value;
            command.Parameters.Add("@scoreLesson", MySqlDbType.VarChar).Value =
                (tableStudent[columnNumber + 1, i].Value == DBNull.Value)
                ? "0"
                : tableStudent[columnNumber + 1, i].Value;

            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }
        
        private void InsertScoreToDB()
        {
            string id;

            for (int columnScore = 1; columnScore <= ((CountColumnsDB("SELECT * FROM studentdata")-2) / 4); columnScore++)
            { 

                for (int rowStudent = 0; rowStudent < tableStudent.Rows.Count-1; rowStudent++)
                {
                    id = GetStudentsID(labelGroupID.Text.ToString(), tableStudent[0, rowStudent].Value.ToString());

                    if (!IsStoredInDB("SELECT * FROM `studentdata` WHERE students_id=" +id))
                    {
                        InsertToStudentData(id);
                    }

                    if (IsStoredInDB("SELECT * FROM `studentdata` WHERE students_id=" + id))
                    {
                        InsertScoreStudentData(NameColumnsDB(columnScore),columnScore ,rowStudent, id);
                    }

                }

            }

        }

        private void intoJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsListForm journalsList = new JournalsListForm();
            journalsList.Show();
        }
    }
}
