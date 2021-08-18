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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            loadComboBox();
        }
        static string connectionPath = "Data Source=DESKTOP-M5EVSHF;Initial Catalog=NORTHWND;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionPath);


        public void loadComboBox()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("select cast(ProductID as nvarchar)+' - '+ProductName from Products order by ProductID", connection);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                comboBox_ProductID.Items.Add(reader1[0].ToString());
            }
            reader1.Close();
        }
        private void goToItemForm_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand getOrderID = new SqlCommand("select top 1 OrderID  from Orders order by OrderID desc", connection);
            SqlDataReader reader1;
            reader1 = getOrderID.ExecuteReader();
            reader1.Read();
            int orderID = reader1.GetInt32(0);
            reader1.Close();

            string productIndex = comboBox_ProductID.SelectedItem.ToString();
            string unitprice = getUnit_Price(productIndex[0].ToString());
            MessageBox.Show(unitprice);


            SqlCommand itemGirdi = new SqlCommand("INSERT INTO [Order Details](OrderID,ProductID,UnitPrice,Quantity) VALUES (@OrderID,@ProductID,@UnitPrice,@Quantity)", connection);
            itemGirdi.Parameters.AddWithValue("@OrderID", orderID);
            itemGirdi.Parameters.AddWithValue("@ProductID", productIndex[0].ToString());
            itemGirdi.Parameters.AddWithValue("@UnitPrice", unitprice.ToString());
            itemGirdi.Parameters.AddWithValue("@Quantity", textBox_Quantity.Text);
            itemGirdi.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Items added.");

        }

        public string getUnit_Price(string index)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand getUnitPrice = new SqlCommand("select UnitPrice from Products where ProductID  = @index", connection);
            getUnitPrice.Parameters.AddWithValue("@index", index);
            SqlDataReader reader1;
            reader1 = getUnitPrice.ExecuteReader();
            reader1.Read();
            string unitPrice = reader1[0].ToString();
            reader1.Close();

            return unitPrice;

        }

        private void comboBox_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = comboBox_ProductID.SelectedIndex + 1;
            string unitPrice = getUnit_Price(index.ToString());
            textBox_unitPrice.Text = unitPrice;
            



        }

        
    }
}
