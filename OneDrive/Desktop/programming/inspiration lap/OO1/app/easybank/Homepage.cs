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
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        public Saved_Transactions Saved_Transactions
        {
            get => default;
            set
            {
            }
        }

        public Transaction_History Transaction_History
        {
            get => default;
            set
            {
            }
        }

        public sending_page_link sending_page_link
        {
            get => default;
            set
            {
            }
        }

        private void send_money_page_Click(object sender, EventArgs e)
        {
            this.Hide();

            sending_page_link home_to_sendpg = new sending_page_link();
            home_to_sendpg.Show(); 

            
        }

        private void transaction_page_link_Click(object sender, EventArgs e)
        {
            this.Hide();

            Transaction_History transaction_history = new Transaction_History();
            transaction_history.Show();
        }

        private void saved_transactionsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Saved_Transactions saved_transactionspg = new Saved_Transactions();
            saved_transactionspg.Show();
        }

        private void home_page_Load(object sender, EventArgs e)
        {

        }
    }
}
