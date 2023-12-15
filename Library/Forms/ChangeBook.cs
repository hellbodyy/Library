using Library.Scripts;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class ChangeBook : Form
    {
        public ChangeBook()
        {
            InitializeComponent();
        }

        private void ChangeBook_Load(object sender, EventArgs e)
        {
            var request = $"select [Шифр Книги], [Название Книги], [Жанр], [Первый автор], Издательство, [Цена книги], [Количество экземпляров], [Год издания] " +
                "from Книга, Жанр_, Издательство " +
                "where Книга.[ID жанра] = Жанр_.[ID Жанра] " +
                $"and Книга.[ID Издательства] = Издательство.[ID Издательства] and [Шифр Книги] = '{Table.id}'";

            var bookData = DataFill.RequestToList(request);

            NumbBookTextBox.Text = bookData[0][0];
            NameTextBox.Text = bookData[0][1];
            genresTextBox.Text = bookData[0][2];
            autorTextBox.Text = bookData[0][3];
            PublishTextBox.Text = bookData[0][4];
            PriceNumUD.Text = bookData[0][5];
            CountUD.Text = bookData[0][6];
            yearTextBox.Text = bookData[0][7];

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                var numbBook = NumbBookTextBox.Text;
                var nameBook = NameTextBox.Text;
                var genresBook = genresTextBox.Text;
                var autorBook = autorTextBox.Text;
                var publishBook = PublishTextBox.Text;
                var priceBook = PriceNumUD.Value;
                var countBook = CountUD.Value;
                var yearBook = yearTextBox.Text;

                if (string.IsNullOrEmpty(numbBook) || string.IsNullOrEmpty(nameBook) || string.IsNullOrEmpty(genresBook))
                    throw new Exception();
                               
                var request = $"update Книга set [Шифр Книги] = '{numbBook}', [Название Книги] = '{nameBook}'," +
                    $"[ID Жанра] = (select [ID Жанра] from Жанр_ where [Жанр] = '{genresBook}'), [Первый автор] = '{autorBook}'," +
                    $"[Год издания] = '{yearBook}', [Цена Книги] = '{priceBook}', [Количество экземпляров] = '{countBook}'," + 
                    $"[ID Издательства] = (select [ID Издательства] from Издательство where [Издательство] = '{publishBook}')" +
                    $"where [Шифр Книги] = '{Table.id}'";

                DataFill.ApplyRequest(request);

                MessageBox.Show("Данные изменены.", "Уведомление!");
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
