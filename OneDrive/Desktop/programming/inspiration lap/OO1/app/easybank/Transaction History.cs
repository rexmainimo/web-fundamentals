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
    public partial class Transaction_History : Form
    {
        public Transaction_History()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            home_page back_home = new home_page();
            back_home.Show();


        }
    }
}
