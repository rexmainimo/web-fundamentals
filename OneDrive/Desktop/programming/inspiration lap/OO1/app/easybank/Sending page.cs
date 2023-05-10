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
    public partial class sending_page_link : Form
    {
        public sending_page_link()
        {
            InitializeComponent();
        }

        private void sending_page_link_Load(object sender, EventArgs e)
        {

        }

        private void send_moneybtn_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();

            ConfirmationControl1 confirm_transact = new ConfirmationControl1();
            confirm_transact.Show();

            confirmationControl11.Show();
            confirmationControl11.BringToFront();

            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            home_page back_home = new home_page();
            back_home.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void confirmationControl11_Load(object sender, EventArgs e)
        {
            confirmationControl11.Hide();


        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
