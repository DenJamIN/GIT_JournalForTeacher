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

            FillField();
        }

        private void FillField()
        {
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;
            loginField.Text = "Название аккаунта";
            loginField.ForeColor = Color.Gray;
            passwordField.Text = "Введите пароль";
            passwordField.ForeColor = Color.Gray;
            middleNameField.Text = "Введите отчество";
            middleNameField.ForeColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
        //Возможность перетаскивать окно
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
        //
        //

        //
        //Окрас крестика при наведении
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Yellow;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.DarkRed;
        }
        //
        //

        //
        //Подгрузка полей для регистрации
        private void middleNameField_Enter(object sender, EventArgs e)
        {
            if (middleNameField.Text == "Введите отчество")
            {
                middleNameField.Text = "";
                middleNameField.ForeColor = Color.Black;
            }
        }

        private void middleNameField_Leave(object sender, EventArgs e)
        {
            if (middleNameField.Text == "")
            {
                middleNameField.Text = "Введите отчество";
                middleNameField.ForeColor = Color.Gray;
            }
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }                   
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userLastNameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userLastNameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
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
        //
        //

        //
        //Кнопка Регистрации и внесение данных в БД
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя" ||
               userSurnameField.Text == "Введите фамилию" ||
               loginField.Text == "Название аккаунта" ||
               passwordField.Text == "Введите пароль")
            {
                MessageBox.Show("Заполните ВСЕ поля для регистрации");
                return;
            }

            AccountBusy accountBusy = new AccountBusy();
            if (accountBusy.isUsersExists(
                "SELECT * FROM `users` WHERE `login`=@login",
                "@login",
                Convert.ToString(loginField.Text)))
            {
                MessageBox.Show("Аккаунт с таким названием существует");
                return;
            }

            InsertAutorization();
        }
        //
        //

        private void InsertAutorization()
        {
            string insertAuotorization = 
                "INSERT INTO `users` " +
                "(`login`, `password`, `name`, `middlename`, `surname`) " +
                "VALUES(@login, @password, @name, @middlename, @surname)";
            
            DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand(insertAuotorization, database.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            command.Parameters.Add("@middlename", MySqlDbType.VarChar).Value = middleNameField.Text;

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
    }
}
