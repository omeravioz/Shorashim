namespace ShorashimSystem
{
    partial class OrderProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderProducts));
            this.CancelButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.OrderOutput = new System.Windows.Forms.TextBox();
            this.OrderDateInput = new System.Windows.Forms.TextBox();
            this.OrderPrice = new System.Windows.Forms.Label();
            this.OrderDueDate = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Category_b = new System.Windows.Forms.Label();
            this.OrderId = new System.Windows.Forms.Label();
            this.OrderIDInput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Supplier_b = new System.Windows.Forms.Label();
            this.SupllierInput = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.PMInput = new System.Windows.Forms.ComboBox();
            this.DescrriptionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.OrderFromSupplierButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Pink;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(606, 565);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 33);
            this.CancelButton.TabIndex = 83;
            this.CancelButton.Text = "Cancel!";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(391, 565);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(136, 33);
            this.Save.TabIndex = 82;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // OrderOutput
            // 
            this.OrderOutput.BackColor = System.Drawing.Color.AliceBlue;
            this.OrderOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.OrderOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OrderOutput.Location = new System.Drawing.Point(625, 512);
            this.OrderOutput.Multiline = true;
            this.OrderOutput.Name = "OrderOutput";
            this.OrderOutput.Size = new System.Drawing.Size(199, 26);
            this.OrderOutput.TabIndex = 81;
            this.OrderOutput.TextChanged += new System.EventHandler(this.OrderOutput_TextChanged);
            // 
            // OrderDateInput
            // 
            this.OrderDateInput.BackColor = System.Drawing.SystemColors.Menu;
            this.OrderDateInput.Cursor = System.Windows.Forms.Cursors.No;
            this.OrderDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OrderDateInput.Location = new System.Drawing.Point(135, 512);
            this.OrderDateInput.Multiline = true;
            this.OrderDateInput.Name = "OrderDateInput";
            this.OrderDateInput.Size = new System.Drawing.Size(199, 26);
            this.OrderDateInput.TabIndex = 79;
            this.OrderDateInput.TextChanged += new System.EventHandler(this.OrderDateInput_TextChanged);
            // 
            // OrderPrice
            // 
            this.OrderPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderPrice.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderPrice.Location = new System.Drawing.Point(625, 456);
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.Size = new System.Drawing.Size(199, 33);
            this.OrderPrice.TabIndex = 78;
            this.OrderPrice.Text = "Order Price";
            this.OrderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderDueDate
            // 
            this.OrderDueDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderDueDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderDueDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderDueDate.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDueDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderDueDate.Location = new System.Drawing.Point(377, 456);
            this.OrderDueDate.Name = "OrderDueDate";
            this.OrderDueDate.Size = new System.Drawing.Size(199, 33);
            this.OrderDueDate.TabIndex = 77;
            this.OrderDueDate.Text = "Order Due Date";
            this.OrderDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderDate
            // 
            this.OrderDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderDate.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderDate.Location = new System.Drawing.Point(135, 456);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(199, 33);
            this.OrderDate.TabIndex = 76;
            this.OrderDate.Text = "Order Date";
            this.OrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(268, 339);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 33);
            this.textBox1.TabIndex = 74;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 33);
            this.label2.TabIndex = 73;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 72;
            this.label1.Text = "Product Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Category_b
            // 
            this.Category_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Category_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Category_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Category_b.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Category_b.Location = new System.Drawing.Point(32, 223);
            this.Category_b.Name = "Category_b";
            this.Category_b.Size = new System.Drawing.Size(199, 33);
            this.Category_b.TabIndex = 70;
            this.Category_b.Text = "Category";
            this.Category_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Category_b.Click += new System.EventHandler(this.Category_Click);
            // 
            // OrderId
            // 
            this.OrderId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderId.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderId.Location = new System.Drawing.Point(32, 102);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(199, 33);
            this.OrderId.TabIndex = 66;
            this.OrderId.Text = "Order ID";
            this.OrderId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderIDInput
            // 
            this.OrderIDInput.BackColor = System.Drawing.SystemColors.Menu;
            this.OrderIDInput.Cursor = System.Windows.Forms.Cursors.No;
            this.OrderIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OrderIDInput.Location = new System.Drawing.Point(268, 102);
            this.OrderIDInput.Multiline = true;
            this.OrderIDInput.Name = "OrderIDInput";
            this.OrderIDInput.Size = new System.Drawing.Size(248, 33);
            this.OrderIDInput.TabIndex = 65;
            this.OrderIDInput.TextChanged += new System.EventHandler(this.OrderIDInput_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 32);
            this.comboBox1.TabIndex = 84;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(268, 281);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 32);
            this.comboBox2.TabIndex = 85;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Supplier_b
            // 
            this.Supplier_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supplier_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Supplier_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Supplier_b.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Supplier_b.Location = new System.Drawing.Point(32, 161);
            this.Supplier_b.Name = "Supplier_b";
            this.Supplier_b.Size = new System.Drawing.Size(199, 33);
            this.Supplier_b.TabIndex = 86;
            this.Supplier_b.Text = "Supplier";
            this.Supplier_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Supplier_b.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // SupllierInput
            // 
            this.SupllierInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupllierInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SupllierInput.FormattingEnabled = true;
            this.SupllierInput.Location = new System.Drawing.Point(268, 162);
            this.SupllierInput.Name = "SupllierInput";
            this.SupllierInput.Size = new System.Drawing.Size(248, 32);
            this.SupllierInput.TabIndex = 87;
            this.SupllierInput.SelectedIndexChanged += new System.EventHandler(this.SupllierInput_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supplier,
            this.Category,
            this.Product_name,
            this.Quantity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(551, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 266);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Product Name";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 512);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 6, 15, 15, 10, 53, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 26);
            this.dateTimePicker1.TabIndex = 89;
            this.dateTimePicker1.Value = new System.DateTime(2019, 6, 15, 15, 10, 53, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(983, 381);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrder.TabIndex = 90;
            this.DeleteOrder.Text = "Delete Order";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PaymentMethod.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaymentMethod.Location = new System.Drawing.Point(32, 395);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(199, 33);
            this.PaymentMethod.TabIndex = 91;
            this.PaymentMethod.Text = "Payment Method";
            this.PaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PaymentMethod.Click += new System.EventHandler(this.PaymentMethod_Click);
            // 
            // PMInput
            // 
            this.PMInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PMInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PMInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PMInput.FormattingEnabled = true;
            this.PMInput.Location = new System.Drawing.Point(268, 395);
            this.PMInput.Name = "PMInput";
            this.PMInput.Size = new System.Drawing.Size(84, 32);
            this.PMInput.TabIndex = 92;
            this.PMInput.SelectedIndexChanged += new System.EventHandler(this.PMInput_SelectedIndexChanged);
            // 
            // DescrriptionBox
            // 
            this.DescrriptionBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescrriptionBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescrriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DescrriptionBox.Location = new System.Drawing.Point(858, 511);
            this.DescrriptionBox.Multiline = true;
            this.DescrriptionBox.Name = "DescrriptionBox";
            this.DescrriptionBox.Size = new System.Drawing.Size(290, 27);
            this.DescrriptionBox.TabIndex = 93;
            this.DescrriptionBox.TextChanged += new System.EventHandler(this.DescrriptionBox_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(891, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 33);
            this.label3.TabIndex = 94;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(380, 338);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(136, 33);
            this.AddProductButton.TabIndex = 95;
            this.AddProductButton.Text = "Add To Order";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // OrderFromSupplierButton
            // 
            this.OrderFromSupplierButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderFromSupplierButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderFromSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderFromSupplierButton.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFromSupplierButton.ForeColor = System.Drawing.Color.White;
            this.OrderFromSupplierButton.Location = new System.Drawing.Point(-172, 9);
            this.OrderFromSupplierButton.Name = "OrderFromSupplierButton";
            this.OrderFromSupplierButton.Size = new System.Drawing.Size(1499, 55);
            this.OrderFromSupplierButton.TabIndex = 107;
            this.OrderFromSupplierButton.Text = "Order From Supplier";
            this.OrderFromSupplierButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1159, 638);
            this.Controls.Add(this.OrderFromSupplierButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescrriptionBox);
            this.Controls.Add(this.PMInput);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SupllierInput);
            this.Controls.Add(this.Supplier_b);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.OrderOutput);
            this.Controls.Add(this.OrderDateInput);
            this.Controls.Add(this.OrderPrice);
            this.Controls.Add(this.OrderDueDate);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Category_b);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.OrderIDInput);
            this.Name = "OrderProducts";
            this.Text = "Order Products";
            this.Load += new System.EventHandler(this.OrderProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox OrderOutput;
        private System.Windows.Forms.TextBox OrderDateInput;
        private System.Windows.Forms.Label OrderPrice;
        private System.Windows.Forms.Label OrderDueDate;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Category_b;
        private System.Windows.Forms.Label OrderId;
        private System.Windows.Forms.TextBox OrderIDInput;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Supplier_b;
        private System.Windows.Forms.ComboBox SupllierInput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Label PaymentMethod;
        private System.Windows.Forms.ComboBox PMInput;
        private System.Windows.Forms.TextBox DescrriptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label OrderFromSupplierButton;
    }
}