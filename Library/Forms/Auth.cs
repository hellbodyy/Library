using Library.Forms;
using Library.Scripts;
using Library.Scripts;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class Auth : Form
    {
        private int loginAttempts = 0;
        private bool captchaRequired = false;
        private bool blocked = false;
        private string text = String.Empty;

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
            if (blocked)
            {
                MessageBox.Show("Система заблокирована. Приложение будет перезапущено.");
                Application.Restart();
                Environment.Exit(0);
            }
            // получение логина и пароля из текстбоксов
            var login = LoginTextBox.Text;
            var pass = PassTextBox.Text;

            // передача логина и пароля в метод, который вернет ID должности 
            var roleId = GetRoleID(login, pass);

            // Открытие формы на основе Id пользователя и закрытие текущей
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
                loginAttempts++;

                if (loginAttempts == 1)
                {
                    MessageBox.Show("Неуспешная авторизация. Введите CAPTCHA.");
                    GenerateCaptcha();
                    captchaTextBox.Visible = true;
                    captchaPictureBox.Visible = true;
                    captchaRequired = true;
                }
                else if (loginAttempts == 2 && captchaRequired)
                {
                    MessageBox.Show("Вторая неудачная попытка с CAPTCHA. Система временно заблокирована.");
                    blocked = true;
                    Timer timer = new Timer();
                    timer.Tick += Timer_Tick;
                    timer.Interval = 180000; // 3 минуты
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль. Система заблокирована.");
                    blocked = true;
                    Timer timer = new Timer();
                    timer.Tick += Timer_Tick;
                    timer.Interval = 180000; // 3 минуты
                    timer.Start();
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            blocked = false;
            MessageBox.Show("Система разблокирована.");
            (sender as Timer).Stop();
        }


        private void GenerateCaptcha()
        {
            captchaPictureBox.Image = this.CreateImage(captchaPictureBox.Width, captchaPictureBox.Height);
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }


        private int GetRoleID(string login, string pass)
        {
            try
            {
                if (string.IsNullOrEmpty(login))
                    throw new Exception("Поле Логин должно быть заполнено");

                if (string.IsNullOrEmpty(pass))
                    throw new Exception("Поле Пароль должно быть заполнено");

                var dataTable = new DataTable();

                // запрос, который получит айди, должность, фио на основе введенных логина и пароля
                var request = $"select ID, [ID Должности], [ФИО работника] from Работники where Логин = '{login}' and Пароль = '{pass}'";

                var command = new SqlCommand(request, Connection.GetSqlConnection());

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dataTable);

                Connection.OpenConnection();

                var reader = command.ExecuteReader();

                var roleId = -1;

                // запись полученных данных в статический класс
                while (reader.Read())
                {
                    Person.id = reader.GetValue(0).ToString();
                    Person.roleId = reader.GetValue(1).ToString();
                    Person.fio = (string)reader.GetValue(2);

                    roleId = Convert.ToInt32(Person.roleId);
                }

                Connection.CloseConnection();

                return roleId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
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
