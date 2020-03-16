namespace ShorashimSystem
{
    partial class ORDRERS_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ORDRERS_MAIN));
            this.Main_Label = new System.Windows.Forms.Label();
            this.BacklButton = new System.Windows.Forms.Button();
            this.PhotoNewOrder = new System.Windows.Forms.PictureBox();
            this.ExistOrderPhoto = new System.Windows.Forms.PictureBox();
            this.ReturnDefectiveButton = new System.Windows.Forms.Button();
            this.ExistOrderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoNewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistOrderPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Label
            // 
            this.Main_Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Main_Label.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Label.ForeColor = System.Drawing.Color.White;
            this.Main_Label.Location = new System.Drawing.Point(-57, 37);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(1266, 55);
            this.Main_Label.TabIndex = 38;
            this.Main_Label.Text = "Orders From Supplier Area";
            this.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BacklButton
            // 
            this.BacklButton.BackColor = System.Drawing.Color.Pink;
            this.BacklButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BacklButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklButton.Location = new System.Drawing.Point(497, 526);
            this.BacklButton.Name = "BacklButton";
            this.BacklButton.Size = new System.Drawing.Size(140, 49);
            this.BacklButton.TabIndex = 37;
            this.BacklButton.Text = "Back";
            this.BacklButton.UseVisualStyleBackColor = false;
            this.BacklButton.Click += new System.EventHandler(this.BacklButton_Click);
            // 
            // PhotoNewOrder
            // 
            this.PhotoNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PhotoNewOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PhotoNewOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.PhotoNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("PhotoNewOrder.Image")));
            this.PhotoNewOrder.Location = new System.Drawing.Point(61, 178);
            this.PhotoNewOrder.Name = "PhotoNewOrder";
            this.PhotoNewOrder.Size = new System.Drawing.Size(280, 216);
            this.PhotoNewOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoNewOrder.TabIndex = 36;
            this.PhotoNewOrder.TabStop = false;
            this.PhotoNewOrder.Click += new System.EventHandler(this.PhotoNewOrder_Click);
            // 
            // ExistOrderPhoto
            // 
            this.ExistOrderPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExistOrderPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExistOrderPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExistOrderPhoto.Image = ((System.Drawing.Image)(resources.GetObject("ExistOrderPhoto.Image")));
            this.ExistOrderPhoto.Location = new System.Drawing.Point(774, 177);
            this.ExistOrderPhoto.Name = "ExistOrderPhoto";
            this.ExistOrderPhoto.Size = new System.Drawing.Size(280, 217);
            this.ExistOrderPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExistOrderPhoto.TabIndex = 35;
            this.ExistOrderPhoto.TabStop = false;
            this.ExistOrderPhoto.Click += new System.EventHandler(this.ExistOrderPhoto_Click);
            // 
            // ReturnDefectiveButton
            // 
            this.ReturnDefectiveButton.AccessibleName = "";
            this.ReturnDefectiveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReturnDefectiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnDefectiveButton.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDefectiveButton.Location = new System.Drawing.Point(61, 390);
            this.ReturnDefectiveButton.Name = "ReturnDefectiveButton";
            this.ReturnDefectiveButton.Size = new System.Drawing.Size(280, 73);
            this.ReturnDefectiveButton.TabIndex = 33;
            this.ReturnDefectiveButton.Text = "New Order";
            this.ReturnDefectiveButton.UseVisualStyleBackColor = false;
            this.ReturnDefectiveButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // ExistOrderButton
            // 
            this.ExistOrderButton.AccessibleName = "";
            this.ExistOrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExistOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExistOrderButton.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistOrderButton.Location = new System.Drawing.Point(774, 390);
            this.ExistOrderButton.Name = "ExistOrderButton";
            this.ExistOrderButton.Size = new System.Drawing.Size(280, 73);
            this.ExistOrderButton.TabIndex = 39;
            this.ExistOrderButton.Text = "Exist Order";
            this.ExistOrderButton.UseVisualStyleBackColor = false;
            this.ExistOrderButton.Click += new System.EventHandler(this.ExistOrderButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "";
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 73);
            this.button1.TabIndex = 40;
            this.button1.Text = "Return Defective Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ORDRERS_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1125, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExistOrderButton);
            this.Controls.Add(this.Main_Label);
            this.Controls.Add(this.BacklButton);
            this.Controls.Add(this.PhotoNewOrder);
            this.Controls.Add(this.ExistOrderPhoto);
            this.Controls.Add(this.ReturnDefectiveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ORDRERS_MAIN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ORDRERS_MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoNewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistOrderPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.Button BacklButton;
        private System.Windows.Forms.PictureBox PhotoNewOrder;
        private System.Windows.Forms.PictureBox ExistOrderPhoto;
        private System.Windows.Forms.Button ReturnDefectiveButton;
        private System.Windows.Forms.Button ExistOrderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}