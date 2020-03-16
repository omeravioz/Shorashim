namespace ShorashimSystem
{
    partial class InsertProductsToCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertProductsToCourse));
            this.ComboTextChooseProduct = new System.Windows.Forms.ComboBox();
            this.BoxChooseProduct = new System.Windows.Forms.Label();
            this.CourseNameInput = new System.Windows.Forms.TextBox();
            this.CourseName = new System.Windows.Forms.Label();
            this.CourseNumberInput = new System.Windows.Forms.TextBox();
            this.CourseNumber = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.QuantityFromUser = new System.Windows.Forms.TextBox();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.TotCostToCom = new System.Windows.Forms.Label();
            this.costoutput = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboTextChooseProduct
            // 
            this.ComboTextChooseProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTextChooseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ComboTextChooseProduct.FormattingEnabled = true;
            this.ComboTextChooseProduct.Location = new System.Drawing.Point(317, 212);
            this.ComboTextChooseProduct.Name = "ComboTextChooseProduct";
            this.ComboTextChooseProduct.Size = new System.Drawing.Size(248, 32);
            this.ComboTextChooseProduct.TabIndex = 91;
            this.ComboTextChooseProduct.SelectedIndexChanged += new System.EventHandler(this.ComboTextChooseProduct_SelectedIndexChanged);
            // 
            // BoxChooseProduct
            // 
            this.BoxChooseProduct.BackColor = System.Drawing.Color.Black;
            this.BoxChooseProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BoxChooseProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BoxChooseProduct.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxChooseProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BoxChooseProduct.Location = new System.Drawing.Point(81, 211);
            this.BoxChooseProduct.Name = "BoxChooseProduct";
            this.BoxChooseProduct.Size = new System.Drawing.Size(199, 33);
            this.BoxChooseProduct.TabIndex = 90;
            this.BoxChooseProduct.Text = "Choose Product";
            this.BoxChooseProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseNameInput
            // 
            this.CourseNameInput.BackColor = System.Drawing.SystemColors.Menu;
            this.CourseNameInput.Cursor = System.Windows.Forms.Cursors.No;
            this.CourseNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CourseNameInput.Location = new System.Drawing.Point(317, 164);
            this.CourseNameInput.Multiline = true;
            this.CourseNameInput.Name = "CourseNameInput";
            this.CourseNameInput.ReadOnly = true;
            this.CourseNameInput.Size = new System.Drawing.Size(248, 33);
            this.CourseNameInput.TabIndex = 88;
            // 
            // CourseName
            // 
            this.CourseName.BackColor = System.Drawing.Color.Black;
            this.CourseName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CourseName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CourseName.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseName.Location = new System.Drawing.Point(81, 164);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(199, 33);
            this.CourseName.TabIndex = 89;
            this.CourseName.Text = "Course Name";
            this.CourseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseNumberInput
            // 
            this.CourseNumberInput.BackColor = System.Drawing.SystemColors.Menu;
            this.CourseNumberInput.Cursor = System.Windows.Forms.Cursors.No;
            this.CourseNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CourseNumberInput.Location = new System.Drawing.Point(317, 115);
            this.CourseNumberInput.Multiline = true;
            this.CourseNumberInput.Name = "CourseNumberInput";
            this.CourseNumberInput.ReadOnly = true;
            this.CourseNumberInput.Size = new System.Drawing.Size(248, 33);
            this.CourseNumberInput.TabIndex = 88;
            this.CourseNumberInput.TextChanged += new System.EventHandler(this.CourseNumberInput_TextChanged);
            // 
            // CourseNumber
            // 
            this.CourseNumber.BackColor = System.Drawing.Color.Black;
            this.CourseNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CourseNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CourseNumber.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseNumber.Location = new System.Drawing.Point(81, 115);
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.Size = new System.Drawing.Size(199, 33);
            this.CourseNumber.TabIndex = 89;
            this.CourseNumber.Text = "Course Number";
            this.CourseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.LightCoral;
            this.Exitbutton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(1293, 416);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(128, 46);
            this.Exitbutton.TabIndex = 93;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Product_name,
            this.Category,
            this.Quantity,
            this.Price,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(616, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(640, 260);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Product Name";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
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
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LightGreen;
            this.Add.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(444, 298);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(133, 53);
            this.Add.TabIndex = 95;
            this.Add.Text = "Add Product";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.BackColor = System.Drawing.Color.Crimson;
            this.DeleteProduct.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.Location = new System.Drawing.Point(289, 298);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(128, 53);
            this.DeleteProduct.TabIndex = 96;
            this.DeleteProduct.Text = "Delete Product";
            this.DeleteProduct.UseVisualStyleBackColor = false;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // QuantityFromUser
            // 
            this.QuantityFromUser.BackColor = System.Drawing.SystemColors.Menu;
            this.QuantityFromUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QuantityFromUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.QuantityFromUser.HideSelection = false;
            this.QuantityFromUser.Location = new System.Drawing.Point(317, 256);
            this.QuantityFromUser.Multiline = true;
            this.QuantityFromUser.Name = "QuantityFromUser";
            this.QuantityFromUser.Size = new System.Drawing.Size(75, 33);
            this.QuantityFromUser.TabIndex = 88;
            this.QuantityFromUser.TextChanged += new System.EventHandler(this.QuantityFromUser_TextChanged);
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.BackColor = System.Drawing.Color.Black;
            this.Quantitylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Quantitylabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Quantitylabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quantitylabel.Location = new System.Drawing.Point(81, 256);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(199, 33);
            this.Quantitylabel.TabIndex = 89;
            this.Quantitylabel.Text = "Quantity";
            this.Quantitylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotCostToCom
            // 
            this.TotCostToCom.BackColor = System.Drawing.Color.Black;
            this.TotCostToCom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotCostToCom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TotCostToCom.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotCostToCom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotCostToCom.Location = new System.Drawing.Point(1036, 374);
            this.TotCostToCom.Name = "TotCostToCom";
            this.TotCostToCom.Size = new System.Drawing.Size(134, 33);
            this.TotCostToCom.TabIndex = 89;
            this.TotCostToCom.Text = "TOT Cost";
            this.TotCostToCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costoutput
            // 
            this.costoutput.BackColor = System.Drawing.SystemColors.Menu;
            this.costoutput.Cursor = System.Windows.Forms.Cursors.No;
            this.costoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.costoutput.Location = new System.Drawing.Point(1188, 374);
            this.costoutput.Multiline = true;
            this.costoutput.Name = "costoutput";
            this.costoutput.ReadOnly = true;
            this.costoutput.Size = new System.Drawing.Size(77, 33);
            this.costoutput.TabIndex = 88;
            this.costoutput.TextChanged += new System.EventHandler(this.costoutput_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.LightGreen;
            this.Submit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(1128, 416);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(128, 46);
            this.Submit.TabIndex = 97;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // InsertProductsToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1451, 485);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.ComboTextChooseProduct);
            this.Controls.Add(this.BoxChooseProduct);
            this.Controls.Add(this.CourseNumber);
            this.Controls.Add(this.TotCostToCom);
            this.Controls.Add(this.Quantitylabel);
            this.Controls.Add(this.costoutput);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.CourseNumberInput);
            this.Controls.Add(this.QuantityFromUser);
            this.Controls.Add(this.CourseNameInput);
            this.DoubleBuffered = true;
            this.Name = "InsertProductsToCourse";
            this.Text = "InsertProductsToCourse";
            this.Load += new System.EventHandler(this.InsertProductsToCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboTextChooseProduct;
        private System.Windows.Forms.Label BoxChooseProduct;
        private System.Windows.Forms.TextBox CourseNameInput;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.TextBox CourseNumberInput;
        private System.Windows.Forms.Label CourseNumber;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.TextBox QuantityFromUser;
        private System.Windows.Forms.Label Quantitylabel;
        private System.Windows.Forms.Label TotCostToCom;
        private System.Windows.Forms.TextBox costoutput;
        private System.Windows.Forms.Button Submit;
    }
}