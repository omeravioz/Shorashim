using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShorashimSystem
{
    public partial class Closet : Form
    {
        public Closet(int shelf)
        {
            InitializeComponent();
            this.label1.ForeColor = Color.Red;
            this.label2.ForeColor = Color.Red;
            this.label3.ForeColor = Color.Red;
            this.label4.ForeColor = Color.Red;
            this.label5.ForeColor = Color.Red;
            this.label6.ForeColor = Color.Red;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;


            this.labels = new List<Label>();

            this.labels.Add(this.label1);
            this.labels.Add(this.label2);
            this.labels.Add(this.label3);
            this.labels.Add(this.label4);
            this.labels.Add(this.label5);
            this.labels.Add(this.label6);

            labels[shelf - 1].Visible = true;
            labels[shelf - 1].BackColor = Color.Transparent;

        }
    }
}
