using Library.Scripts;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Auth : Form
    {
        Connection connection = new Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            // скрывает пароль
            PassTextBox.UseSystemPasswordChar = true;
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            // получение логина и пароля из текстбоксов
            var login = LoginTextBox.Text;
            var pass = PassTextBox.Text;

            // передача логина и пароля в метод, который вернет ID должности работника
            var roleId = GetRoleID(login, pass);

            // Открытие формы на основе Id работника и закрытие текущей
            if (roleId == -1)
                return;

            if (roleId == 1)
            {
                var form = new Admin();
                form.Show();
                Hide();
            }
            else if (roleId == 2)
            {
                var form = new Librarian();
                form.Show();
                Hide();
            }            
            else
            {
                MessageBox.Show("Логин или пароль введены неверно", "Ошибка!");
            }
        }
        

       private int GetRoleID(string login, string pass)
        {
            try
            {
                if (string.IsNullOrEmpty(login))
                    throw new Exception("Поле 'Логин' должно быть заполнено!");

                if (string.IsNullOrEmpty(pass))
                    throw new Exception("Поле 'Пароль' должно быть заполнено!");

                var dataTable = new DataTable();

                // запрос, который получит айди, должность, фио на основе введенных логина и пароля
                var request = $"select ID, [ID Должности], [ФИО работника] from Работники where Логин = '{login}' and Пароль = '{pass}'";

                var command = new SqlCommand(request, connection.GetSqlConnection());

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dataTable);

                connection.OpenConnection();

                var reader = command.ExecuteReader();

                // запись полученных данных в статический класс
                while (reader.Read())
                {
                    Person.id = (int)reader.GetValue(0);
                    Person.roleId = (int)reader.GetValue(1);
                    Person.fio = (string)reader.GetValue(2);
                }

                connection.CloseConnection();

                return Person.roleId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return -1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                PassTextBox.UseSystemPasswordChar = false;
            else
                PassTextBox.UseSystemPasswordChar = true;
        }
    }
}
