namespace ShorashimSystem
{
    partial class Sales_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Page));
            this.NewSaleButton = new System.Windows.Forms.Button();
            this.SalesHistoryButton = new System.Windows.Forms.Button();
            this.photoHistorySales = new System.Windows.Forms.PictureBox();
            this.PhotoNewSale = new System.Windows.Forms.PictureBox();
            this.BacklButton = new System.Windows.Forms.Button();
            this.ID_LABEL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoHistorySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoNewSale)).BeginInit();
            this.SuspendLayout();
            // 
            // NewSaleButton
            // 
            this.NewSaleButton.AccessibleName = "";
            this.NewSaleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewSaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewSaleButton.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSaleButton.Location = new System.Drawing.Point(86, 465);
            this.NewSaleButton.Name = "NewSaleButton";
            this.NewSaleButton.Size = new System.Drawing.Size(414, 58);
            this.NewSaleButton.TabIndex = 17;
            this.NewSaleButton.Text = "New Sale";
            this.NewSaleButton.UseVisualStyleBackColor = false;
            this.NewSaleButton.Click += new System.EventHandler(this.NewSale_Click);
            // 
            // SalesHistoryButton
            // 
            this.SalesHistoryButton.AccessibleName = "";
            this.SalesHistoryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalesHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesHistoryButton.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesHistoryButton.Location = new System.Drawing.Point(648, 465);
            this.SalesHistoryButton.Name = "SalesHistoryButton";
            this.SalesHistoryButton.Size = new System.Drawing.Size(414, 58);
            this.SalesHistoryButton.TabIndex = 18;
            this.SalesHistoryButton.Text = "SalesHistory";
            this.SalesHistoryButton.UseVisualStyleBackColor = false;
            this.SalesHistoryButton.Click += new System.EventHandler(this.SalesHistory_Click);
            // 
            // photoHistorySales
            // 
            this.photoHistorySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.photoHistorySales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoHistorySales.Cursor = System.Windows.Forms.Cursors.Default;
            this.photoHistorySales.Image = ((System.Drawing.Image)(resources.GetObject("photoHistorySales.Image")));
            this.photoHistorySales.Location = new System.Drawing.Point(648, 133);
            this.photoHistorySales.Name = "photoHistorySales";
            this.photoHistorySales.Size = new System.Drawing.Size(414, 333);
            this.photoHistorySales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoHistorySales.TabIndex = 19;
            this.photoHistorySales.TabStop = false;
            this.photoHistorySales.Click += new System.EventHandler(this.photoHistorySales_Click);
            // 
            // PhotoNewSale
            // 
            this.PhotoNewSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PhotoNewSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PhotoNewSale.Cursor = System.Windows.Forms.Cursors.Default;
            this.PhotoNewSale.Image = ((System.Drawing.Image)(resources.GetObject("PhotoNewSale.Image")));
            this.PhotoNewSale.Location = new System.Drawing.Point(86, 133);
            this.PhotoNewSale.Name = "PhotoNewSale";
            this.PhotoNewSale.Size = new System.Drawing.Size(414, 333);
            this.PhotoNewSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoNewSale.TabIndex = 20;
            this.PhotoNewSale.TabStop = false;
            this.PhotoNewSale.Click += new System.EventHandler(this.PhotoNewSale_Click);
            // 
            // BacklButton
            // 
            this.BacklButton.BackColor = System.Drawing.Color.Pink;
            this.BacklButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BacklButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklButton.Location = new System.Drawing.Point(511, 573);
            this.BacklButton.Name = "BacklButton";
            this.BacklButton.Size = new System.Drawing.Size(140, 49);
            this.BacklButton.TabIndex = 31;
            this.BacklButton.Text = "Back";
            this.BacklButton.UseVisualStyleBackColor = false;
            this.BacklButton.Click += new System.EventHandler(this.BacklButton_Click);
            // 
            // ID_LABEL
            // 
            this.ID_LABEL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ID_LABEL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ID_LABEL.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_LABEL.ForeColor = System.Drawing.Color.White;
            this.ID_LABEL.Location = new System.Drawing.Point(-51, 29);
            this.ID_LABEL.Name = "ID_LABEL";
            this.ID_LABEL.Size = new System.Drawing.Size(1266, 55);
            this.ID_LABEL.TabIndex = 32;
            this.ID_LABEL.Text = "Sales Area";
            this.ID_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ID_LABEL.Click += new System.EventHandler(this.ID_LABEL_Click);
            // 
            // Sales_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1152, 667);
            this.Controls.Add(this.ID_LABEL);
            this.Controls.Add(this.BacklButton);
            this.Controls.Add(this.PhotoNewSale);
            this.Controls.Add(this.photoHistorySales);
            this.Controls.Add(this.SalesHistoryButton);
            this.Controls.Add(this.NewSaleButton);
            this.Name = "Sales_Page";
            this.Text = "Sales_Page";
            this.Load += new System.EventHandler(this.Sales_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoHistorySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoNewSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewSaleButton;
        private System.Windows.Forms.Button SalesHistoryButton;
        private System.Windows.Forms.PictureBox photoHistorySales;
        private System.Windows.Forms.PictureBox PhotoNewSale;
        private System.Windows.Forms.Button BacklButton;
        private System.Windows.Forms.Label ID_LABEL;
    }
}