using JournalForStudents;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace JournalForStudents
{
    class CreateDB
    {
        public CreateDB()
        {
            NewDB();
            UseDB();
        }

        private static void NewDB()
        {
            DataBase dataBase = new DataBase();

            //Create new columns in data base
            string createNewDB =
                "CREATE DATABASE IF NOT EXISTS el_journal";

            MySqlCommand command = new MySqlCommand(createNewDB, dataBase.getConnection());

            dataBase.openConnection();
                command.ExecuteNonQuery();
            dataBase.closeConnection();
        }
        private static void UseDB()
        {
            DataBase dataBase = new DataBase();

            //Create new columns in data base
            string useDB =
                "USE el_journal";
            string createTableGroups =
                "CREATE TABLE IF NOT EXISTS groups" +
                "(groups_id INT(255) NOT NULL AUTO_INCREMENT," +
                "groupName VARCHAR(200) NOT NULL," +
                "disciplineName VARCHAR(200) NOT NULL," +
                "users_id INT(255) NOT NULL," +
                "scorePerLesson VARCHAR(3)," +
                "PRIMARY KEY (groups_id))";
            string createTableUsers =
                "CREATE TABLE IF NOT EXISTS users" +
                "(users_id INT(255) NOT NULL AUTO_INCREMENT," +
                "surname VARCHAR(100) NOT NULL," +
                "name VARCHAR(100) NOT NULL," +
                "middlename VARCHAR(100)," +
                "login VARCHAR(200) NOT NULL," +
                "password VARCHAR(200) NOT NULL," +
                "PRIMARY KEY (users_id))";
            string createTableStudents =
               "CREATE TABLE IF NOT EXISTS students" +
               "(students_id INT(255) NOT NULL AUTO_INCREMENT," +
               "surname_name VARCHAR(255) NOT NULL," +
               "groups_id INT(255) NOT NULL," +
               "PRIMARY KEY (students_id))";
            string createTableStudentData =
               "CREATE TABLE IF NOT EXISTS studentdata" +
               "(studentData_id INT(255) NOT NULL AUTO_INCREMENT," +
               "students_id INT(255) NOT NULL," +
               "PRIMARY KEY (studentData_id))";
            string groupsGiveTether =
               "ALTER TABLE `groups`" +
               "ADD CONSTRAINT `groups_ibfk_1` " +
               "FOREIGN KEY(`users_id`) " +
               "REFERENCES `users`(`users_id`) " +
               "ON DELETE RESTRICT " +
               "ON UPDATE RESTRICT";
            string studentsGiveTether =
                "ALTER TABLE `students` " +
                "ADD CONSTRAINT `students_ibfk_1` " +
                "FOREIGN KEY (`groups_id`) " +
                "REFERENCES `groups`(`groups_id`) " +
                "ON DELETE RESTRICT " +
                "ON UPDATE RESTRICT;";
            string studentdataGiveTether = 
                "ALTER TABLE `studentdata` " +
                "ADD CONSTRAINT `studentdata_ibfk_1` " +
                "FOREIGN KEY (`students_id`) " +
                "REFERENCES `students`(`students_id`) " +
                "ON DELETE RESTRICT " +
                "ON UPDATE RESTRICT;";

            MySqlCommand chooseDB = new MySqlCommand(useDB, dataBase.getConnection());
            MySqlCommand groupsTable = new MySqlCommand(createTableGroups, dataBase.getConnection());
            MySqlCommand usersTable = new MySqlCommand(createTableUsers, dataBase.getConnection());
            MySqlCommand studentsTable = new MySqlCommand(createTableStudents, dataBase.getConnection());
            MySqlCommand studentdataTable = new MySqlCommand(createTableStudentData, dataBase.getConnection());
            MySqlCommand groupsTether = new MySqlCommand(groupsGiveTether, dataBase.getConnection());
            MySqlCommand studentsTether = new MySqlCommand(studentsGiveTether, dataBase.getConnection());
            MySqlCommand studentdataTether = new MySqlCommand(studentdataGiveTether, dataBase.getConnection());

            dataBase.openConnection();
                chooseDB.ExecuteNonQuery();
                groupsTable.ExecuteNonQuery();
                usersTable.ExecuteNonQuery();
                studentsTable.ExecuteNonQuery();
                studentdataTable.ExecuteNonQuery();
                try//Проверяем на наличие связей и обходим дубликат
                {
                    groupsTether.ExecuteNonQuery();
                    studentsTether.ExecuteNonQuery();
                    studentdataTether.ExecuteNonQuery();
                }
                catch (MySqlException)
                {
                dataBase.closeConnection();
                }       
            dataBase.closeConnection();
        }
    }
}
