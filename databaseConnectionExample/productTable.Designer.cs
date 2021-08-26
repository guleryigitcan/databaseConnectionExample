namespace databaseConnectionExample
{
    partial class productTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_productID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_unitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_unitsInStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_supplierID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_unitsOnOrder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_categoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_reorderLevel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_quantityPerUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Discontinued = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(568, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 483);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // textBox_productID
            // 
            this.textBox_productID.Location = new System.Drawing.Point(103, 67);
            this.textBox_productID.Name = "textBox_productID";
            this.textBox_productID.Size = new System.Drawing.Size(124, 20);
            this.textBox_productID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name:";
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(103, 112);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(124, 20);
            this.textBox_productName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit Price:";
            // 
            // textBox_unitPrice
            // 
            this.textBox_unitPrice.Location = new System.Drawing.Point(363, 67);
            this.textBox_unitPrice.Name = "textBox_unitPrice";
            this.textBox_unitPrice.Size = new System.Drawing.Size(128, 20);
            this.textBox_unitPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Units In Stock:";
            // 
            // textBox_unitsInStock
            // 
            this.textBox_unitsInStock.Location = new System.Drawing.Point(363, 112);
            this.textBox_unitsInStock.Name = "textBox_unitsInStock";
            this.textBox_unitsInStock.Size = new System.Drawing.Size(128, 20);
            this.textBox_unitsInStock.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Supplier ID:";
            // 
            // textBox_supplierID
            // 
            this.textBox_supplierID.Location = new System.Drawing.Point(103, 162);
            this.textBox_supplierID.Name = "textBox_supplierID";
            this.textBox_supplierID.Size = new System.Drawing.Size(124, 20);
            this.textBox_supplierID.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Units On Order:";
            // 
            // textBox_unitsOnOrder
            // 
            this.textBox_unitsOnOrder.Location = new System.Drawing.Point(363, 162);
            this.textBox_unitsOnOrder.Name = "textBox_unitsOnOrder";
            this.textBox_unitsOnOrder.Size = new System.Drawing.Size(128, 20);
            this.textBox_unitsOnOrder.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Category ID:";
            // 
            // textBox_categoryID
            // 
            this.textBox_categoryID.Location = new System.Drawing.Point(103, 209);
            this.textBox_categoryID.Name = "textBox_categoryID";
            this.textBox_categoryID.Size = new System.Drawing.Size(124, 20);
            this.textBox_categoryID.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Reorder Level:";
            // 
            // textBox_reorderLevel
            // 
            this.textBox_reorderLevel.Location = new System.Drawing.Point(363, 209);
            this.textBox_reorderLevel.Name = "textBox_reorderLevel";
            this.textBox_reorderLevel.Size = new System.Drawing.Size(128, 20);
            this.textBox_reorderLevel.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Quantity Per Unit:";
            // 
            // textBox_quantityPerUnit
            // 
            this.textBox_quantityPerUnit.Location = new System.Drawing.Point(103, 255);
            this.textBox_quantityPerUnit.Name = "textBox_quantityPerUnit";
            this.textBox_quantityPerUnit.Size = new System.Drawing.Size(124, 20);
            this.textBox_quantityPerUnit.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Discontinued";
            // 
            // textBox_Discontinued
            // 
            this.textBox_Discontinued.Location = new System.Drawing.Point(363, 252);
            this.textBox_Discontinued.Name = "textBox_Discontinued";
            this.textBox_Discontinued.Size = new System.Drawing.Size(128, 20);
            this.textBox_Discontinued.TabIndex = 19;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(57, 334);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 21;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(208, 334);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 22;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(363, 334);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 23;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // productTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 591);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_Discontinued);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_quantityPerUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_reorderLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_categoryID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_unitsOnOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_supplierID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_unitsInStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_unitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_productName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_productID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "productTable";
            this.Text = "productTable";
            this.Load += new System.EventHandler(this.productTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_productID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_unitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_unitsInStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_supplierID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_unitsOnOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_categoryID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_reorderLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_quantityPerUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Discontinued;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
    }
}