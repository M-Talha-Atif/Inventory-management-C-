using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class LoginUser : Form
    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=shop;Integrated Security=True";

        public LoginUser()
        {
            InitializeComponent();
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SqlCommand object for the stored procedure
                    SqlCommand command = new SqlCommand("AuthenticateUser", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the stored procedure
                    command.Parameters.AddWithValue("@Username", tbUserName.Text);
                    command.Parameters.AddWithValue("@Password", tbPasswordUser.Text);

                    // Execute the stored procedure to authenticate user
                    int userId = Convert.ToInt32(command.ExecuteScalar());

                    if (userId > 0)
                    {
                        MessageBox.Show("Login successful!");
                        // Navigate to the main user form or perform other actions
                        new UserMain().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
