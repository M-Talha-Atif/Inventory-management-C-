using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the entered credentials match the hardcoded admin credentials
                if (tbAdminName.Text == "123" && tbPasswordAdmin.Text == "123")
                {
                    MessageBox.Show("Login successful!");
                    // Navigate to the admin main form or perform other actions
                    new AdminMain().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
