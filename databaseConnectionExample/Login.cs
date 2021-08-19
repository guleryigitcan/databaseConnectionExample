using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
            if (textBox_username.Text == "admin" && textBox_password.Text == "password")
            {

                adminPanel ap = new adminPanel();
                ap.dataLink = textBox_dataLink.Text;
                ap.Show();
                this.Hide();
            }
            else if(textBox_username.Text == "user" && textBox_password.Text == "password")
            {
                Form1 fr = new Form1();
                fr.dataLink = textBox_dataLink.Text;
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
    }
}
