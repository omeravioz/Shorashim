namespace ShorashimSystem
{
    partial class Login_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Screen));
            this.customersTableAdapter1 = new ShorashimSystem.SAD_31DataSetTableAdapters.CUSTOMERSTableAdapter();
            this.ID_LABEL = new System.Windows.Forms.Label();
            this.ID_TEXTBOX = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton1 = new System.Windows.Forms.Button();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ID_LABEL
            // 
            this.ID_LABEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ID_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ID_LABEL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ID_LABEL.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_LABEL.Location = new System.Drawing.Point(643, 271);
            this.ID_LABEL.Name = "ID_LABEL";
            this.ID_LABEL.Size = new System.Drawing.Size(124, 33);
            this.ID_LABEL.TabIndex = 8;
            this.ID_LABEL.Text = "ID";
            this.ID_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ID_LABEL.Click += new System.EventHandler(this.ID_LABEL_Click);
            // 
            // ID_TEXTBOX
            // 
            this.ID_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID_TEXTBOX.Location = new System.Drawing.Point(624, 316);
            this.ID_TEXTBOX.Name = "ID_TEXTBOX";
            this.ID_TEXTBOX.Size = new System.Drawing.Size(168, 29);
            this.ID_TEXTBOX.TabIndex = 9;
            this.ID_TEXTBOX.TextChanged += new System.EventHandler(this.ID_TEXTBOX_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.Location = new System.Drawing.Point(624, 420);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(168, 29);
            this.PasswordTextBox.TabIndex = 10;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(643, 368);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(124, 38);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(559, 464);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(140, 49);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "LOGIN !";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton1
            // 
            this.ExitButton1.AccessibleName = "";
            this.ExitButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton1.Location = new System.Drawing.Point(728, 464);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(140, 49);
            this.ExitButton1.TabIndex = 13;
            this.ExitButton1.Text = "EXIT ";
            this.ExitButton1.UseVisualStyleBackColor = false;
            this.ExitButton1.Click += new System.EventHandler(this.ExitButton1_Click);
            // 
            // ClockLabel
            // 
            this.ClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClockLabel.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClockLabel.Location = new System.Drawing.Point(226, 575);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(227, 58);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayLabel
            // 
            this.DayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayLabel.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DayLabel.Location = new System.Drawing.Point(577, 571);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(427, 62);
            this.DayLabel.TabIndex = 16;
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DayLabel.Click += new System.EventHandler(this.DayLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1206, 680);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.ExitButton1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.ID_TEXTBOX);
            this.Controls.Add(this.ID_LABEL);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login_Screen";
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SAD_31DataSetTableAdapters.CUSTOMERSTableAdapter customersTableAdapter1;
        private System.Windows.Forms.Label ID_LABEL;
        private System.Windows.Forms.TextBox ID_TEXTBOX;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton1;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

