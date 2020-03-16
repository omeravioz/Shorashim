namespace ShorashimSystem
{
    partial class Main_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.ExitButton1 = new System.Windows.Forms.Button();
            this.OrderFromSupplierButton = new System.Windows.Forms.Button();
            this.PromotionByMailButton = new System.Windows.Forms.Button();
            this.ID_LABEL = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.InventoryManagementButton = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.CoursesManagementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton1
            // 
            this.ExitButton1.AccessibleName = "";
            this.ExitButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton1.Location = new System.Drawing.Point(591, 502);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(237, 35);
            this.ExitButton1.TabIndex = 14;
            this.ExitButton1.Text = "EXIT ";
            this.ExitButton1.UseVisualStyleBackColor = false;
            this.ExitButton1.Click += new System.EventHandler(this.ExitButton1_Click);
            // 
            // OrderFromSupplierButton
            // 
            this.OrderFromSupplierButton.AccessibleName = "";
            this.OrderFromSupplierButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderFromSupplierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderFromSupplierButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFromSupplierButton.Location = new System.Drawing.Point(590, 287);
            this.OrderFromSupplierButton.Name = "OrderFromSupplierButton";
            this.OrderFromSupplierButton.Size = new System.Drawing.Size(237, 35);
            this.OrderFromSupplierButton.TabIndex = 17;
            this.OrderFromSupplierButton.Text = "ORDER FROM SUPPLIER";
            this.OrderFromSupplierButton.UseVisualStyleBackColor = false;
            this.OrderFromSupplierButton.Click += new System.EventHandler(this.OrderFromSupplierButton_Click);
            // 
            // PromotionByMailButton
            // 
            this.PromotionByMailButton.AccessibleName = "";
            this.PromotionByMailButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PromotionByMailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PromotionByMailButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromotionByMailButton.Location = new System.Drawing.Point(590, 328);
            this.PromotionByMailButton.Name = "PromotionByMailButton";
            this.PromotionByMailButton.Size = new System.Drawing.Size(237, 35);
            this.PromotionByMailButton.TabIndex = 16;
            this.PromotionByMailButton.Text = "PROMOTION BY MAIL";
            this.PromotionByMailButton.UseVisualStyleBackColor = false;
            this.PromotionByMailButton.Click += new System.EventHandler(this.PromotionByMailButton_Click);
            // 
            // ID_LABEL
            // 
            this.ID_LABEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ID_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ID_LABEL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ID_LABEL.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_LABEL.Location = new System.Drawing.Point(590, 248);
            this.ID_LABEL.Name = "ID_LABEL";
            this.ID_LABEL.Size = new System.Drawing.Size(237, 34);
            this.ID_LABEL.TabIndex = 18;
            this.ID_LABEL.Text = "Menu";
            this.ID_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayLabel
            // 
            this.DayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayLabel.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DayLabel.Location = new System.Drawing.Point(581, 609);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(427, 62);
            this.DayLabel.TabIndex = 20;
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockLabel
            // 
            this.ClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClockLabel.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClockLabel.Location = new System.Drawing.Point(230, 613);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(227, 58);
            this.ClockLabel.TabIndex = 19;
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InventoryManagementButton
            // 
            this.InventoryManagementButton.AccessibleName = "";
            this.InventoryManagementButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InventoryManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InventoryManagementButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryManagementButton.Location = new System.Drawing.Point(590, 412);
            this.InventoryManagementButton.Name = "InventoryManagementButton";
            this.InventoryManagementButton.Size = new System.Drawing.Size(237, 39);
            this.InventoryManagementButton.TabIndex = 21;
            this.InventoryManagementButton.Text = "INVENTORY MANAGEMENT";
            this.InventoryManagementButton.UseVisualStyleBackColor = false;
            this.InventoryManagementButton.Click += new System.EventHandler(this.InventoryManagementButton_Click);
            // 
            // Sales
            // 
            this.Sales.AccessibleName = "";
            this.Sales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sales.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Location = new System.Drawing.Point(590, 369);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(237, 35);
            this.Sales.TabIndex = 22;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = false;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // CoursesManagementButton
            // 
            this.CoursesManagementButton.AccessibleName = "";
            this.CoursesManagementButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoursesManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoursesManagementButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesManagementButton.Location = new System.Drawing.Point(590, 457);
            this.CoursesManagementButton.Name = "CoursesManagementButton";
            this.CoursesManagementButton.Size = new System.Drawing.Size(237, 35);
            this.CoursesManagementButton.TabIndex = 23;
            this.CoursesManagementButton.Text = "Courses Management";
            this.CoursesManagementButton.UseVisualStyleBackColor = false;
            this.CoursesManagementButton.Click += new System.EventHandler(this.CoursesManagementButton_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1209, 676);
            this.Controls.Add(this.CoursesManagementButton);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.InventoryManagementButton);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.ID_LABEL);
            this.Controls.Add(this.OrderFromSupplierButton);
            this.Controls.Add(this.PromotionByMailButton);
            this.Controls.Add(this.ExitButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton1;
        private System.Windows.Forms.Button OrderFromSupplierButton;
        private System.Windows.Forms.Button PromotionByMailButton;
        private System.Windows.Forms.Label ID_LABEL;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button InventoryManagementButton;
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button CoursesManagementButton;
    }
}