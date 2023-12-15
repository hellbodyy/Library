using Library.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBook : Form
    {

        public AddBook()
        {
            InitializeComponent();
        }        

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                var numberBook = NumbBookTextBox.Text;
                var nameBook = NameTextBox.Text;
                var autorBook = autorTextBox.Text;
                var publishBook = PublishTextBox.Text;
                var priceBook = PriceNumUD.Value;
                var countBook = CountUD.Value;
                var yearBook = yearTextBox.Text;
                var genresBook = genresTextBox.Text;

                //проверка введенных данных на пустое значение
                if (string.IsNullOrEmpty(numberBook) || string.IsNullOrEmpty(nameBook))
                    throw new Exception();

                var request = $"insert into Книга ([Шифр Книги], [Название Книги], [ID жанра], [Первый автор], [ID Издательства], [Цена книги], [Количество экземпляров], [Год издания])" +
                    $" values ('{numberBook}', '{nameBook}', " +
              $"(select [ID Жанра] from Жанр_ where [Жанр] = '{genresBook}'), '{autorBook}', " +
              $"(select [ID Издательства] from Издательство where [Издательство] = '{publishBook}'), " +
              $"'{priceBook}', '{countBook}', '{yearBook}')";

                DataFill.ApplyRequest(request);

                MessageBox.Show("Книга добавлена.", "Уведомление!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }       

        private void BackButton_Click(object sender, EventArgs e)
        {
            var form = new Librarian();
            form.Show();
            Hide();
        }
    }
}
