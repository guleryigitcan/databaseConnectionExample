namespace databaseConnectionExample
{
    partial class adminPanel
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
            this.button_update = new System.Windows.Forms.Button();
            this.comboBox1_customerID = new System.Windows.Forms.ComboBox();
            this.comboBox_EmployeeID = new System.Windows.Forms.ComboBox();
            this.textBox_freight = new System.Windows.Forms.TextBox();
            this.textBox_shipName = new System.Windows.Forms.TextBox();
            this.textBox_shipAdress = new System.Windows.Forms.TextBox();
            this.textBox_shipCity = new System.Windows.Forms.TextBox();
            this.textBox_shipCountry = new System.Windows.Forms.TextBox();
            this.order_date = new System.Windows.Forms.DateTimePicker();
            this.required_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.button_deleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(153, 212);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboBox1_customerID
            // 
            this.comboBox1_customerID.FormattingEnabled = true;
            this.comboBox1_customerID.Location = new System.Drawing.Point(107, 25);
            this.comboBox1_customerID.Name = "comboBox1_customerID";
            this.comboBox1_customerID.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_customerID.TabIndex = 6;
            // 
            // comboBox_EmployeeID
            // 
            this.comboBox_EmployeeID.FormattingEnabled = true;
            this.comboBox_EmployeeID.Location = new System.Drawing.Point(107, 63);
            this.comboBox_EmployeeID.Name = "comboBox_EmployeeID";
            this.comboBox_EmployeeID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_EmployeeID.TabIndex = 7;
            // 
            // textBox_freight
            // 
            this.textBox_freight.Location = new System.Drawing.Point(107, 104);
            this.textBox_freight.Name = "textBox_freight";
            this.textBox_freight.Size = new System.Drawing.Size(121, 20);
            this.textBox_freight.TabIndex = 13;
            // 
            // textBox_shipName
            // 
            this.textBox_shipName.Location = new System.Drawing.Point(107, 147);
            this.textBox_shipName.Name = "textBox_shipName";
            this.textBox_shipName.Size = new System.Drawing.Size(121, 20);
            this.textBox_shipName.TabIndex = 15;
            // 
            // textBox_shipAdress
            // 
            this.textBox_shipAdress.Location = new System.Drawing.Point(353, 21);
            this.textBox_shipAdress.Name = "textBox_shipAdress";
            this.textBox_shipAdress.Size = new System.Drawing.Size(121, 20);
            this.textBox_shipAdress.TabIndex = 16;
            // 
            // textBox_shipCity
            // 
            this.textBox_shipCity.Location = new System.Drawing.Point(353, 62);
            this.textBox_shipCity.Name = "textBox_shipCity";
            this.textBox_shipCity.Size = new System.Drawing.Size(121, 20);
            this.textBox_shipCity.TabIndex = 19;
            // 
            // textBox_shipCountry
            // 
            this.textBox_shipCountry.Location = new System.Drawing.Point(353, 102);
            this.textBox_shipCountry.Name = "textBox_shipCountry";
            this.textBox_shipCountry.Size = new System.Drawing.Size(121, 20);
            this.textBox_shipCountry.TabIndex = 20;
            // 
            // order_date
            // 
            this.order_date.Location = new System.Drawing.Point(578, 23);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(200, 20);
            this.order_date.TabIndex = 21;
            // 
            // required_date
            // 
            this.required_date.Location = new System.Drawing.Point(578, 62);
            this.required_date.Name = "required_date";
            this.required_date.Size = new System.Drawing.Size(200, 20);
            this.required_date.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Employee Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Freight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ship Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ship Adress:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ship City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ship Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Order Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Required Date:";
            // 
            // button_addOrder
            // 
            this.button_addOrder.Location = new System.Drawing.Point(280, 212);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(75, 23);
            this.button_addOrder.TabIndex = 32;
            this.button_addOrder.Text = "Add";
            this.button_addOrder.UseVisualStyleBackColor = true;
            this.button_addOrder.Click += new System.EventHandler(this.button_addOrder_Click);
            // 
            // button_deleteOrder
            // 
            this.button_deleteOrder.Location = new System.Drawing.Point(399, 212);
            this.button_deleteOrder.Name = "button_deleteOrder";
            this.button_deleteOrder.Size = new System.Drawing.Size(75, 23);
            this.button_deleteOrder.TabIndex = 33;
            this.button_deleteOrder.Text = "Delete";
            this.button_deleteOrder.UseVisualStyleBackColor = true;
            this.button_deleteOrder.Click += new System.EventHandler(this.button_deleteOrder_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 589);
            this.Controls.Add(this.button_deleteOrder);
            this.Controls.Add(this.button_addOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.required_date);
            this.Controls.Add(this.order_date);
            this.Controls.Add(this.textBox_shipCountry);
            this.Controls.Add(this.textBox_shipCity);
            this.Controls.Add(this.textBox_shipAdress);
            this.Controls.Add(this.textBox_shipName);
            this.Controls.Add(this.textBox_freight);
            this.Controls.Add(this.comboBox_EmployeeID);
            this.Controls.Add(this.comboBox1_customerID);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView1);
            this.Name = "adminPanel";
            this.Text = "adminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox comboBox1_customerID;
        private System.Windows.Forms.ComboBox comboBox_EmployeeID;
        private System.Windows.Forms.TextBox textBox_freight;
        private System.Windows.Forms.TextBox textBox_shipName;
        private System.Windows.Forms.TextBox textBox_shipAdress;
        private System.Windows.Forms.TextBox textBox_shipCity;
        private System.Windows.Forms.TextBox textBox_shipCountry;
        private System.Windows.Forms.DateTimePicker order_date;
        private System.Windows.Forms.DateTimePicker required_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_addOrder;
        private System.Windows.Forms.Button button_deleteOrder;
    }
}