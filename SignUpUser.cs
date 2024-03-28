using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class SignUpUser : Form
    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=shop;Integrated Security=True";

        public SignUpUser()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        private void btnSignUpUser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbEmailUser.Text) ||
               string.IsNullOrWhiteSpace(tbUserName.Text) ||
               string.IsNullOrWhiteSpace(tbPasswordUser.Text)
             )
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(tbEmailUser.Text))
            {
                MessageBox.Show("Please fill correct email format like abc@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SqlCommand object for the stored procedure
                    SqlCommand command = new SqlCommand("SignUpUser", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the stored procedure
                    command.Parameters.AddWithValue("@Email", tbEmailUser.Text);
                    command.Parameters.AddWithValue("@Username", tbUserName.Text);
                    command.Parameters.AddWithValue("@Password", tbPasswordUser.Text);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    MessageBox.Show("User signed up successfully!");

                    // Close the form or navigate to another form
                    new Main().Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
