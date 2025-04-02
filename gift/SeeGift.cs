using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace gift
{
    public partial class SeeGift : Form
    {
        string connectionString = @"Data Source=C41210\SQLEXPRESS;Initial Catalog=gift;Integrated Security=True";
        string query = "SELECT giftID, giftName, giftCategory, price, giftDescription, rating FROM gifts";


        public SeeGift()
        {
            InitializeComponent();
        }

        private void SeeGift_Load(object sender, EventArgs e)
        {

            // Загружаем данные в DataGridView
            LoadGifts();

            // Заполняем ComboBox категориями
            LoadCategories();

        

            // TODO: данная строка кода позволяет загрузить данные в таблицу "giftDataSet.gifts". При необходимости она может быть перемещена или удалена.
            this.giftsTableAdapter.Fill(this.giftDataSet.gifts);

        }

        private DataTable GetDataFromDatabase(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                if (parameters != null)
                {
                    dataAdapter.SelectCommand.Parameters.AddRange(parameters);
                }
                DataTable dataTable = new DataTable();
                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
                }
                return dataTable;
            }
        }

        private void LoadGifts(string query = "SELECT giftID, giftName, giftCategory, price, giftDescription, rating FROM gifts")
        {
            DataTable dataTable = GetDataFromDatabase(query);
            dataGridViewGifts.DataSource = dataTable;
        }

        private void LoadCategories()
        {
            // Заполняем ComboBox категориями из базы данных
            string categoryQuery = "SELECT interestCategory FROM category";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(categoryQuery, connection);
                DataTable categoryTable = new DataTable();
                dataAdapter.Fill(categoryTable);

                // Добавляем категории в ComboBox
                cmbCategoryFilter.DataSource = categoryTable;
                cmbCategoryFilter.DisplayMember = "interestCategory";  // Показываем только название категории
                cmbCategoryFilter.ValueMember = "interestCategory";    // Значение будет использоваться для фильтрации
            }
        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategoryFilter.SelectedValue.ToString();
            string query = "SELECT giftID, giftName, giftCategory, price, giftDescription, rating FROM gifts WHERE giftCategory = @category";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@category", selectedCategory)
            };

            DataTable dataTable = GetDataFromDatabase(query, parameters);
            dataGridViewGifts.DataSource = dataTable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            string query = "SELECT giftID, giftName, giftCategory, price, giftDescription, rating FROM gifts WHERE giftName LIKE @searchQuery";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@searchQuery", "%" + searchQuery + "%")
            };

            DataTable dataTable = GetDataFromDatabase(query, parameters);
            dataGridViewGifts.DataSource = dataTable;
        }

        private void dataGridViewGifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewGifts = new DataGridView();  // Пример инициализации

        }

        private void dataGridViewGifts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewGifts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewGifts.SelectedRows[0];

                if (selectedRow.Cells["giftImage"].Value != DBNull.Value && selectedRow.Cells["giftImage"].Value != null)
                {
                    string imagePath = selectedRow.Cells["giftImage"].Value.ToString();
                    string fullImagePath = Path.Combine(Application.StartupPath, "Images", imagePath);

                    if (File.Exists(fullImagePath))
                    {
                        pictureBoxGift.Image = Image.FromFile(fullImagePath);
                        pictureBoxGift.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxGift.Visible = true;
                    }
                    else
                    {
                        pictureBoxGift.Image = null;
                        pictureBoxGift.Visible = false;
                    }
                }
                else
                {
                    pictureBoxGift.Image = null;
                    pictureBoxGift.Visible = false;
                }
            }
        }
    
    }
}
