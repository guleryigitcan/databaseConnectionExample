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
    public partial class productTable : Form
    {
        public productTable()
        {
            InitializeComponent();
        }

        public string dataLink { get; set; }
        SqlConnection connection;
        public static string connectionPath;

        public void getProducts()
        {
            connectionPath = dataLink;
            connection = new SqlConnection(connectionPath);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from Products ", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_productID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_productName.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_supplierID.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_categoryID.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_quantityPerUnit.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_unitPrice.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_unitsInStock.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_unitsOnOrder.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox_reorderLevel.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox_Discontinued.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void productTable_Load(object sender, EventArgs e)
        {
            getProducts();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("UPDATE Products SET ProductID=@ProductID,ProductName=@ProductName,SupplierID=@SupplierID,CategoryID=@CategoryID,QuantityPerUnit=@QuantityPerUnit,UnitPrice=@UnitPrice,UnitsInStock=@UnitsInStock,UnitsOnOrder=@UnitsOnOrder,ReorderLevel=@ReorderLevel,Discontinued=@Discontinued WHERE ProductID=@ProductID", connection);
            komut.Parameters.AddWithValue("@ProductID", textBox_productID.Text);
            komut.Parameters.AddWithValue("@ProductName", textBox_productName.Text);
            komut.Parameters.AddWithValue("@SupplierID", textBox_supplierID.Text);
            komut.Parameters.AddWithValue("@CategoryID", textBox_categoryID.Text);
            komut.Parameters.AddWithValue("@QuantityPerUnit", textBox_quantityPerUnit.Text);
            komut.Parameters.AddWithValue("@UnitPrice", textBox_unitPrice.Text);
            komut.Parameters.AddWithValue("@UnitsInStock", textBox_unitsInStock.Text);
            komut.Parameters.AddWithValue("@UnitsOnOrder", textBox_unitsOnOrder.Text);
            komut.Parameters.AddWithValue("@ReorderLevel", textBox_reorderLevel.Text);
            komut.Parameters.AddWithValue("@Discontinued", textBox_Discontinued.Text);
          
            komut.ExecuteNonQuery();



            connection.Close();
            getProducts();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("INSERT INTO Products(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) VALUES (@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel,@Discontinued)", connection);
            komut.Parameters.AddWithValue("@ProductName", textBox_productName.Text);
            komut.Parameters.AddWithValue("@SupplierID", textBox_supplierID.Text);
            komut.Parameters.AddWithValue("@CategoryID", textBox_categoryID.Text);
            komut.Parameters.AddWithValue("@QuantityPerUnit", textBox_quantityPerUnit.Text);
            komut.Parameters.AddWithValue("@UnitPrice", textBox_unitPrice.Text);
            komut.Parameters.AddWithValue("@UnitsInStock", textBox_unitsInStock.Text);
            komut.Parameters.AddWithValue("@UnitsOnOrder", textBox_unitsOnOrder.Text);
            komut.Parameters.AddWithValue("@ReorderLevel", textBox_reorderLevel.Text);
            komut.Parameters.AddWithValue("@Discontinued", textBox_Discontinued.Text);
            komut.ExecuteNonQuery();



            connection.Close();
            getProducts();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand komut = new SqlCommand("DELETE from Products where ProductID=@ProductID", connection);
            komut.Parameters.AddWithValue("@ProductID", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            connection.Close();
            getProducts();
        }
    }
}
