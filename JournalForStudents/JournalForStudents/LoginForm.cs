using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JournalForStudents
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, this.loginField.Size.Height);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Yellow;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Gray;
        }

        Point lastPoint;
        private void MenuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataBase database = new DataBase();
            // DataTable - послужил для преобразования данных из БД в таблицу что можно разобрать на языке C#
            DataTable table = new DataTable();
            // MySqlDataAdapter - служит для перевода из SQL данных в данные обычные (массивы, объекты...)
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // MySqlCommand - позволяет записать SQL команду, что будет выполнена в базе данных
            MySqlCommand command = new MySqlCommand("SELECT * FROM `authorization` WHERE `login` = @uL AND `password` = @uP", database.getConnection());
            //Вместо заглушек вставляем наш пароль и логин и сравниваем с БД
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordField.Text;
            
            adapter.SelectCommand = command;
            //Переводим наши данные в таблицу (логин и пароль)
            adapter.Fill(table);
            //Если мы смогли авторизоваться значит кол-во наших стобцов в таблице изменится на один отлично от нуля
            if (table.Rows.Count > 0)
            {
                if (rankField.Text == "Студент")
                {
                    //Скрываем текущее окно и передаем значение логина переменной, для работы с базы даннами по логину пользователя
                    mainStudentForm mainStudent = new mainStudentForm();
                    mainStudent.studentFromLoginForm = Convert.ToString(loginField.Text);
                    mainStudent.LoadData();
                    this.Hide();
                    mainStudent.Show();
                }
                else if (rankField.Text == "Преподаватель")
                {
                    mainTeacherForm mainTeacher = new mainTeacherForm();
                    mainTeacher.teacherFromLoginForm = Convert.ToString(loginField.Text);
                    mainTeacher.LoadData();
                    this.Hide();
                    mainTeacher.Show();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void intoRegisterForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}