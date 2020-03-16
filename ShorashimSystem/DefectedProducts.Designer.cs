namespace ShorashimSystem
{
    partial class DefectedProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectedProducts));
            this.SD = new System.Windows.Forms.Label();
            this.Supplier_b = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Category_b = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Supplier = new System.Windows.Forms.ComboBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.photoHistorySales = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoHistorySales)).BeginInit();
            this.SuspendLayout();
            // 
            // SD
            // 
            this.SD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SD.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SD.Location = new System.Drawing.Point(185, 31);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(243, 33);
            this.SD.TabIndex = 98;
            this.SD.Text = "Defected Products";
            this.SD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Supplier_b
            // 
            this.Supplier_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supplier_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Supplier_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Supplier_b.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_b.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Supplier_b.Location = new System.Drawing.Point(57, 132);
            this.Supplier_b.Name = "Supplier_b";
            this.Supplier_b.Size = new System.Drawing.Size(199, 33);
            this.Supplier_b.TabIndex = 99;
            this.Supplier_b.Text = "Supplier";
            this.Supplier_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 100;
            this.label1.Text = "Product Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Category_b
            // 
            this.Category_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Category_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Category_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Category_b.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Category_b.Location = new System.Drawing.Point(57, 195);
            this.Category_b.Name = "Category_b";
            this.Category_b.Size = new System.Drawing.Size(199, 33);
            this.Category_b.TabIndex = 101;
            this.Category_b.Text = "Category";
            this.Category_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductName
            // 
            this.ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductName.FormattingEnabled = true;
            this.ProductName.Location = new System.Drawing.Point(300, 265);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(248, 32);
            this.ProductName.TabIndex = 104;
            this.ProductName.SelectedIndexChanged += new System.EventHandler(this.ProductName_SelectedIndexChanged);
            // 
            // Category
            // 
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(300, 196);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(248, 32);
            this.Category.TabIndex = 105;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // Supplier
            // 
            this.Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Supplier.FormattingEnabled = true;
            this.Supplier.Location = new System.Drawing.Point(300, 132);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(248, 32);
            this.Supplier.TabIndex = 106;
            this.Supplier.SelectedIndexChanged += new System.EventHandler(this.Supplier_SelectedIndexChanged);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(151, 468);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(136, 55);
            this.AddProductButton.TabIndex = 107;
            this.AddProductButton.Text = "Send Product To Supplier";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Product_name,
            this.Quantity,
            this.NewQuantity});
            this.dataGridView1.Location = new System.Drawing.Point(41, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 61);
            this.dataGridView1.TabIndex = 108;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // NewQuantity
            // 
            this.NewQuantity.HeaderText = "New Quantity";
            this.NewQuantity.Name = "NewQuantity";
            this.NewQuantity.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(300, 325);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 33);
            this.textBox1.TabIndex = 110;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 33);
            this.label2.TabIndex = 109;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Pink;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(362, 478);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 33);
            this.CancelButton.TabIndex = 111;
            this.CancelButton.Text = "Back";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // photoHistorySales
            // 
            this.photoHistorySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.photoHistorySales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoHistorySales.Cursor = System.Windows.Forms.Cursors.Default;
            this.photoHistorySales.Image = ((System.Drawing.Image)(resources.GetObject("photoHistorySales.Image")));
            this.photoHistorySales.Location = new System.Drawing.Point(626, 12);
            this.photoHistorySales.Name = "photoHistorySales";
            this.photoHistorySales.Size = new System.Drawing.Size(317, 533);
            this.photoHistorySales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoHistorySales.TabIndex = 112;
            this.photoHistorySales.TabStop = false;
            // 
            // DefectedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 609);
            this.Controls.Add(this.photoHistorySales);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.Category_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Supplier_b);
            this.Controls.Add(this.SD);
            this.Name = "DefectedProducts";
            this.Text = "Defected Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoHistorySales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SD;
        private System.Windows.Forms.Label Supplier_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Category_b;
        private System.Windows.Forms.ComboBox ProductName;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.ComboBox Supplier;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewQuantity;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox photoHistorySales;
    }
}