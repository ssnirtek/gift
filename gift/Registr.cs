using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gift
{
    public partial class Registr : Form
    {
        private string connectionString = @"Data Source=C41210\SQLEXPRESS;Initial Catalog=gift;Integrated Security=True";
        public Registr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем данные из элементов управления
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string fio = txtFio.Text;
            DateTime birthDate = dtpBirthDate.Value;

            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fio))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Формируем SQL-запрос для вставки данных в таблицу users
            string query = "INSERT INTO users (username, passwords, email, fio, birthDate) VALUES (@username, @password, @email, @fio, @birthDate)";

            try
            {
                // Создаем подключение к базе данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открываем подключение
                    connection.Open();

                    // Создаем команду для выполнения запроса
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавляем параметры в команду
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@fio", fio);
                        command.Parameters.AddWithValue("@birthDate", birthDate);

                        // Выполняем команду
                        command.ExecuteNonQuery();
                    }
                }

                // Выводим сообщение об успешной регистрации
                MessageBox.Show("Регистрация прошла успешно!");

                // Очистка полей после успешной регистрации
                txtUsername.Clear();
                txtPassword.Clear();
                txtEmail.Clear();
                txtFio.Clear();
                dtpBirthDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
