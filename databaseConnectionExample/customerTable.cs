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
    public partial class customerTable : Form
    {
        public customerTable()
        {
            InitializeComponent();
        }

        public string dataLink { get; set; }
        SqlConnection connection;
        public static string connectionPath;
        private void customerTable_Load(object sender, EventArgs e)
        {
            getCustomers();
        }

        public void getCustomers()
        {
            connectionPath = dataLink;
            connection = new SqlConnection(connectionPath);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from Customers ", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_customerID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_companyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_contactName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_contactTitle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_address.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_city.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_region.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_postalCode.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox_country.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox_phone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox_fax.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("UPDATE Customers SET CustomerID=@CustomerID,CompanyName=@CompanyName,ContactName=@ContactName,ContactTitle=@ContactTitle,Address=@Address,City=@City,Region=@Region,PostalCode=@PostalCode,Country=@Country,Phone=@Phone,Fax=@Fax WHERE CustomerID=@CustomerID", connection);
            komut.Parameters.AddWithValue("@CustomerID", textBox_customerID.Text);
            komut.Parameters.AddWithValue("@CompanyName", textBox_companyName.Text);
            komut.Parameters.AddWithValue("@ContactName", textBox_contactName.Text);
            komut.Parameters.AddWithValue("@ContactTitle", textBox_contactTitle.Text);
            komut.Parameters.AddWithValue("@Address", textBox_address.Text);
            komut.Parameters.AddWithValue("@City", textBox_city.Text);
            komut.Parameters.AddWithValue("@Region", textBox_region.Text);
            komut.Parameters.AddWithValue("@PostalCode", textBox_postalCode.Text);
            komut.Parameters.AddWithValue("@Country", textBox_country.Text);
            komut.Parameters.AddWithValue("@Phone", textBox_phone.Text);
            komut.Parameters.AddWithValue("@Fax", textBox_fax.Text);
            komut.ExecuteNonQuery();
            


            connection.Close();
            getCustomers();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("INSERT INTO Customers(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) VALUES (@CustomerID,@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostalCode,@Country,@Phone,@Fax)", connection);
            komut.Parameters.AddWithValue("@CustomerID", textBox_customerID.Text);
            komut.Parameters.AddWithValue("@CompanyName", textBox_companyName.Text);
            komut.Parameters.AddWithValue("@ContactName", textBox_contactName.Text);
            komut.Parameters.AddWithValue("@ContactTitle", textBox_contactTitle.Text);
            komut.Parameters.AddWithValue("@Address", textBox_address.Text);
            komut.Parameters.AddWithValue("@City", textBox_city.Text);
            komut.Parameters.AddWithValue("@Region", textBox_region.Text);
            komut.Parameters.AddWithValue("@PostalCode", textBox_postalCode.Text);
            komut.Parameters.AddWithValue("@Country", textBox_country.Text);
            komut.Parameters.AddWithValue("@Phone", textBox_phone.Text);
            komut.Parameters.AddWithValue("@Fax", textBox_fax.Text);
            komut.ExecuteNonQuery();



            connection.Close();
            getCustomers();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("DELETE from Customers where CustomerID=@CustomerID", connection);
            komut.Parameters.AddWithValue("@CustomerID", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            connection.Close();
            getCustomers();
        }
    }
}
