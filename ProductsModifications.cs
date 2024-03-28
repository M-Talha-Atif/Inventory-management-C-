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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace InventoryManagement
{
    public partial class ProductsModifications : Form

    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=shop;Integrated Security=True";
        public ProductsModifications()
        {
            InitializeComponent();
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
                 //   dataGridProducts.CellContentClick += dataGridProducts_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(tbProductname.Text) ||
                string.IsNullOrWhiteSpace(tbProductDescription.Text) ||
                string.IsNullOrWhiteSpace(tbProductPrice.Text) ||
                string.IsNullOrWhiteSpace(tbProductQuantity.Text) ||
                string.IsNullOrWhiteSpace(tbProductBrand.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal price;
            if (!decimal.TryParse(tbProductPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity;
            if (!int.TryParse(tbProductQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SqlCommand object for the stored procedure
                    SqlCommand command = new SqlCommand("AddProduct", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the stored procedure
                    command.Parameters.AddWithValue("@Name", tbProductname.Text);
                    command.Parameters.AddWithValue("@Description", tbProductDescription.Text);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@BrandName", tbProductBrand.Text);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    MessageBox.Show("Product added successfully!");
                    // Reload product data after removing the product
                    LoadProductsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(tbProductname.Text) ||
                string.IsNullOrWhiteSpace(tbProductDescription.Text) ||
                string.IsNullOrWhiteSpace(tbProductPrice.Text) ||
                string.IsNullOrWhiteSpace(tbProductQuantity.Text) ||
                string.IsNullOrWhiteSpace(tbProductBrand.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal price;
            if (!decimal.TryParse(tbProductPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity;
            if (!int.TryParse(tbProductQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int productId = int.Parse(tbID.Text);

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SqlCommand object for the stored procedure
                    SqlCommand command = new SqlCommand("UpdateProduct", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the stored procedure
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.Parameters.AddWithValue("@ProductName", tbProductname.Text);
                    command.Parameters.AddWithValue("@ProductDescription", tbProductDescription.Text);
                    command.Parameters.AddWithValue("@ProductPrice", price);
                    command.Parameters.AddWithValue("@ProductQuantity", quantity);
                    command.Parameters.AddWithValue("@ProductBrand", tbProductBrand.Text);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    MessageBox.Show("Product updated successfully!");
                    // Reload product data after removing the product
                    LoadProductsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check Index
            if (e.ColumnIndex == dataGridProducts.Columns["EditProduct"].Index && e.RowIndex >= 0 && e.RowIndex < dataGridProducts.Rows.Count - 1)
            {
                // Get the product ID from the selected row
                int productId = (int)dataGridProducts.Rows[e.RowIndex].Cells["ProductID"].Value;

                // Show the label and textbox for ID
                labelID.Visible = true;
                tbID.Visible = true;

                // Place the product ID in the textbox
                tbID.Text = productId.ToString();
             //   tbProductname = (int)dataGridProducts.Rows[e.RowIndex].Cells["ProductName"].Value;
            }
            // Check if Remove Product button is clicked
            else if (e.ColumnIndex == dataGridProducts.Columns["RemoveProduct"].Index && e.RowIndex >= 0)
            {
                // Get the product ID from the selected row
                int productId = (int)dataGridProducts.Rows[e.RowIndex].Cells["ProductId"].Value;

                try
                {
                    // Execute the stored procedure to remove the product
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("RemoveProductById", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Product removed successfully!");
                    }

                    // Reload product data after removing the product
                    LoadProductsData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while removing the product: " + ex.Message);
                }
            }
        }

        private void tbProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or the Backspace key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If not, mark the event as handled
                e.Handled = true;
            }
          
        }

        private void tbProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit, a decimal point, or the Backspace key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                // If not, mark the event as handled
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                // If a decimal point is already entered, mark the event as handled
                e.Handled = true;
            }
        }

        private void ProductsModifications_Load(object sender, EventArgs e)
        {
            LoadProductsData();
        }
    }
}
