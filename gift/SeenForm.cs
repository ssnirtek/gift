using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace gift
{
    public partial class SeenForm : Form
    {
        string connectionString = @"Data Source=C41210\SQLEXPRESS;Initial Catalog=gift;Integrated Security=True";
        public SeenForm()
        {
            InitializeComponent();
        }

        private void SeenForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "giftDataSet.gifts". При необходимости она может быть перемещена или удалена.
            this.giftsTableAdapter.Fill(this.giftDataSet.gifts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "giftDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.giftDataSet.users);
            LoadCategories();

            LoadGifts();

            dgvGifts.ColumnCount = 5;
            dgvGifts.Columns[0].Name = "giftID";
            dgvGifts.Columns[1].Name = "giftName";
            dgvGifts.Columns[2].Name = "giftCategory";
            dgvGifts.Columns[3].Name = "price";
            dgvGifts.Columns[4].Name = "rating";
        }

        private void LoadCategories()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT category_id, interestCategory FROM category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable categories = new DataTable();
                adapter.Fill(categories);

                // Привязываем категории к ComboBox
                cmbCategory.DisplayMember = "interestCategory";
                cmbCategory.ValueMember = "category_id";
                cmbCategory.DataSource = categories;

                // Добавляем "Все категории" в начало списка
                cmbCategory.Items.Insert(0, new { interestCategory = "Все категории", category_id = 0 });
                cmbCategory.SelectedIndex = 0; // По умолчанию показываем все подарки
            }
        }

        private void LoadGifts(int categoryId = 0)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT giftID, giftName, giftCategory, price, giftImage, giftDescription FROM gifts";

                if (categoryId > 0)
                {
                    query += " WHERE giftCategory = (SELECT interestCategory FROM category WHERE category_id = @categoryId)";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                if (categoryId > 0)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@categoryId", categoryId);
                }

                DataTable gifts = new DataTable();
                adapter.Fill(gifts);

                // Привязываем данные к DataGridView
                dgvGifts.DataSource = gifts;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = (cmbCategory.SelectedItem as dynamic).category_id;

            // Загружаем подарки по выбранной категории
            LoadGifts(categoryId);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int giftID))
            {
                LoadGiftById(giftID);
            }
        }

        private void LoadGiftById(int giftID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT giftID, giftName, giftCategory, price, rating, giftDescription, giftImage " +
                               "FROM gifts WHERE giftID = @giftID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@giftID", giftID);

                DataTable giftData = new DataTable();
                adapter.Fill(giftData);

                // Если подарок найден
                if (giftData.Rows.Count > 0)
                {
                    // Заполнение TextBox2 с описанием
                    textBox2.Text = giftData.Rows[0]["giftDescription"].ToString();

                    // Загрузка изображения
                    string giftImagePath = giftData.Rows[0]["giftImage"].ToString();

                    // Путь к папке с изображениями
                    string imagePath = Path.Combine(Application.StartupPath, "images", giftImagePath);

                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath); // Отображение изображения
                    }
                    else
                    {
                        pictureBox1.Image = null; // Если изображение не найдено, показываем пустое место
                    }

                    // Загружаем данные о подарке в DataGridView
                    dgvGifts.Rows.Clear(); // Очищаем DataGridView перед добавлением новой строки
                    dgvGifts.Rows.Add(
                        giftData.Rows[0]["giftID"].ToString(),
                        giftData.Rows[0]["giftName"].ToString(),
                        giftData.Rows[0]["giftCategory"].ToString(),
                        giftData.Rows[0]["price"].ToString(),
                        giftData.Rows[0]["rating"].ToString()
                    );
                }
                else
                {
                    // Если товар с таким ID не найден, очищаем все данные
                    textBox2.Clear();
                    pictureBox1.Image = null;
                    dgvGifts.Rows.Clear();
                }
            }
        }
    }
}
