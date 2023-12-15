using HotelKursach.Forms;
using Library.Scripts;
using System;
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
            FioLabel.Text = $"Здравствуйте, {Person.fio}!";

            ChangeTableContent();
        }

        private void ChangeTableButton_Click(object sender, EventArgs e)
        {
            ChangeTableContent();
        }

        private void ChangeTableContent()
        {
            counter++;

            if (counter == 3)
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
                TableName.Text = "Читатели";
                request = "select [ID читателя], [ФИО читателя], Адрес, Телефон from Читатель";
            }
            else if (counter == 1)
            {
                TableName.Text = "Выдача книг";
                request = "select [ID выдачи], Книга.[Название Книги], Читатель.[ФИО читателя],Работники.[ФИО работника]," +
                    " Выдача.[Дата выдачи], Выдача.Роспись from Работники, Читатель, Выдача, Книга " +
                    "where Книга.[Шифр Книги] = Выдача.[Шифр Книги] and Читатель.[ID читателя] = Выдача.[ID читателя]" +
                    "and Работники.[ID] = Выдача.[ID работника]";
            }
            else if (counter == 2)
            {
                TableName.Text = "Работники";
                request = "select Работники.[ID ], Должности.Должность, Работники.[ФИО работника] as Работник, Работники.Логин, " +
                    "Работники.Пароль from Работники, Должности where Должности.[ID должности] = Работники.[ID должности]";
            }

            DataFill.UpdateDataGrid(DataTable, request);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            var id = IdTextBox.Text;

            Table.id = id;

            if (counter == 0)
            {
                ////var form = new ChangeRoom();
                //form.Show();
                Hide();
            }
            else if (counter == 1)
            {
                //var form = new ChangeService();
                //form.Show();
                Hide();
            }
            else if (counter == 2)
            {
                var form = new ChangeWorker();
                form.Show();
                Hide();
            }  
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
        private void ExitButton_Click(object sender, EventArgs e)
        {
            var form = new Auth();
            form.Show();
            Hide();
        }
    }
}
