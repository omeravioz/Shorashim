namespace ShorashimSystem
{
    partial class CancleSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancleSale));
            this.Category_b = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.OrderId = new System.Windows.Forms.Label();
            this.PurchaseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.OrderPrice = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCart = new System.Windows.Forms.Button();
            this.PromotionComboBoxChoose = new System.Windows.Forms.Label();
            this.PromotionCode = new System.Windows.Forms.ComboBox();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Main_Label = new System.Windows.Forms.Label();
            this.PMInput = new System.Windows.Forms.ComboBox();
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.AddCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_b
            // 
            this.Category_b.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Category_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Category_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Category_b.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_b.Location = new System.Drawing.Point(145, 161);
            this.Category_b.Name = "Category_b";
            this.Category_b.Size = new System.Drawing.Size(199, 33);
            this.Category_b.TabIndex = 71;
            this.Category_b.Text = "Category";
            this.Category_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Category
            // 
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(384, 161);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(248, 32);
            this.Category.TabIndex = 85;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // OrderId
            // 
            this.OrderId.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrderId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderId.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderId.Location = new System.Drawing.Point(145, 108);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(199, 33);
            this.OrderId.TabIndex = 86;
            this.OrderId.Text = "Purchase ID";
            this.OrderId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchaseID
            // 
            this.PurchaseID.BackColor = System.Drawing.SystemColors.Menu;
            this.PurchaseID.Cursor = System.Windows.Forms.Cursors.No;
            this.PurchaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PurchaseID.Location = new System.Drawing.Point(384, 108);
            this.PurchaseID.Multiline = true;
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.Size = new System.Drawing.Size(248, 33);
            this.PurchaseID.TabIndex = 87;
            this.PurchaseID.TextChanged += new System.EventHandler(this.PurchaseID_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 88;
            this.label1.Text = "Product Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductName
            // 
            this.ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductName.FormattingEnabled = true;
            this.ProductName.Location = new System.Drawing.Point(384, 215);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(248, 32);
            this.ProductName.TabIndex = 89;
            this.ProductName.SelectedIndexChanged += new System.EventHandler(this.ProductName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 90;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.SystemColors.Menu;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Quantity.Location = new System.Drawing.Point(848, 270);
            this.Quantity.Multiline = true;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(69, 31);
            this.Quantity.TabIndex = 91;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 33);
            this.label3.TabIndex = 92;
            this.label3.Text = "Employee ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeID
            // 
            this.EmployeeID.BackColor = System.Drawing.SystemColors.Menu;
            this.EmployeeID.Cursor = System.Windows.Forms.Cursors.No;
            this.EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EmployeeID.Location = new System.Drawing.Point(922, 106);
            this.EmployeeID.Multiline = true;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(248, 33);
            this.EmployeeID.TabIndex = 93;
            this.EmployeeID.TextChanged += new System.EventHandler(this.EmployeeID_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(695, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 33);
            this.label4.TabIndex = 94;
            this.label4.Text = "Customer ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerID
            // 
            this.CustomerID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomerID.Location = new System.Drawing.Point(922, 161);
            this.CustomerID.MaxLength = 1000;
            this.CustomerID.Multiline = true;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(248, 32);
            this.CustomerID.TabIndex = 95;
            this.CustomerID.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // OrderPrice
            // 
            this.OrderPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderPrice.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPrice.Location = new System.Drawing.Point(143, 503);
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.Size = new System.Drawing.Size(199, 33);
            this.OrderPrice.TabIndex = 96;
            this.OrderPrice.Text = "Total Price";
            this.OrderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.TotalPrice.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TotalPrice.Location = new System.Drawing.Point(368, 503);
            this.TotalPrice.Multiline = true;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(115, 33);
            this.TotalPrice.TabIndex = 97;
            this.TotalPrice.TextChanged += new System.EventHandler(this.TotalPrice_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Product_name,
            this.dataGridViewTextBoxColumn2,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(145, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 207);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Category";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Product Name";
            this.Product_name.Name = "Product_name";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // AddToCart
            // 
            this.AddToCart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToCart.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCart.Location = new System.Drawing.Point(950, 270);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(136, 32);
            this.AddToCart.TabIndex = 99;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.UseVisualStyleBackColor = false;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // PromotionComboBoxChoose
            // 
            this.PromotionComboBoxChoose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PromotionComboBoxChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PromotionComboBoxChoose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PromotionComboBoxChoose.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromotionComboBoxChoose.Location = new System.Drawing.Point(523, 503);
            this.PromotionComboBoxChoose.Name = "PromotionComboBoxChoose";
            this.PromotionComboBoxChoose.Size = new System.Drawing.Size(199, 33);
            this.PromotionComboBoxChoose.TabIndex = 100;
            this.PromotionComboBoxChoose.Text = "Promotion Code";
            this.PromotionComboBoxChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PromotionCode
            // 
            this.PromotionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PromotionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PromotionCode.FormattingEnabled = true;
            this.PromotionCode.Location = new System.Drawing.Point(743, 503);
            this.PromotionCode.Name = "PromotionCode";
            this.PromotionCode.Size = new System.Drawing.Size(205, 32);
            this.PromotionCode.TabIndex = 101;
            this.PromotionCode.SelectedIndexChanged += new System.EventHandler(this.PromotionCode_SelectedIndexChanged);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(695, 454);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrder.TabIndex = 102;
            this.DeleteOrder.Text = "Delete Order";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click_1);
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pay.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.Location = new System.Drawing.Point(992, 447);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(140, 33);
            this.Pay.TabIndex = 103;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Pink;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(992, 501);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 33);
            this.CancelButton.TabIndex = 104;
            this.CancelButton.Text = "Cancel sale!";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Main_Label
            // 
            this.Main_Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Main_Label.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Label.ForeColor = System.Drawing.Color.White;
            this.Main_Label.Location = new System.Drawing.Point(-22, 9);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(1266, 55);
            this.Main_Label.TabIndex = 106;
            this.Main_Label.Text = "New Sale To Customer";
            this.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PMInput
            // 
            this.PMInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PMInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PMInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PMInput.FormattingEnabled = true;
            this.PMInput.Location = new System.Drawing.Point(932, 213);
            this.PMInput.Name = "PMInput";
            this.PMInput.Size = new System.Drawing.Size(84, 32);
            this.PMInput.TabIndex = 108;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PaymentMethod.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(696, 213);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(199, 33);
            this.PaymentMethod.TabIndex = 107;
            this.PaymentMethod.Text = "Payment Method";
            this.PaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCustomer.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.Location = new System.Drawing.Point(1040, 212);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(140, 33);
            this.AddCustomer.TabIndex = 109;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // CancleSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1219, 557);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.PMInput);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.Main_Label);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.PromotionCode);
            this.Controls.Add(this.PromotionComboBoxChoose);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.OrderPrice);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchaseID);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Category_b);
            this.Name = "CancleSale";
            this.Text = "New Sale";
            this.Load += new System.EventHandler(this.CancleSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Category_b;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label OrderId;
        private System.Windows.Forms.TextBox PurchaseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label OrderPrice;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label PromotionComboBoxChoose;
        private System.Windows.Forms.ComboBox PromotionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.ComboBox PMInput;
        private System.Windows.Forms.Label PaymentMethod;
        private System.Windows.Forms.Button AddCustomer;
    }
}