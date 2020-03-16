
using System.Windows.Forms;


namespace ShorashimSystem
{
    partial class InventoryReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReview));
            this.BacklButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.yellowLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.orderBt = new System.Windows.Forms.Button();
            this.InventoryStateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BacklButton
            // 
            this.BacklButton.BackColor = System.Drawing.Color.Pink;
            this.BacklButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BacklButton.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklButton.Location = new System.Drawing.Point(860, 516);
            this.BacklButton.Name = "BacklButton";
            this.BacklButton.Size = new System.Drawing.Size(130, 47);
            this.BacklButton.TabIndex = 46;
            this.BacklButton.Text = "Back";
            this.BacklButton.UseVisualStyleBackColor = false;
            this.BacklButton.Click += new System.EventHandler(this.BacklButton_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(46, 119);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 192);
            this.button10.TabIndex = 42;
            this.button10.Text = "J";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(46, 371);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 192);
            this.button9.TabIndex = 41;
            this.button9.Text = "I";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(215, 119);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 66);
            this.button8.TabIndex = 40;
            this.button8.Text = "H";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(215, 245);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 66);
            this.button7.TabIndex = 39;
            this.button7.Text = "G";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(215, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 66);
            this.button6.TabIndex = 38;
            this.button6.Text = "F";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.BackColorChanged += new System.EventHandler(this.button6_BackColorChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(215, 497);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 66);
            this.button5.TabIndex = 37;
            this.button5.Text = "E";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(473, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 192);
            this.button4.TabIndex = 36;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(473, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 192);
            this.button3.TabIndex = 35;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(608, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 192);
            this.button2.TabIndex = 34;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(608, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 192);
            this.button1.TabIndex = 33;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.yellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yellowLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.yellowLabel.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.Location = new System.Drawing.Point(724, 121);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(254, 76);
            this.yellowLabel.TabIndex = 48;
            this.yellowLabel.Text = "Most critical products in this closet are between 25%-50% above their lower bound" +
    "";
            this.yellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orangeLabel
            // 
            this.orangeLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.orangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orangeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.orangeLabel.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orangeLabel.Location = new System.Drawing.Point(724, 214);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(254, 76);
            this.orangeLabel.TabIndex = 49;
            this.orangeLabel.Text = "Most critical products in this closet are between 0-25% above of their lower boun" +
    "d";
            this.orangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.redLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.redLabel.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Location = new System.Drawing.Point(724, 307);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(254, 76);
            this.redLabel.TabIndex = 50;
            this.redLabel.Text = "Most critical products in this closet are below their lower bound!";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderBt
            // 
            this.orderBt.BackColor = System.Drawing.Color.Pink;
            this.orderBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBt.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBt.Location = new System.Drawing.Point(818, 444);
            this.orderBt.Name = "orderBt";
            this.orderBt.Size = new System.Drawing.Size(172, 51);
            this.orderBt.TabIndex = 51;
            this.orderBt.Text = "Order products";
            this.orderBt.UseVisualStyleBackColor = false;
            this.orderBt.Click += new System.EventHandler(this.orderBt_Click);
            // 
            // InventoryStateLabel
            // 
            this.InventoryStateLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.InventoryStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryStateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InventoryStateLabel.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryStateLabel.ForeColor = System.Drawing.Color.White;
            this.InventoryStateLabel.Location = new System.Drawing.Point(303, 29);
            this.InventoryStateLabel.Name = "InventoryStateLabel";
            this.InventoryStateLabel.Size = new System.Drawing.Size(361, 55);
            this.InventoryStateLabel.TabIndex = 52;
            this.InventoryStateLabel.Text = "Inventory State";
            this.InventoryStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InventoryStateLabel.Click += new System.EventHandler(this.InventoryStateLabel_Click);
            // 
            // InventoryReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 574);
            this.Controls.Add(this.InventoryStateLabel);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.BacklButton);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "InventoryReview";
            this.Text = "InventoryReview";
            this.Load += new System.EventHandler(this.InventoryReview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BacklButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Collections.Generic.List<Button> buttons;
        private Timer timer1;
        private int counter = 0;
        private ToolTip toolTip1;
        private System.Collections.Generic.Dictionary<Product,int> productsWithState;
        private Label yellowLabel;
        private Label orangeLabel;
        private Label redLabel;
        private Button orderBt;
        private Label InventoryStateLabel;
    }
}