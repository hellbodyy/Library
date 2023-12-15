using Library;
using Library.Scripts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelKursach.Forms
{
    public partial class ChangeWorker : Form
    {
        List<string[]> rolesContent = new List<string[]>();

        public ChangeWorker()
        {
            InitializeComponent();
        }

        private void ChangeWorker_Load(object sender, EventArgs e)
        {
            var request = $"select * from Работники where id = '{Table.id}'";
            var roomData = DataFill.RequestToList(request);

            FioTextBox.Text = roomData[0][2];
            LoginTextBox.Text = roomData[0][3];
            PassTextBox.Text = roomData[0][4];

            request = "select * from Должности where Должность != 'Директор'";
            rolesContent = DataFill.RequestToList(request);

            DataFill.UpdateComboBox(RoleComboBox, rolesContent, 1);
        }

        private void ChangeWorkeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var name = FioTextBox.Text;
                var login = LoginTextBox.Text;
                var pass = PassTextBox.Text;

                // проверка введенных данных на пустое значение
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
                    throw new Exception();

                var request = $"update Работники set [ФИО работника] = '{name}', Логин = '{login}', Пароль = '{pass}', " +
                    $"[ID должности] = '{rolesContent[RoleComboBox.SelectedIndex][0]}' " +
                    $"where id = '{Table.id}'";

                DataFill.ApplyRequest(request);

                MessageBox.Show("Запись изменена.", "Уведомление!");
            }
            catch (Exception)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var form = new Admin();
            form.Show();
            Hide();
        }
    }
}
