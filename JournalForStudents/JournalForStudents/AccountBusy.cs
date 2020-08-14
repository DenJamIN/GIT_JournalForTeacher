using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JournalForStudents
{
    public class AccountBusy
    {
        public Boolean isUsersExists(string sqlrequest, string protectword, string field)
        {
            DataBase database = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(sqlrequest, database.getConnection());

            command.Parameters.Add(protectword, MySqlDbType.VarChar).Value = field;

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
