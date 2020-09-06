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

            //Считывание из БД
            LoadStudents();
        }

        private void GetJournalName(string journalData)
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();

            string getNames = "SELECT * FROM `groups` WHERE groups_id = @groups_id";

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

            createColumnsIntoDb(tableLessonDate.Columns.Count - 1);
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
            for (int i = 0; i < tableStudent.Rows.Count; i++)
            {
                for (int j = 2; j < tableStudent.Columns.Count; j += 2)
                {
                    summa += Convert.ToDouble(tableStudent[j, i].Value);
                    if (Convert.ToBoolean(tableStudent[j - 1, i].Value))
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
            InsertStudentInDB();
            //
            //
            //
            //

            //После проверки начинается подгрузка студентов из базы данных в таблицу
            //Далее разработаем передачу из таблицы в базу данных
            //Метод с цикличным sql-запросом для пробежки по всем колонам базы данных таблицы studentdata
            //И заполнение туда значений
            //Работа через кнопку Сохранить!
        }

        private void LoadStudents()
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();

            string loadStudentData = "SELECT * FROM `students` WHERE groups_id = @groups_id";
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

        private void InsertStudentInDB()
        {
            //Проверяем наличие студента в базе данных. Если его нет, то вписываем в базу. Если есть пропускаем
            for (int i = 0; i < tableStudent.Rows.Count - 1; i++)
            {
                if(!IsStoredInDB(tableStudent[0, i].Value.ToString(),labelGroupID.Text.ToString()))
                    InsertStudentDataDB(tableStudent[0, i].Value.ToString());
            }
           
        }

        private static bool IsStoredInDB(string valueCellStudent, string groupID)
        {
            DataBase dataBase = new DataBase();

            string searchData = "SELECT * FROM students WHERE surname_name= '" + valueCellStudent + "' AND groups_id= '" + groupID + "'";

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

        private void InsertStudentDataDB(string studentData)
        {
            DataBase dataBase = new DataBase();
            string insertStudentData = "INSERT INTO `students` (`surname_name`, `groups_id`) VALUES (@surname_name, @groups_id)";

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
            string createNewColumnInDb = "ALTER TABLE `studentdata` ADD COLUMN (`dataLesson" + i + "`VARCHAR(20), " + "`typeLesson" + i + "`VARCHAR(20), " + "`checkBox" + i + "`VARCHAR(20), " + "`scoreLesson" + i + "`VARCHAR(20))";

            MySqlCommand command = new MySqlCommand(createNewColumnInDb, dataBase.getConnection());
            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }
    }
}
