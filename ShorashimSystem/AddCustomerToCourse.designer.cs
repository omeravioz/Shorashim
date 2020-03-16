namespace ShorashimSystem
{
    partial class AddCustomerToCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerToCourse));
            this.CourseName = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.CN = new System.Windows.Forms.ComboBox();
            this.CID = new System.Windows.Forms.TextBox();
            this.DateTime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.DescrriptionBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseName
            // 
            this.CourseName.BackColor = System.Drawing.Color.Black;
            this.CourseName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CourseName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CourseName.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseName.Location = new System.Drawing.Point(397, 21);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(199, 33);
            this.CourseName.TabIndex = 90;
            this.CourseName.Text = "Course Name";
            this.CourseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerID
            // 
            this.CustomerID.BackColor = System.Drawing.Color.Black;
            this.CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CustomerID.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerID.Location = new System.Drawing.Point(397, 75);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(199, 33);
            this.CustomerID.TabIndex = 91;
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Black;
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Date.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Date.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(397, 128);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(199, 33);
            this.Date.TabIndex = 92;
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // CN
            // 
            this.CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CN.FormattingEnabled = true;
            this.CN.Location = new System.Drawing.Point(653, 21);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(248, 32);
            this.CN.TabIndex = 93;
            this.CN.SelectedIndexChanged += new System.EventHandler(this.CN_SelectedIndexChanged);
            // 
            // CID
            // 
            this.CID.BackColor = System.Drawing.SystemColors.Menu;
            this.CID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CID.Location = new System.Drawing.Point(653, 75);
            this.CID.Multiline = true;
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(248, 33);
            this.CID.TabIndex = 94;
            this.CID.TextChanged += new System.EventHandler(this.CID_TextChanged);
            // 
            // DateTime
            // 
            this.DateTime.BackColor = System.Drawing.SystemColors.Menu;
            this.DateTime.Cursor = System.Windows.Forms.Cursors.No;
            this.DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DateTime.Location = new System.Drawing.Point(653, 128);
            this.DateTime.Multiline = true;
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Size = new System.Drawing.Size(248, 33);
            this.DateTime.TabIndex = 95;
            this.DateTime.TextChanged += new System.EventHandler(this.DateTime_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Product_name,
            this.Category,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(397, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(640, 260);
            this.dataGridView1.TabIndex = 96;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "CustomerID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Course Name";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Date";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Add.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(1048, 270);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(133, 53);
            this.Add.TabIndex = 97;
            this.Add.Text = "Add Customer";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteProduct.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.Location = new System.Drawing.Point(1048, 329);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(133, 53);
            this.DeleteProduct.TabIndex = 98;
            this.DeleteProduct.Text = "Delete Customer";
            this.DeleteProduct.UseVisualStyleBackColor = false;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.LightCoral;
            this.Exitbutton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(1144, 482);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(128, 46);
            this.Exitbutton.TabIndex = 99;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.LightGreen;
            this.Submit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(978, 482);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(128, 46);
            this.Submit.TabIndex = 100;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // DescrriptionBox
            // 
            this.DescrriptionBox.BackColor = System.Drawing.Color.Silver;
            this.DescrriptionBox.Cursor = System.Windows.Forms.Cursors.No;
            this.DescrriptionBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescrriptionBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DescrriptionBox.Location = new System.Drawing.Point(964, 46);
            this.DescrriptionBox.Multiline = true;
            this.DescrriptionBox.Name = "DescrriptionBox";
            this.DescrriptionBox.ReadOnly = true;
            this.DescrriptionBox.Size = new System.Drawing.Size(311, 118);
            this.DescrriptionBox.TabIndex = 102;
            this.DescrriptionBox.TextChanged += new System.EventHandler(this.DescrriptionBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DescriptionLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DescriptionLabel.Location = new System.Drawing.Point(999, 9);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(220, 34);
            this.DescriptionLabel.TabIndex = 101;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCustomerToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1295, 556);
            this.Controls.Add(this.DescrriptionBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.CN);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.CourseName);
            this.Name = "AddCustomerToCourse";
            this.Text = "AddCustomerToCourse";
            this.Load += new System.EventHandler(this.AddCustomerToCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.ComboBox CN;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.TextBox DateTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox DescrriptionBox;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}