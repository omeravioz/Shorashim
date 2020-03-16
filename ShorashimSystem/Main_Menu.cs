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
    public partial class Main_Menu : Form
    {
        int EMP_ID;
        public Main_Menu(int EMP_ID)
        {
            this.EMP_ID = EMP_ID;
            InitializeComponent();

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void OrderFromSupplierButton_Click(object sender, EventArgs e)
        {
            ORDRERS_MAIN O_M = new ORDRERS_MAIN(EMP_ID);
            O_M.Enabled = true;//maybe not needed
            O_M.ShowDialog();
            this.Hide();
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            DayLabel.Text = DateTime.Now.ToString("dddd" + "  dd MMMM yyyy");
        }

        private void PromotionByMailButton_Click(object sender, EventArgs e)
        {
            PromotionByMailing New_PBM = new PromotionByMailing(EMP_ID);
            New_PBM.Enabled = true;//maybe not needed
            New_PBM.ShowDialog();
            this.Hide();
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login_Screen loginScreen = new Login_Screen();
                loginScreen.Enabled = true;//maybe not needed
                loginScreen.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
           


        }

        private void InventoryManagementButton_Click(object sender, EventArgs e)
        {
            Form InventoryManagement = new InventoryManagement(EMP_ID);
            InventoryManagement.ShowDialog();
            this.Hide();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            Form Sales_Page = new Sales_Page(EMP_ID);
            Sales_Page.ShowDialog();
            this.Hide();
        }

        private void CoursesManagementButton_Click(object sender, EventArgs e)
        {
            CoursesManagement New_CBM = new CoursesManagement(EMP_ID);
            New_CBM.Enabled = true;//maybe not needed
            New_CBM.ShowDialog();
            this.Hide();
        }
    }
}



             