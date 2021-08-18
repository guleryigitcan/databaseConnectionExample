namespace databaseConnectionExample
{
    partial class Form2
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.goToItemForm = new System.Windows.Forms.Button();
            this.comboBox_ProductID = new System.Windows.Forms.ComboBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_unitPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Product ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Quantity:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Unit Price:";
            // 
            // goToItemForm
            // 
            this.goToItemForm.Location = new System.Drawing.Point(134, 189);
            this.goToItemForm.Name = "goToItemForm";
            this.goToItemForm.Size = new System.Drawing.Size(75, 23);
            this.goToItemForm.TabIndex = 29;
            this.goToItemForm.Text = "Add Item";
            this.goToItemForm.UseVisualStyleBackColor = true;
            this.goToItemForm.Click += new System.EventHandler(this.goToItemForm_Click);
            // 
            // comboBox_ProductID
            // 
            this.comboBox_ProductID.FormattingEnabled = true;
            this.comboBox_ProductID.Location = new System.Drawing.Point(112, 60);
            this.comboBox_ProductID.Name = "comboBox_ProductID";
            this.comboBox_ProductID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ProductID.TabIndex = 30;
            this.comboBox_ProductID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProductID_SelectedIndexChanged);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(112, 99);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(121, 20);
            this.textBox_Quantity.TabIndex = 31;
            // 
            // textBox_unitPrice
            // 
            this.textBox_unitPrice.Location = new System.Drawing.Point(112, 136);
            this.textBox_unitPrice.Name = "textBox_unitPrice";
            this.textBox_unitPrice.Size = new System.Drawing.Size(121, 20);
            this.textBox_unitPrice.TabIndex = 32;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.textBox_unitPrice);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.comboBox_ProductID);
            this.Controls.Add(this.goToItemForm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button goToItemForm;
        private System.Windows.Forms.ComboBox comboBox_ProductID;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.TextBox textBox_unitPrice;
    }
}