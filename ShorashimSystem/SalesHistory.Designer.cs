namespace ShorashimSystem
{
    partial class ED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ED));
            this.SD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.Show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.purchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BacklButton = new System.Windows.Forms.Button();
            this.Main_Label = new System.Windows.Forms.Label();
            this.MoreDetails = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // SD
            // 
            this.SD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SD.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SD.Location = new System.Drawing.Point(107, 142);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(199, 33);
            this.SD.TabIndex = 97;
            this.SD.Text = "Start Date";
            this.SD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 98;
            this.label1.Text = "End Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndDate
            // 
            this.EndDate.CausesValidation = false;
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EndDate.Location = new System.Drawing.Point(856, 142);
            this.EndDate.MinDate = new System.DateTime(2019, 6, 16, 0, 0, 0, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(213, 31);
            this.EndDate.TabIndex = 100;
            this.EndDate.Value = new System.DateTime(2038, 8, 13, 0, 0, 0, 0);
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // StartDate
            // 
            this.StartDate.CausesValidation = false;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StartDate.Location = new System.Drawing.Point(351, 143);
            this.StartDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(213, 31);
            this.StartDate.TabIndex = 101;
            this.StartDate.Value = new System.DateTime(2019, 6, 15, 15, 10, 53, 0);
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(912, 304);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(136, 41);
            this.Show.TabIndex = 102;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseID,
            this.Price,
            this.Employee,
            this.Customer,
            this.paymentMethod,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(189, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 183);
            this.dataGridView1.TabIndex = 103;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // purchaseID
            // 
            this.purchaseID.HeaderText = "purchaseID";
            this.purchaseID.Name = "purchaseID";
            this.purchaseID.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Total Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // paymentMethod
            // 
            this.paymentMethod.HeaderText = "Payment Method";
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // BacklButton
            // 
            this.BacklButton.BackColor = System.Drawing.Color.Pink;
            this.BacklButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BacklButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklButton.Location = new System.Drawing.Point(489, 566);
            this.BacklButton.Name = "BacklButton";
            this.BacklButton.Size = new System.Drawing.Size(140, 49);
            this.BacklButton.TabIndex = 104;
            this.BacklButton.Text = "Back";
            this.BacklButton.UseVisualStyleBackColor = false;
            this.BacklButton.Click += new System.EventHandler(this.BacklButton_Click);
            // 
            // Main_Label
            // 
            this.Main_Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Main_Label.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Label.ForeColor = System.Drawing.Color.White;
            this.Main_Label.Location = new System.Drawing.Point(-70, 31);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(1266, 55);
            this.Main_Label.TabIndex = 105;
            this.Main_Label.Text = "Sales History";
            this.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoreDetails
            // 
            this.MoreDetails.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.MoreDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreDetails.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreDetails.Location = new System.Drawing.Point(912, 371);
            this.MoreDetails.Name = "MoreDetails";
            this.MoreDetails.Size = new System.Drawing.Size(136, 41);
            this.MoreDetails.TabIndex = 106;
            this.MoreDetails.Text = "More Details";
            this.MoreDetails.UseVisualStyleBackColor = false;
            this.MoreDetails.Click += new System.EventHandler(this.MoreDetails_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Name,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(336, 405);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(447, 144);
            this.dataGridView2.TabIndex = 107;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 627);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MoreDetails);
            this.Controls.Add(this.Main_Label);
            this.Controls.Add(this.BacklButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SD);
           
            this.Text = "Sales History";
            this.Load += new System.EventHandler(this.ED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BacklButton;
        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button MoreDetails;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}