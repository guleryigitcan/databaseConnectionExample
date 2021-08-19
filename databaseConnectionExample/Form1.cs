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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           
        }

        public string dataLink { get; set; }
        public static string connectionPath;

        private void Form1_Load(object sender, EventArgs e)
        {

            loadComboBox_CustomerID();
            loadComboBox_EmployeeID();
        }

        //static string connectionPath = "Data Source=DESKTOP-M5EVSHF;Initial Catalog=NORTHWND;Integrated Security=True";
        SqlConnection connection;
        private void button1_Click(object sender, EventArgs e)
        {


             if (connection.State == ConnectionState.Closed)
             {
                 connection.Open();
             }

             string employeeIndex = comboBox_EmployeeID.SelectedItem.ToString();
             SqlCommand komut = new SqlCommand("INSERT INTO Orders(CustomerID,EmployeeID,OrderDate,RequiredDate,Freight,ShipName,ShipAddress,ShipCity,ShipCountry) VALUES (@CustomerID,@EmployeeID,@OrderDate,@RequiredDate,@Freight,@ShipName,@ShipAddress,@ShipCity,@ShipCountry)", connection);
             komut.Parameters.AddWithValue("@CustomerID", comboBox1_customerID.SelectedItem);
             komut.Parameters.AddWithValue("@EmployeeID", employeeIndex[0].ToString());
             komut.Parameters.AddWithValue("@OrderDate", order_date.Value.ToString("yyyy.MM.dd"));
             komut.Parameters.AddWithValue("@RequiredDate", required_date.Value.ToString("yyyy.MM.dd")); 
             komut.Parameters.AddWithValue("@Freight", textBox_freight.Text);
             komut.Parameters.AddWithValue("@ShipName", textBox_shipName.Text);
             komut.Parameters.AddWithValue("@ShipAddress", textBox_shipAdress.Text);
             komut.Parameters.AddWithValue("@ShipCity", textBox_shipCity.Text);
             komut.Parameters.AddWithValue("@ShipCountry", textBox_shipCountry.Text);
             komut.ExecuteNonQuery();



             connection.Close();
           
            Form2 fr = new Form2();
            fr.dataLink = dataLink;
            fr.Show();
        }

        public void loadComboBox_CustomerID()
        {
            connectionPath = dataLink;
            connection = new SqlConnection(connectionPath);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("select CustomerID from Customers", connection);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                comboBox1_customerID.Items.Add(reader1[0].ToString());
            }
            reader1.Close();
        }

        public void loadComboBox_EmployeeID()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("select cast(EmployeeID as nvarchar)+' - '+FirstName from Employees ", connection);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                comboBox_EmployeeID.Items.Add(reader1[0].ToString());
            }
            reader1.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Are you sure to exit the app?", "Warning!", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Exit == DialogResult.No)
            {
                Application.Run();
            }

        }

        
    }
}
