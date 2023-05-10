using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace easybank
{
    class Data
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        // Constructor
        public Data()
        {   
            server = "ID386620_easybank.db.webhosting.be";
            database = "ID386620_easybank";
            user = "ID386620_easybank";
            password = "Easybanksneharex2023";
            string connectionString = $"SERVER={server};DATABASE={database};USER={user};PASSWORD={password};SslMode=none;Convert Zero Datetime=True";
            connection = new MySqlConnection(connectionString);

            OpenConnection();
            CloseConnection();

        }

        //Open the database connection
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle exception here
                MessageBox.Show(ex.Message);
                return false;
            }
            //finally
            //{
            //    connection.Close();
            //}
        }

        // Close the database connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle exception here
                return false;
            }
        }

        // Execute a SQL query
        public bool ExecuteQuery(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySqlException ex)
                {
                    // Handle exception here
                    this.CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //add customer
        public bool InsertCustomer(string first_name, string last_name, string email, string birthday, string nationality, string address, string phone_number, string sex, string password, string repeat_password)
        {
            string query = "INSERT INTO customers (first_name, last_name, email, birthday, nationality, address, phone_number, sex, password, repeat_password) " +
                           "VALUES (@first_name, @last_name, @email, @birthday, @nationality, " +
                           "@address, @phone_number, @sex, @password, @repeat_password)";

            if (this.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@birthday", birthday);
                command.Parameters.AddWithValue("@nationality", nationality);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@phone_number", phone_number);
                command.Parameters.AddWithValue("@sex", sex);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@repeat_password", repeat_password);

                bool success = ExecuteQuery(command);
                this.CloseConnection();
                return success;
            }
            else
            {
                return false;
            }
        }

        private bool ExecuteQuery(MySqlCommand command)
        {
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle exception here
                return false;
            }
        }

        public DataTable GetCustomerByEmailAndPassword(string email, string password)
        {
            DataTable table = new DataTable();
            string query = $"SELECT * FROM customers WHERE email = @email AND password = @password";
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                CloseConnection();
            }
            return table;
        }



    }
}
