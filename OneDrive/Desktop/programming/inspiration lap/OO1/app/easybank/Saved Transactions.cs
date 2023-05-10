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
    public partial class Saved_Transactions : Form
    {
        public Saved_Transactions()
        {
            InitializeComponent();
        }

        private void backbt_savedtransacts_Click(object sender, EventArgs e)
        {
            this.Hide();

            home_page back_home = new home_page();
            back_home.Show();

        }
    }
}
