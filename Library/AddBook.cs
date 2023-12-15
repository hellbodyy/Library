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
        List<string[]> genresContent = new List<string[]>();
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            var request = "select * from Жанр";
            genresContent = DataFill.RequestToList(request);

            DataFill.UpdateComboBox(genresComboBox, genresContent, 1);
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                var numberBook = NumbBookTextBox.Text;
                var nameBook = NameTextBox.Text;
                var publishBook = PublishTextBox.Text;
                var yearBook = YearTextBox.Text;
                var priceBook = PriceNumUD.Value;
                var quantity = NumbUD.Value;

                // проверка введенных данных на пустое значение
                if (string.IsNullOrEmpty(numberBook) || string.IsNullOrEmpty(nameBook))
                    throw new Exception();

                var request = $"insert into Книга values ('{numberBook}', '{nameBook}', " +
                    $"'{yearBook}', '{priceBook}', '{quantity}')" +
                    $"AND insert into Издательство ({publishBook}')";

                DataFill.ApplyRequest(request);

                MessageBox.Show("Книга добавлена.", "Уведомление!");
            }
            catch (Exception)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!");
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
