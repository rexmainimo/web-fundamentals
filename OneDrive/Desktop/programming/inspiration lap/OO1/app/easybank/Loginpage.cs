using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace easybank
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        public registration_page_linkbtn registration_page_linkbtn
        {
            get => default;
            set
            {
            }
        }

        public home_page home_page
        {
            get => default;
            set
            {
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            string email = usernamebox.Text;
            string password = passwordbox.Text;

            DataTable customerTable = data.GetCustomerByEmailAndPassword(email, password);
            if (customerTable.Rows.Count > 0)
            {
                // Login successful, retrieve customer data from table
                int customerId = (int)customerTable.Rows[0]["id"];
                string firstName = (string)customerTable.Rows[0]["first_name"];
                string lastName = (string)customerTable.Rows[0]["last_name"];
                this.Hide();
                home_page back_home = new home_page();
                back_home.Show();
                // ... retrieve other customer data as needed

                // Show main form or perform other actions as needed
            }
            else
            {
                // Login failed, show error message
                MessageBox.Show("Invalid email or password.");
            }
            

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            registration_page_linkbtn registration_Page = new registration_page_linkbtn();
            registration_Page.Show();

        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
