namespace ShorashimSystem
{
    partial class Generate_Code_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate_Code_Tool));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PromoGeneratorLabel = new System.Windows.Forms.Label();
            this.DescrriptionBox = new System.Windows.Forms.TextBox();
            this.GenerateCode_Button = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PERCENTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 336);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 3, 3, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 6, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 35);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2019, 6, 15, 17, 10, 24, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PromoGeneratorLabel
            // 
            this.PromoGeneratorLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PromoGeneratorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PromoGeneratorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PromoGeneratorLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoGeneratorLabel.Location = new System.Drawing.Point(219, 56);
            this.PromoGeneratorLabel.Name = "PromoGeneratorLabel";
            this.PromoGeneratorLabel.Size = new System.Drawing.Size(199, 63);
            this.PromoGeneratorLabel.TabIndex = 17;
            this.PromoGeneratorLabel.Text = "Promo Code Generator";
            this.PromoGeneratorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PromoGeneratorLabel.Click += new System.EventHandler(this.PromoGeneratorLabel_Click);
            // 
            // DescrriptionBox
            // 
            this.DescrriptionBox.BackColor = System.Drawing.SystemColors.Menu;
            this.DescrriptionBox.Cursor = System.Windows.Forms.Cursors.No;
            this.DescrriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DescrriptionBox.Location = new System.Drawing.Point(262, 146);
            this.DescrriptionBox.Multiline = true;
            this.DescrriptionBox.Name = "DescrriptionBox";
            this.DescrriptionBox.Size = new System.Drawing.Size(146, 32);
            this.DescrriptionBox.TabIndex = 25;
            this.DescrriptionBox.TextChanged += new System.EventHandler(this.DescrriptionBox_TextChanged);
            // 
            // GenerateCode_Button
            // 
            this.GenerateCode_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GenerateCode_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateCode_Button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateCode_Button.Location = new System.Drawing.Point(424, 143);
            this.GenerateCode_Button.Name = "GenerateCode_Button";
            this.GenerateCode_Button.Size = new System.Drawing.Size(106, 41);
            this.GenerateCode_Button.TabIndex = 26;
            this.GenerateCode_Button.Text = "Generate!";
            this.GenerateCode_Button.UseVisualStyleBackColor = false;
            this.GenerateCode_Button.Click += new System.EventHandler(this.GenerateCode_Button_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(176, 423);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(106, 49);
            this.CreateButton.TabIndex = 27;
            this.CreateButton.Text = "Create!";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Pink;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(342, 423);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(106, 49);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Cancel!";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PERCENTBOX
            // 
            this.PERCENTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PERCENTBOX.Location = new System.Drawing.Point(262, 198);
            this.PERCENTBOX.MaxLength = 2;
            this.PERCENTBOX.Multiline = true;
            this.PERCENTBOX.Name = "PERCENTBOX";
            this.PERCENTBOX.Size = new System.Drawing.Size(75, 33);
            this.PERCENTBOX.TabIndex = 29;
            this.PERCENTBOX.TextChanged += new System.EventHandler(this.PERCENTBOX_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "End Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 32;
            this.label3.Text = "Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Discount:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Description.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Description.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(127, 261);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(120, 41);
            this.Description.TabIndex = 34;
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(262, 240);
            this.textBox1.MaxLength = 1000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 83);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Generate_Code_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(629, 540);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PERCENTBOX);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.GenerateCode_Button);
            this.Controls.Add(this.DescrriptionBox);
            this.Controls.Add(this.PromoGeneratorLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Generate_Code_Tool";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Generate_Code_Tool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label PromoGeneratorLabel;
        private System.Windows.Forms.TextBox DescrriptionBox;
        private System.Windows.Forms.Button GenerateCode_Button;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PERCENTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox textBox1;
    }
}