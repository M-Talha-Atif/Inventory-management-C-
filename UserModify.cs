using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class UserModify : Form
    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=shop;Integrated Security=True";

        public UserModify()
        {
            InitializeComponent();
        }

        private void UserModify_Load(object sender, EventArgs e)
        {
            // Load user data into the DataGridView
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load user data from the database
                    SqlCommand command = new SqlCommand("SELECT UserId, Email, Username, Password FROM [User]", connection);
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);



                    // Bind the DataTable to the DataGridView
                    dataGridUsers.DataSource = dataTable;

                    // Handle button clicks
                    //dataGridUsers.CellContentClick += DataGridUsers_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if Edit User button is clicked
            if (e.ColumnIndex == dataGridUsers.Columns["EditUser"].Index && e.RowIndex >= 0 && e.RowIndex < dataGridUsers.Rows.Count - 1)
            {
                // Get the user ID from the selected row
                string userId = dataGridUsers.Rows[e.RowIndex].Cells["UserId"].Value.ToString();

                // Show the label and textbox for ID
                labelID.Visible = true;
                tbID.Visible = true;

                // Place the user ID in the textbox
                tbID.Text = userId.ToString();
            }
            // Check if Remove User button is clicked
            else if (e.ColumnIndex == dataGridUsers.Columns["RemoveUser"].Index && e.RowIndex >= 0 && e.RowIndex < dataGridUsers.Rows.Count - 1)
            {
                // Get the user ID from the selected row
                int userId = (int)dataGridUsers.Rows[e.RowIndex].Cells["UserId"].Value;

                try
                {
                    // Execute the stored procedure to remove the user
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("RemoveUserById", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.ExecuteNonQuery();

                        MessageBox.Show("User removed successfully!");
                    }

                    // Reload user data after removing the user
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while removing the user: " + ex.Message);
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmailUser.Text) ||
               string.IsNullOrWhiteSpace(tbUserName.Text) ||
               string.IsNullOrWhiteSpace(tbPasswordUser.Text) 
             )
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(tbEmailUser.Text)) {
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
                    // Reload user data after adding the user
                    LoadUserData();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // Check if tbID is empty
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Please enter a valid user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(tbEmailUser.Text))
            {
                MessageBox.Show("Please fill correct email format like abc@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if any of the other textboxes are empty
            if (string.IsNullOrWhiteSpace(tbEmailUser.Text) ||
                string.IsNullOrWhiteSpace(tbUserName.Text) ||
                string.IsNullOrWhiteSpace(tbPasswordUser.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the values from the textboxes
            int userId;
            if (!int.TryParse(tbID.Text, out userId))
            {
                MessageBox.Show("Please enter a valid user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = tbEmailUser.Text;
            string username = tbUserName.Text;
            string password = tbPasswordUser.Text;

            try
            {
                // Execute the stored procedure to update user data
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UpdateUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();

                    MessageBox.Show("User updated successfully!");
                }

                // Reload user data after updating the user
                LoadUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
