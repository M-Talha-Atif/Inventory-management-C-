using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSignUpUser_Click(object sender, EventArgs e)
        {
            new LoginUser().Show();
           // this.Hide();
        }

        private void btnSignUpUser_Click_1(object sender, EventArgs e)
        {
            new SignUpUser().Show();
           // this.Hide();
        }

        private void btnAuthenticateAdmin_Click(object sender, EventArgs e)
        {
            new LoginAdmin().Show();
          //  this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
