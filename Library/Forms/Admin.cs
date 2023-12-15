using Library.Forms;
using Library.Scripts;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Admin : Form
    {
        int counter = 0;
        public Admin()
        {
            InitializeComponent();          

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            FioLabel.Text = $"Добро пожаловать, {Person.fio}!";

            ChangeTableContent();
        }

        private void ChangeTableButton_Click(object sender, EventArgs e)
        {
            ChangeTableContent();
        }

        private void ChangeTableContent()
        {
            counter++;

            if (counter == 4)
            {
                counter = 0;
            }

            UpdateTable();
        }

        private void UpdateTable()
        {
            var request = "";

            if (counter == 0)
            {
                TableName.Text = "Работники";
                request = "select Работники.[ID ], Должности.Должность, Работники.[ФИО работника] as Работник, Работники.Логин, " +
                    "Работники.Пароль from Работники, Должности where Должности.[ID должности] = Работники.[ID должности]";
            }
            else if (counter == 1)
            {
                TableName.Text = "Читатели";
                request = "select [ID читателя], [ФИО читателя], Адрес, Телефон from Читатель";                              
            }
            else if (counter == 2)
            {
                TableName.Text = "Выдача книг";
                request = "select [ID выдачи], Книга.[Название Книги], Читатель.[ФИО читателя],Работники.[ФИО работника]," +
                    " Выдача.[Дата выдачи], Выдача.Роспись from Работники, Читатель, Выдача, Книга " +
                    "where Книга.[Шифр Книги] = Выдача.[Шифр Книги] and Читатель.[ID читателя] = Выдача.[ID читателя]" +
                    "and Работники.[ID] = Выдача.[ID работника]";
            }
            else if (counter == 3)
            {
                TableName.Text = "Возврат книг";
                request = "select [ID возврата],[Название Книги],[ФИО читателя],[ФИО работника], " +
                    "[Дата возврата], Роспись from Работники, Читатель, Возврат, Книга " +
                    "where Книга.[Шифр Книги] = Возврат.[Шифр книги] and Читатель.[ID читателя] = Возврат.[ID читателя] " +
                    "and Работники.[ID] = Возврат.[ID работника]";
            }
            DataFill.UpdateDataGrid(DataTable, request);
        }
        

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            // цифры и клавиша BackSpace
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var id = IdTextBox1.Text;
            var request = "";

            if (counter == 0)
            {
                request = $"delete from Работники where ID = '{id}'";                
            }
            else if (counter == 1)
            {
                request = $"delete from Читатель where [ID читателя] = '{id}'";
            }
            else if (counter == 2)
            {
                request = $"delete from Выдача where [ID выдачи] = '{id}'";
            }
            else if (counter == 3)
            {
                request = $"delete from Возврат where [ID возврата] = '{id}'";
            }

            try
            {
                DataFill.ApplyRequest(request);
                MessageBox.Show("Запись успешно удалена.", "Уведомление!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Удаление этой записи невозможно, так как на нее ссылаются другие." +
                    "Удалите их и повторите попытку.", "Ошибка!");
            }

            UpdateTable();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var form = new Auth();
            form.Show();
            Hide();
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            var id = IdTextBox.Text;

            Table.id = id;

            if (counter == 1)
            {
                var form = new ChangeReader();
                form.Show();
                Hide();
            }
        }
    }
}
