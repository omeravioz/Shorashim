namespace ShorashimSystem
{
    partial class PromotionByMailing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromotionByMailing));
            this.SendPromotionCodeMail = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ID_LABEL = new System.Windows.Forms.Label();
            this.TargetedGroupLabel = new System.Windows.Forms.Label();
            this.IDtextbook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PromotionComboBoxChoose = new System.Windows.Forms.Label();
            this.PromoCodeChooseBox = new System.Windows.Forms.ComboBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescrriptionBox = new System.Windows.Forms.TextBox();
            this.GenerateCode_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendPromotionCodeMail
            // 
            this.SendPromotionCodeMail.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SendPromotionCodeMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendPromotionCodeMail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendPromotionCodeMail.Location = new System.Drawing.Point(285, 568);
            this.SendPromotionCodeMail.Name = "SendPromotionCodeMail";
            this.SendPromotionCodeMail.Size = new System.Drawing.Size(140, 49);
            this.SendPromotionCodeMail.TabIndex = 13;
            this.SendPromotionCodeMail.Text = "Send!";
            this.SendPromotionCodeMail.UseVisualStyleBackColor = false;
            this.SendPromotionCodeMail.Click += new System.EventHandler(this.SendPromotionCodeMail_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Pink;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(449, 568);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 49);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel!";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "January Birthdays",
            "February Birthdays",
            "March Birthdays",
            "April Birthdays",
            "May Birthdays",
            "June Birthdays",
            "July Birthdays",
            "August Birthdays",
            "September Birthdays",
            "October Birthdays",
            "November Birthdays",
            "December Birthdays",
            "Gold Club",
            "Silver Club",
            "Black Club",
            "ALL Customers"});
            this.comboBox1.Location = new System.Drawing.Point(615, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 32);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ID_LABEL
            // 
            this.ID_LABEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ID_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ID_LABEL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ID_LABEL.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_LABEL.Location = new System.Drawing.Point(643, 9);
            this.ID_LABEL.Name = "ID_LABEL";
            this.ID_LABEL.Size = new System.Drawing.Size(199, 33);
            this.ID_LABEL.TabIndex = 16;
            this.ID_LABEL.Text = "Customer ID";
            this.ID_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetedGroupLabel
            // 
            this.TargetedGroupLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TargetedGroupLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TargetedGroupLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TargetedGroupLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetedGroupLabel.Location = new System.Drawing.Point(643, 124);
            this.TargetedGroupLabel.Name = "TargetedGroupLabel";
            this.TargetedGroupLabel.Size = new System.Drawing.Size(199, 33);
            this.TargetedGroupLabel.TabIndex = 17;
            this.TargetedGroupLabel.Text = "Targeted Group";
            this.TargetedGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDtextbook
            // 
            this.IDtextbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IDtextbook.Location = new System.Drawing.Point(615, 45);
            this.IDtextbook.Name = "IDtextbook";
            this.IDtextbook.Size = new System.Drawing.Size(250, 29);
            this.IDtextbook.TabIndex = 18;
            this.IDtextbook.TextChanged += new System.EventHandler(this.IDtextbook_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(710, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "OR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PromotionComboBoxChoose
            // 
            this.PromotionComboBoxChoose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PromotionComboBoxChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PromotionComboBoxChoose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PromotionComboBoxChoose.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromotionComboBoxChoose.Location = new System.Drawing.Point(285, 327);
            this.PromotionComboBoxChoose.Name = "PromotionComboBoxChoose";
            this.PromotionComboBoxChoose.Size = new System.Drawing.Size(199, 33);
            this.PromotionComboBoxChoose.TabIndex = 20;
            this.PromotionComboBoxChoose.Text = "Promotion Code";
            this.PromotionComboBoxChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PromoCodeChooseBox
            // 
            this.PromoCodeChooseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PromoCodeChooseBox.FormattingEnabled = true;
            this.PromoCodeChooseBox.Location = new System.Drawing.Point(285, 376);
            this.PromoCodeChooseBox.Name = "PromoCodeChooseBox";
            this.PromoCodeChooseBox.Size = new System.Drawing.Size(199, 32);
            this.PromoCodeChooseBox.TabIndex = 22;
            this.PromoCodeChooseBox.SelectedIndexChanged += new System.EventHandler(this.PromoCodeChooseBox_SelectedIndexChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DescriptionLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(285, 423);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(199, 33);
            this.DescriptionLabel.TabIndex = 23;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DescriptionLabel.Click += new System.EventHandler(this.DescriptionLabel_Click);
            // 
            // DescrriptionBox
            // 
            this.DescrriptionBox.BackColor = System.Drawing.SystemColors.Menu;
            this.DescrriptionBox.Cursor = System.Windows.Forms.Cursors.No;
            this.DescrriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DescrriptionBox.Location = new System.Drawing.Point(285, 459);
            this.DescrriptionBox.Multiline = true;
            this.DescrriptionBox.Name = "DescrriptionBox";
            this.DescrriptionBox.Size = new System.Drawing.Size(290, 103);
            this.DescrriptionBox.TabIndex = 24;
            this.DescrriptionBox.TextChanged += new System.EventHandler(this.DescrriptionBox_TextChanged);
            // 
            // GenerateCode_Button
            // 
            this.GenerateCode_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GenerateCode_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateCode_Button.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateCode_Button.Location = new System.Drawing.Point(816, 525);
            this.GenerateCode_Button.Name = "GenerateCode_Button";
            this.GenerateCode_Button.Size = new System.Drawing.Size(99, 51);
            this.GenerateCode_Button.TabIndex = 25;
            this.GenerateCode_Button.Text = "Generate a new code";
            this.GenerateCode_Button.UseVisualStyleBackColor = false;
            this.GenerateCode_Button.Click += new System.EventHandler(this.GenerateCode_Button_Click);
            // 
            // PromotionByMailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1206, 680);
            this.Controls.Add(this.GenerateCode_Button);
            this.Controls.Add(this.DescrriptionBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PromoCodeChooseBox);
            this.Controls.Add(this.PromotionComboBoxChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtextbook);
            this.Controls.Add(this.TargetedGroupLabel);
            this.Controls.Add(this.ID_LABEL);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SendPromotionCodeMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PromotionByMailing";
            this.Text = "Promotion Codes";
            this.Load += new System.EventHandler(this.PromotionByMailing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendPromotionCodeMail;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ID_LABEL;
        private System.Windows.Forms.Label TargetedGroupLabel;
        private System.Windows.Forms.TextBox IDtextbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PromotionComboBoxChoose;
        private System.Windows.Forms.ComboBox PromoCodeChooseBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescrriptionBox;
        private System.Windows.Forms.Button GenerateCode_Button;
    }
}