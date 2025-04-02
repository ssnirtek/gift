using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gift
{
    public partial class LoginForm : Form
    {
        private string connectionString = @"Server=C41210\SQLEXPRESS;Database=gift;Initial Catalog=gift;Integrated Security=True;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверка учетных данных
            if (ValidateUser(username, password))
            {
                // Если данные правильные, открываем форму entrance
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Hide(); // Прячем форму логина
            }
            else
            {
                // Если данные неправильные, выводим сообщение об ошибке
                MessageBox.Show("Неправильное имя пользователя или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateUser(string username, string password)
        {
            // SQL запрос для проверки, существует ли пользователь с таким именем и паролем
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND passwords = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Добавляем параметры для предотвращения SQL инъекций
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Выполняем запрос
                        int userCount = (int)cmd.ExecuteScalar();

                        // Если количество найденных пользователей больше 0, данные правильные
                        return userCount > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                    return false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
