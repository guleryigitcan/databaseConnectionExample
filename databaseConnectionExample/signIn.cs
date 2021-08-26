using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databaseConnectionExample
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
            InitializeMyControl();
        }

        private void InitializeMyControl()
        {
            // Set to no text.
            textBox_password.Text = "";
            // The password character is an asterisk.
            textBox_password.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox_password.MaxLength = 14;
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string databaseLink = textBox_databaseLink.Text;

            SqlConnection connection;
            connection= new SqlConnection(databaseLink);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand userInfo = new SqlCommand("INSERT INTO Users(userName,email,password) VALUES (@userName,@email,@password)", connection);
            userInfo.Parameters.AddWithValue("@userName", username);
            userInfo.Parameters.AddWithValue("@email", email);
            userInfo.Parameters.AddWithValue("@password", password);
            userInfo.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfull");
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
