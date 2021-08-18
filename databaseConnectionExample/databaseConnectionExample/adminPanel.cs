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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
            getOrders();
            loadComboBoxCustomerID();
            loadComboBoxEmployeeID();

        }
        static string connectionPath = "Data Source=DESKTOP-M5EVSHF;Initial Catalog=NORTHWND;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionPath);
        public void getOrders()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("Select OrderID,CustomerID,EmployeeID,OrderDate,RequiredDate,Freight,ShipName,ShipAddress,ShipCity,ShipCountry from Orders", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();

        }
        public void loadComboBoxCustomerID()
        {
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

        public void loadComboBoxEmployeeID()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("select EmployeeID from Employees order by EmployeeID ", connection);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                comboBox_EmployeeID.Items.Add(reader1[0].ToString());
            }
            reader1.Close();
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("UPDATE Orders SET CustomerID=@CustomerID,EmployeeID=@EmployeeID,OrderDate=@OrderDate,RequiredDate=@RequiredDate,Freight=@Freight,ShipName=@ShipName,ShipAddress=@ShipAddress,ShipCity=@ShipCity,ShipCountry=@ShipCountry WHERE OrderID=@OrderID", connection);
            komut.Parameters.AddWithValue("@CustomerID", comboBox1_customerID.SelectedItem);
            komut.Parameters.AddWithValue("@EmployeeID", comboBox_EmployeeID.SelectedItem);
            komut.Parameters.AddWithValue("@OrderDate", order_date.Value.ToString("yyyy.MM.dd"));
            komut.Parameters.AddWithValue("@RequiredDate", required_date.Value.ToString("yyyy.MM.dd"));
            komut.Parameters.AddWithValue("@Freight", textBox_freight.Text);
            komut.Parameters.AddWithValue("@ShipName", textBox_shipName.Text);
            komut.Parameters.AddWithValue("@ShipAddress", textBox_shipAdress.Text);
            komut.Parameters.AddWithValue("@ShipCity", textBox_shipCity.Text);
            komut.Parameters.AddWithValue("@ShipCountry", textBox_shipCountry.Text);
            komut.Parameters.AddWithValue("@OrderID", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();



            connection.Close();
            getOrders();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string customerID=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int customerIDIndex=comboBox1_customerID.FindStringExact(customerID);
            comboBox1_customerID.SelectedIndex = customerIDIndex;

            string employeeID = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int employeeIDIndex = comboBox_EmployeeID.FindStringExact(employeeID);

            comboBox_EmployeeID.SelectedIndex = employeeIDIndex;
            order_date.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            required_date.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
            textBox_freight.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_shipName.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_shipAdress.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox_shipCity.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox_shipCountry.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();


        }

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("INSERT INTO Orders(CustomerID,EmployeeID,OrderDate,RequiredDate,Freight,ShipName,ShipAddress,ShipCity,ShipCountry) VALUES (@CustomerID,@EmployeeID,@OrderDate,@RequiredDate,@Freight,@ShipName,@ShipAddress,@ShipCity,@ShipCountry)", connection);
            komut.Parameters.AddWithValue("@CustomerID", comboBox1_customerID.SelectedItem);
            komut.Parameters.AddWithValue("@EmployeeID", comboBox_EmployeeID.SelectedItem);
            komut.Parameters.AddWithValue("@OrderDate", order_date.Value.ToString("yyyy.MM.dd"));
            komut.Parameters.AddWithValue("@RequiredDate", required_date.Value.ToString("yyyy.MM.dd"));
            komut.Parameters.AddWithValue("@Freight", textBox_freight.Text);
            komut.Parameters.AddWithValue("@ShipName", textBox_shipName.Text);
            komut.Parameters.AddWithValue("@ShipAddress", textBox_shipAdress.Text);
            komut.Parameters.AddWithValue("@ShipCity", textBox_shipCity.Text);
            komut.Parameters.AddWithValue("@ShipCountry", textBox_shipCountry.Text);
            komut.ExecuteNonQuery();



            connection.Close();
            getOrders();
        }

        private void button_deleteOrder_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("DELETE from Orders where OrderID=@OrderID",connection);
            komut.Parameters.AddWithValue("@OrderID",dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            connection.Close();
            getOrders();
        }

        private void adminPanel_FormClosed(object sender, FormClosedEventArgs e)
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
