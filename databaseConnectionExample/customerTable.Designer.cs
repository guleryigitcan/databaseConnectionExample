namespace databaseConnectionExample
{
    partial class customerTable
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
            this.textBox_companyName = new System.Windows.Forms.TextBox();
            this.textBox_contactName = new System.Windows.Forms.TextBox();
            this.textBox_contactTitle = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_region = new System.Windows.Forms.TextBox();
            this.textBox_postalCode = new System.Windows.Forms.TextBox();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_fax = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_customerID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(829, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // textBox_companyName
            // 
            this.textBox_companyName.Location = new System.Drawing.Point(111, 72);
            this.textBox_companyName.Name = "textBox_companyName";
            this.textBox_companyName.Size = new System.Drawing.Size(142, 20);
            this.textBox_companyName.TabIndex = 2;
            // 
            // textBox_contactName
            // 
            this.textBox_contactName.Location = new System.Drawing.Point(111, 112);
            this.textBox_contactName.Name = "textBox_contactName";
            this.textBox_contactName.Size = new System.Drawing.Size(142, 20);
            this.textBox_contactName.TabIndex = 3;
            // 
            // textBox_contactTitle
            // 
            this.textBox_contactTitle.Location = new System.Drawing.Point(349, 28);
            this.textBox_contactTitle.Name = "textBox_contactTitle";
            this.textBox_contactTitle.Size = new System.Drawing.Size(142, 20);
            this.textBox_contactTitle.TabIndex = 4;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(349, 72);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(142, 20);
            this.textBox_address.TabIndex = 5;
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(349, 112);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(142, 20);
            this.textBox_city.TabIndex = 6;
            // 
            // textBox_region
            // 
            this.textBox_region.Location = new System.Drawing.Point(572, 28);
            this.textBox_region.Name = "textBox_region";
            this.textBox_region.Size = new System.Drawing.Size(142, 20);
            this.textBox_region.TabIndex = 7;
            // 
            // textBox_postalCode
            // 
            this.textBox_postalCode.Location = new System.Drawing.Point(572, 72);
            this.textBox_postalCode.Name = "textBox_postalCode";
            this.textBox_postalCode.Size = new System.Drawing.Size(142, 20);
            this.textBox_postalCode.TabIndex = 8;
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(572, 112);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(142, 20);
            this.textBox_country.TabIndex = 9;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(823, 28);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(142, 20);
            this.textBox_phone.TabIndex = 10;
            // 
            // textBox_fax
            // 
            this.textBox_fax.Location = new System.Drawing.Point(823, 72);
            this.textBox_fax.Name = "textBox_fax";
            this.textBox_fax.Size = new System.Drawing.Size(142, 20);
            this.textBox_fax.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(24, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 13);
            this.label.TabIndex = 12;
            this.label.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Company Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contact Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contact Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Region:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Postal Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Country:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(763, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fax:";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(195, 182);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 23;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(349, 181);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 24;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(501, 180);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 25;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_customerID
            // 
            this.textBox_customerID.Location = new System.Drawing.Point(111, 24);
            this.textBox_customerID.Name = "textBox_customerID";
            this.textBox_customerID.Size = new System.Drawing.Size(142, 20);
            this.textBox_customerID.TabIndex = 26;
            // 
            // customerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 563);
            this.Controls.Add(this.textBox_customerID);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox_fax);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.textBox_postalCode);
            this.Controls.Add(this.textBox_region);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_contactTitle);
            this.Controls.Add(this.textBox_contactName);
            this.Controls.Add(this.textBox_companyName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "customerTable";
            this.Text = "customerTable";
            this.Load += new System.EventHandler(this.customerTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_companyName;
        private System.Windows.Forms.TextBox textBox_contactName;
        private System.Windows.Forms.TextBox textBox_contactTitle;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.TextBox textBox_region;
        private System.Windows.Forms.TextBox textBox_postalCode;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_fax;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_customerID;
    }
}