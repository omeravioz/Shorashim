namespace ShorashimSystem
{
    partial class CoursesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesManagement));
            this.AddNewCoursebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Main_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewCoursebutton
            // 
            this.AddNewCoursebutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewCoursebutton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCoursebutton.Location = new System.Drawing.Point(25, 285);
            this.AddNewCoursebutton.Name = "AddNewCoursebutton";
            this.AddNewCoursebutton.Size = new System.Drawing.Size(300, 46);
            this.AddNewCoursebutton.TabIndex = 1;
            this.AddNewCoursebutton.Text = "Add new course";
            this.AddNewCoursebutton.UseVisualStyleBackColor = false;
            this.AddNewCoursebutton.Click += new System.EventHandler(this.AddNewCoursebutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Participants";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Pink;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(293, 340);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 40);
            this.CancelButton.TabIndex = 133;
            this.CancelButton.Text = "Back";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Main_Label
            // 
            this.Main_Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Main_Label.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Label.ForeColor = System.Drawing.Color.White;
            this.Main_Label.Location = new System.Drawing.Point(140, 12);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(417, 55);
            this.Main_Label.TabIndex = 134;
            this.Main_Label.Text = "Courses Management";
            this.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoursesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 392);
            this.Controls.Add(this.Main_Label);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddNewCoursebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CoursesManagement";
            this.Text = "CoursesManagement";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddNewCoursebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Main_Label;
    }
}