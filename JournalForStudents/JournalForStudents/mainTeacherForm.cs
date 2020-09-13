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
    public partial class mainTeacherForm : Form
    {
        public mainTeacherForm()
        {
            InitializeComponent();
        }

        public void LoadData(string teacherFromLoginForm)
        {
            DataBase database = new DataBase();

            database.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @nameLogin", database.getConnection());

            MySqlParameter param = new MySqlParameter("@nameLogin", teacherFromLoginForm);
            command.Parameters.Add(param);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                labelUserID.Text = Convert.ToString(reader["users_id"]);
                nameProf.Text = Convert.ToString(reader["name"]);
                surnameProf.Text = Convert.ToString(reader["surname"]);
                middlenameProf.Text = Convert.ToString(reader["middlename"]);
            }

            database.closeConnection();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void mainTeacherForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void mainTeacherForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void intoJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsListForm journalsList = new JournalsListForm();
            journalsList.Show();
        }
    }
}