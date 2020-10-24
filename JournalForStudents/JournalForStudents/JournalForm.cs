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
        //Выписываем данные о студентах и их успеваемости в таблицу, которые есть в данном журнале
        public void GetStudentsDataFromDB(string journalData, string userID)
        {
            labelUserID.Text = userID;
            GetJournalName(journalData);
            
            //Автоматическое добавление столбцов в журнале
            GetAutoColumnsToJournal();

            //Считывание из БД
            GetScorePerLesson();//Получение балла за посещение
            GetStudentsName();//Получение ФИО студента
            GetStudentsScore(); //Получение успеваемости учащихся  
        }
        //Получение балла за посещение
        private void GetScorePerLesson()
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();

                string loadStudentData =
                    "SELECT * FROM `groups` " +
                    "WHERE groups_id = @groups_id";

                MySqlCommand command = new MySqlCommand(loadStudentData, dataBase.getConnection());
                command.Parameters.Add("@groups_id", MySqlDbType.Int32).Value = Convert.ToInt32(labelGroupID.Text);

                dataBase.openConnection();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        scoresPerLesson.Text = Convert.ToString(reader["scorePerLesson"]);
                    }
            dataBase.closeConnection();
        }
        //Автоматическое создание в таблицу новых колонок успеваемости 
        private void GetAutoColumnsToJournal()
        {
            while (tableLessonDate.Columns.Count <= ((GetCountColumnsDB("SELECT * FROM `studentdata`") - 2) / 4))
                AddJournalColumns();
        }
        //Получение Названия группы и дисциплины
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
        //Функция добавления колонки успеваемости
        private void AddJournalColumns()
        {
            //Дата занятия
            tableLessonDate.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "lessonDate",
                HeaderText = "Дата (дд/мм)",
                Width = generalWidthColumn
            });
            //Тип занятия
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            tableLessonType.Columns.Add(comboBox);
            comboBox.Name = "lessonType";
            comboBox.HeaderText = "Тип занятий";
            comboBox.Width = generalWidthColumn;
            comboBox.Items.AddRange("Лекционное", "Практическое", "Индивидуальное", "Лабораторная");
            //Посещаемость True/False
            tableStudent.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "checkPresence",
                HeaderText = "Посещение",
                Width = 90
            });
            //Балл за занятие
            tableStudent.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "scorePerLesson",
                HeaderText = "Балл",
                Width = 70
            });
        }
        //Функция Суммирования
        private void GetSummation(int firstDate, int secondDate)
        {
            //Создаем пустую колонку в таблице, так как данные в ней не имеют значения
            tableLessonType.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nullType",
                HeaderText = "",
                Width = generalWidthColumn
            });
            //Создаем пустую колонку в таблице, так как данные в ней не имеют значения
            tableLessonDate.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nullDate",
                HeaderText = "",
                Width = generalWidthColumn
            });
            //Создаем пустую колонку в таблице, так как данные в ней не имеют значения
            tableStudent.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "scoreSummation",
                HeaderText = "Набранные баллы",
                Width = generalWidthColumn
            });
            //Создаем пустую колонку в таблице, так как данные в ней не имеют значения
            ScoreSummation(firstDate, secondDate);
        }
        //Реализация функции суммирования
        private void ScoreSummation(int firstDate, int secondDate)//Принимаем 2 значения: первая дата и последняя дата. Чтобы определить границы 
        {
            double summa = 0;
            for (int i = 0; i < tableStudent.Rows.Count-1; i++)//Проходим по каждой строке, где вписан студент
            {              
                for (int j = firstDate*2; j < secondDate * 2; j += 2)//Проходим по данным об успеваемости студента
                {
                    //Если значения нет. Значит оно равно нулю
                    if (tableStudent[j, i].Value == null || tableStudent[j, i].Value.ToString() == "")
                        tableStudent[j, i].Value = "0";
                    summa += Convert.ToDouble(tableStudent[j, i].Value.ToString());
                    //Если студент был на занятии он получает балл за посещение, иначе ноль
                    if (!(tableStudent[j-1, i].Value.ToString() == "False") && !(tableStudent[j - 1, i].Value.ToString() == ""))
                    {
                        summa += Convert.ToDouble(scoresPerLesson.Text);
                    }
                }
                //Заполняем новую колонку суммой баллов за указанный период
                tableStudent["scoreSummation", i].Value = Convert.ToDouble(summa);
                summa = 0;
            }
        }
        //Функция суммирования всех баллов студента
        private void SummationAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Если уже есть колонка суммы, удаляем её
            if (tableStudent.Columns.Contains("scoreSummation"))
            {
                DeleteScoreSummation();
            }
            //Вставим все значения в БД, чтобы избежать пробелов в БД
            InsertJournalData();
            //Вызываем функцию суммирования и передаем ей первый и последний индекс колонки успеваемости как границу
            GetSummation(1, tableLessonDate.Columns.Count);
            MessageBox.Show("Подсчитана сумма баллов за весь период");
        }
        //Функция суммирования по дате
        private void GetSummationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Если есть колонка суммирования удаляем её
            if (tableStudent.Columns.Contains("scoreSummation"))
            {
                DeleteScoreSummation();
            }
            //Вставляем данные в БД
            InsertJournalData();
            //Вызываем форму "Суммирование по дате"
            SummationForm summationDates = new SummationForm();
            summationDates.ShowDialog();
            //Получаем границы дат, которые ввел пользователь
            string firstDate = summationDates.GetFirstDate();
            string secondDate = summationDates.GetSecondDate();

            int firstDateIndex = 1;
            int secondDateIndex = tableLessonDate.Columns.Count;
            //Если он ничего не ввел, по умолчанию высчитывается все баллы студента по дисциплине
            if (firstDate == "")
                firstDate = "начала";
            if (secondDate == "")
                secondDate = "конца";
            MessageBox.Show("Выбранный диапазон суммирования \nОт " + firstDate + "\nДо " + secondDate);
            //Ищем введенные даты в таблице журнала
            for (int i = 1; i < tableLessonDate.Columns.Count; i++)
            {
                if (firstDate == tableLessonDate[i, 0].Value.ToString())
                {
                    firstDateIndex = i;
                }

                else if (secondDate == tableLessonDate[i, 0].Value.ToString())
                {
                    secondDateIndex = i + 1;
                }
            }
            //Вызываем функцию суммирования и передаем найденные значения(иначе значения по умолчанию)
            GetSummation(firstDateIndex, secondDateIndex);
        }
        //Удаление колонки суммы баллов
        private void DeleteScoreSummation()
        {
            tableStudent.Columns.Remove("scoreSummation");
            tableLessonType.Columns.Remove("nullType");
            tableLessonDate.Columns.Remove("nullDate");
        }
        //Функция Сохранить. Переносим все изменные значения в БД
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertJournalData();
        }

        private void InsertJournalData()
        {
            //Заполнение в БД
            InsertStudentToDB();//Студентов

            InsertStudentsData();//Баллов

            InsertScorePerLesson();//Балла за занятие
        }
        //Внесение в БД балла за посещение
        private void InsertScorePerLesson()
        {
            DataBase dataBase = new DataBase();
            string insertStudentData =
                "UPDATE `groups` " +
                "SET `scorePerLesson`=@scorePerLesson " +
                "WHERE groups_id =" + labelGroupID.Text;

            MySqlCommand command = new MySqlCommand(insertStudentData, dataBase.getConnection());

            command.Parameters.Add("@scorePerLesson", MySqlDbType.VarChar).Value = scoresPerLesson.Text;

            dataBase.openConnection();
                command.ExecuteNonQuery();
            dataBase.closeConnection();
        }
        //Загружаем в таблицу ФИО студента
        private void GetStudentsName()
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
                foreach (string[] line in data)
                    tableStudent.Rows.Add(line);
            dataBase.closeConnection();
        }
        //Загружаем в таблицу успеваемость студента
        private void GetStudentsScore()
        {
            for (int studentRows = 0; studentRows < tableStudent.Rows.Count-1; studentRows++)
            {
                for (int columnScore = 1; columnScore <= (GetCountColumnsDB("SELECT * FROM `studentdata`")-2)/4; columnScore++)
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
                        string[] nameColumns = GetScoreColumnsDB(columnScore);

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
        //Сохраняем в БД ФИО студентов
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
        //Проверяем существует ли искомые данные в БД
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
        //Сохраняем в БД ФИО студента
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
        //Создаем новую колонку данных в БД, где будет храниться успеваемость студентов
        private void AddColumnsInDB(int i)
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
        //Заполняем в указанные колонки в БД данные
        private string[] GetScoreColumnsDB(int i)
        {
            string names = string.Empty;

            names += "dateLesson" + i + " " +
                "typeLesson" + i + " " +
                "checkBox" + i + " " +
                "scoreLesson" + i + " ";

            return names.Split(' ');
        }
        //Получаем количество колонок, которые уже есть в БД
        private int GetCountColumnsDB(string query)
        {
            DataBase dataBase = new DataBase();

            MySqlCommand command = new MySqlCommand(query, dataBase.getConnection());

            dataBase.openConnection();
                MySqlDataReader reader = command.ExecuteReader();
                int countColumns = reader.FieldCount;
            dataBase.closeConnection();
            //Без studentdata_id, students_id
            return countColumns;
        }
        //Получаем уникальный индентификатор студента
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
        //Сохраняем в БД уникальный идентификатор студента
        private void InsertStudentID(string id)
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
        //Сохраняем в БД успеваемость студента
        private void InsertStudentsScore(string[] nameColumns, int j, int i, string id)
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
        //Проводим сохранение всех данных студента
        private void InsertStudentsData()
        {
            string id;
            //Выполняем цикл, пока не дойдем до последней колонки в БД
            for (int columnScore = 1; columnScore <= ((GetCountColumnsDB("SELECT * FROM studentdata")-2) / 4); columnScore++)
            {
                //Заполяем в БД данные каждого студента
                for (int rowStudent = 0; rowStudent < tableStudent.Rows.Count-1; rowStudent++)
                {
                    id = GetStudentsID(labelGroupID.Text.ToString(), tableStudent[0, rowStudent].Value.ToString());
                    //Если студент не существует
                    if (!IsStoredInDB("SELECT * FROM `studentdata` WHERE students_id=" +id))
                    {
                        InsertStudentID(id);//Добавляем его
                    }
                    //Если студент уже есть в БД
                    if (IsStoredInDB("SELECT * FROM `studentdata` WHERE students_id=" + id))
                    {
                        InsertStudentsScore(GetScoreColumnsDB(columnScore),columnScore ,rowStudent, id);//Заполняем данные
                    }
                }
            }
        }
        //Создаем 2 ползунка, которые объединяют все таблицы
        private void tableStudent_Scroll(object sender, ScrollEventArgs e)
        {
            tableLessonDate.FirstDisplayedScrollingColumnIndex = tableStudent.FirstDisplayedScrollingColumnIndex;
            tableLessonType.FirstDisplayedScrollingColumnIndex = tableStudent.FirstDisplayedScrollingColumnIndex;
        }
        //Функция добавления новой колонки успеваемости в таблице журнала
        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableStudent.Columns.Contains("scoreSummation"))
            {
                DeleteScoreSummation();
            }

            AddJournalColumns();

            if (tableLessonDate.Columns.Count - 1 > ((GetCountColumnsDB("SELECT * FROM `studentdata`") - 2) / 4))
                AddColumnsInDB(tableLessonDate.Columns.Count - 1);
        }
    }
}
