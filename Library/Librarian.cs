﻿using Library.Scripts;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Librarian : Form
    {
        int counter = 0;
        public Librarian()
        {
            InitializeComponent();
        }

        private void Librerian_Load(object sender, EventArgs e)
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
                TableName.Text = "Читатели";
                request = "select [ID читателя], [ФИО читателя], Адрес, Телефон from Читатель";
            }
            else if (counter == 1)
            {
                TableName.Text = "Книги";
                request = "select [Шифр Книги], [Название Книги], Жанр, Издательство, [Цена книги], [Количество экземпляров] " +
                "from Книга, Жанр, Издательство " +
                "where Книга.[ID жанра] = Жанр.[ID Жанра] and Книга.[ID Издательства] = Издательство.[ID Издательства]";
            }
            else if (counter == 2)
            {
                TableName.Text = "Выдача книг";
                request = "select [ID выдачи],[Название Книги],[ФИО читателя],[ФИО работника]," +
                    "[Дата выдачи], Роспись from Работники, Читатель, Выдача, Книга " +
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
        private void ExitButton_Click(object sender, EventArgs e)
        {
            var form = new Auth();
            form.Show();
            Hide();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var form = new AddBook();
            form.Show();
            Hide();
        }
    }
}
