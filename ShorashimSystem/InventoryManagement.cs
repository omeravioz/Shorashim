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
    public partial class InventoryManagement : Form
    {

        int ID = 0;  // ##### need to get the real id

        public InventoryManagement(int EM_ID)
        {

            this.ID = EM_ID;

            InitializeComponent();


            // initializing controls colors
            this.header.BackColor = Color.MediumTurquoise;
            this.MoveToInventoryReviewButton.BackColor = Color.MintCream;
            this.SearchProductBt.BackColor = Color.MintCream;

            
            this.MoveToInventoryReviewButton.FlatStyle = FlatStyle.Flat;
            this.MoveToInventoryReviewButton.FlatAppearance.BorderColor = Color.Black;
            this.MoveToInventoryReviewButton.FlatAppearance.BorderSize = 1;

            this.SearchProductBt.FlatStyle = FlatStyle.Flat;
            this.SearchProductBt.FlatAppearance.BorderColor = Color.Black;
            this.SearchProductBt.FlatAppearance.BorderSize = 1;

        }

        private void MoveToInventoryReviewButton_Click(object sender, EventArgs e)
        {
            Form InventoryReview = new InventoryReview(this.ID);
            InventoryReview.Enabled = true;
            InventoryReview.ShowDialog();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchProductBt_Click(object sender, EventArgs e)
        {
            Form Map = new Map(this.ID);
            Map.Enabled = true;
            Map.ShowDialog();
            this.Hide();
        }

        private void BacklButton_Click(object sender, EventArgs e)
        {
            Main_Menu mm = new Main_Menu(this.ID);
            mm.Enabled = true;
            mm.Show();
            this.Hide();
        }
    }
}
