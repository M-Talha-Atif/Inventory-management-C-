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

namespace InventoryManagement
{
    public partial class UserMain : Form
    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=shop;Integrated Security=True";
        public UserMain()
        {
            InitializeComponent();
        }

  
      

        private void UserMain_Load(object sender, EventArgs e)
        {
            LoadProductsData();
        }

        private void LoadProductsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load user data from the database
                    SqlCommand command = new SqlCommand("SELECT ProductId, Name, Description, Quantity, Price,BrandName FROM [Product]", connection);
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);



                    // Bind the DataTable to the DataGridView
                    dataGridProducts.DataSource = dataTable;

                    // Handle button clicks
                    dataGridProducts.CellContentClick += dataGridProducts_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
