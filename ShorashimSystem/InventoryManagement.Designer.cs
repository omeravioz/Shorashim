namespace ShorashimSystem
{
    partial class InventoryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagement));
            this.MoveToInventoryReviewButton = new System.Windows.Forms.Button();
            this.SearchProductBt = new System.Windows.Forms.Button();
            this.BacklButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoveToInventoryReviewButton
            // 
            this.MoveToInventoryReviewButton.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToInventoryReviewButton.Location = new System.Drawing.Point(225, 156);
            this.MoveToInventoryReviewButton.Name = "MoveToInventoryReviewButton";
            this.MoveToInventoryReviewButton.Size = new System.Drawing.Size(235, 47);
            this.MoveToInventoryReviewButton.TabIndex = 0;
            this.MoveToInventoryReviewButton.Text = "Inventory review";
            this.MoveToInventoryReviewButton.UseVisualStyleBackColor = true;
            this.MoveToInventoryReviewButton.Click += new System.EventHandler(this.MoveToInventoryReviewButton_Click);
            // 
            // SearchProductBt
            // 
            this.SearchProductBt.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductBt.Location = new System.Drawing.Point(225, 246);
            this.SearchProductBt.Name = "SearchProductBt";
            this.SearchProductBt.Size = new System.Drawing.Size(235, 47);
            this.SearchProductBt.TabIndex = 2;
            this.SearchProductBt.Text = "Search a product";
            this.SearchProductBt.UseVisualStyleBackColor = true;
            this.SearchProductBt.Click += new System.EventHandler(this.SearchProductBt_Click);
            // 
            // BacklButton
            // 
            this.BacklButton.BackColor = System.Drawing.Color.Pink;
            this.BacklButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BacklButton.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklButton.Location = new System.Drawing.Point(549, 394);
            this.BacklButton.Name = "BacklButton";
            this.BacklButton.Size = new System.Drawing.Size(140, 49);
            this.BacklButton.TabIndex = 31;
            this.BacklButton.Text = "Back";
            this.BacklButton.UseVisualStyleBackColor = false;
            this.BacklButton.Click += new System.EventHandler(this.BacklButton_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ControlDark;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.header.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(117, 73);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(456, 42);
            this.header.TabIndex = 48;
            this.header.Text = "Inventory Management";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 455);
            this.Controls.Add(this.header);
            this.Controls.Add(this.BacklButton);
            this.Controls.Add(this.SearchProductBt);
            this.Controls.Add(this.MoveToInventoryReviewButton);
            this.Name = "InventoryManagement";
            this.Text = "InventoryManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoveToInventoryReviewButton;
        private System.Windows.Forms.Button SearchProductBt;
        private System.Windows.Forms.Button BacklButton;
        private System.Windows.Forms.Label header;
    }
}