using Library.Scripts;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class ChangeReader : Form
    {
        public ChangeReader()
        {
            InitializeComponent();
        }
        private void ChangeReader_Load(object sender, EventArgs e)
        {
            var request = $"select * from Читатель where [ID читателя] = '{Table.id}'";

            var readerData = DataFill.RequestToList(request);

            FioTextBox.Text = readerData[0][1];
            AddressTextBox.Text = readerData[0][2];
            PhoneTextBox.Text = readerData[0][3];
        }
        private void ChangeReaderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var fioReader = FioTextBox.Text;
                var addressReader = AddressTextBox.Text;
                var phoneReader = PhoneTextBox.Text;


                if (string.IsNullOrEmpty(fioReader) || string.IsNullOrEmpty(addressReader) || string.IsNullOrEmpty(phoneReader))
                    throw new Exception();

                var request = $"update Читатель set [ФИО читателя] = '{fioReader}', " +
                    $"Адрес = '{addressReader}', Телефон = '{phoneReader}' " +
                    $"where [ID читателя] = '{Table.id}'";

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
            if (Application.OpenForms.OfType<Admin>().Any())
            {
                // Если есть открытая форма Admin
                Admin adminForm = Application.OpenForms.OfType<Admin>().First();
                adminForm.Show(); // Показываем форму Admin
            }
            else
            {
                // Если нет открытой формы Admin
                Librarian librarianForm = new Librarian();
                librarianForm.Show(); // Показываем форму Librarian
            }

            this.Hide(); // Скрываем текущую форму         
        }        
    }
}
