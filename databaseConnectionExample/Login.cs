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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeMyControl();
        }
        
        private void button_logIn_Click(object sender, EventArgs e)
        {
            string username="";
            string password="";
            string databaseLink = textBox_dataLink.Text;

            SqlConnection connection;
            connection = new SqlConnection(databaseLink);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select userName,password from Users where userName=@userName and password=@password",connection);
            cmd1.Parameters.AddWithValue("@userName", textBox_username.Text);
            cmd1.Parameters.AddWithValue("@password", textBox_password.Text);
            SqlDataReader reader;
            reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                username = reader["userName"].ToString();
                password = reader["password"].ToString();
            }
           
            connection.Close();




            if (textBox_username.Text == username && textBox_password.Text == password && username=="admin")
            {

                adminPanel ap = new adminPanel();
                ap.dataLink = databaseLink;
                ap.Show();
                this.Hide();
            }
            else if(textBox_username.Text == username && textBox_password.Text == password)
            {
                Form1 fr = new Form1();
                fr.dataLink = databaseLink;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User or Password ");
            }
            

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

        private void label_signIn_Click(object sender, EventArgs e)
        {
            signIn sign = new signIn();
            sign.Show();
            this.Hide();
        }
    }
}
