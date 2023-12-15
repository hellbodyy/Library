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
    public partial class AddReader : Form
    {
        public AddReader()
        {
            InitializeComponent();
        }

        private void AddReaderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var fioReader = FioTextBox.Text;
                var addressReader = AddressTextBox.Text;
                var phoneReader = PhoneTextBox.Text;               

                if (string.IsNullOrEmpty(fioReader) || string.IsNullOrEmpty(addressReader)|| string.IsNullOrEmpty(phoneReader))
                    throw new Exception();

                var request = $"insert into Читатель ([ФИО читателя], Адрес, Телефон)" +
                    $"values('{fioReader}','{addressReader}','{phoneReader}')";

                DataFill.ApplyRequest(request);

                MessageBox.Show("Читатель добавлен.", "Уведомление!");
            }
            catch(Exception ex)
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
