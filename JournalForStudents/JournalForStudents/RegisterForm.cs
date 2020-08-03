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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            rankRegisterField.Text = "Не выбрано";
            userNameField.Text = "Введите Имя";
            userNameField.ForeColor = Color.Gray;
            userLastNameField.Text = "Введите Фамилию";
            userLastNameField.ForeColor = Color.Gray;
            loginField.Text = "Название аккаунта";
            loginField.ForeColor = Color.Gray;
            passwordField.Text = "Введите пароль";
            passwordField.ForeColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Yellow;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.DarkRed;
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите Имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }    
               
        }


        private void userLastNameField_Enter(object sender, EventArgs e)
        {
            if (userLastNameField.Text == "Введите Фамилию")
            {
                userLastNameField.Text = "";
                userLastNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите Имя";
                userNameField.ForeColor = Color.Gray;
            }

        }

        private void userLastNameField_Leave(object sender, EventArgs e)
        {
            if (userLastNameField.Text == "")
            {
                userLastNameField.Text = "Введите Фамилию";
                userLastNameField.ForeColor = Color.Gray;
            }        
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Название аккаунта")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Название аккаунта";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Введите пароль")
            {
                passwordField.Text = "";
                passwordField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Введите пароль";
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(userNameField.Text == "Введите Имя" ||
               userLastNameField.Text == "Введите Фамилию" ||
               rankRegisterField.Text == "Не выбрано" ||
               loginField.Text == "Название аккаунта"||
               passwordField.Text=="Введите пароль")
            {
                MessageBox.Show("Заполните ВСЕ поля для регистрации");
                return;
            }

            if (isUsersExists())
            {
                return;
            }

            DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `rank`, `name`, `lastname`) VALUES(@login,@password,@rank,@name,@lastname)", database.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = userLastNameField.Text;
            command.Parameters.Add("@rank", MySqlDbType.VarChar).Value = rankRegisterField.Text;

            bool accountStatus = false;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно зарегистрирован");
                accountStatus = true;
            }
                              
            else
                MessageBox.Show("Аккаунт НЕ зарегистрирован");

            database.closeConnection();

            if (accountStatus)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        public Boolean isUsersExists()
        {
            DataBase database = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@login", database.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с таким названием существует");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
