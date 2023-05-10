using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace easybank
{
    public partial class registration_page_linkbtn : Form
    {
        //private Data _registratindata;
        public registration_page_linkbtn()
        {
            InitializeComponent();
        

            
            //_registratindata = new Data();
            //string mysqlcon = "server=ID386620_easybank.db.webhosting.be; user=ID386620_easybank; database=ID386620_easybank; password=Easybanksneharex2023";
            //MySqlConnection mysqlconnection = new MySqlConnection(mysqlcon);
            //try
            //{
            //    mysqlconnection.Open();
            //    MessageBox.Show("Connection success");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    mysqlconnection.Close();
            //}

        }

        public loginpage loginpage
        {
            get => default;
            set
            {
            }
        }

        private void registration_link_page_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passwordbox_rg_TextChanged(object sender, EventArgs e)
        {
            passwordbox_rg.PasswordChar = '*';
       
        }

        private void repeatpasswordbox_TextChanged(object sender, EventArgs e)
        {
            repeatpasswordbox.PasswordChar = '*';
           
        }

        private void backbtn_tologinpg_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginpage back_to_loginpg = new loginpage();
            backbtn_tologinpg.Show();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = firstname.Text;
            string lname = lastname.Text;
            string email_address = email.Text;
            string dob = birthday.Text;
            string cnty = natioanality.Text;
            string str_address = address.Text;
            string phone = phone_number.Text;
            string gender = sex.Text;
            string pass1 = passwordbox_rg.Text;
            string pass2 = repeatpasswordbox.Text;

            Data data = new Data();

            if (data.InsertCustomer(fname, lname, email_address, dob, cnty, str_address, phone, gender, pass1, pass2)) 
            {
                MessageBox.Show("Registered successfully!");
                this.Hide();
                loginpage user_loginpage = new loginpage();
                user_loginpage.Show();

            }
            else
            {
                MessageBox.Show("Failed to register!");
            }

        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void natioanality_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phone_number_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void sex_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
