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
    public partial class ORDRERS_MAIN : Form
    {
        int EMP_ID;
        public ORDRERS_MAIN(int EMP_ID)
        {
            this.EMP_ID = EMP_ID;
            InitializeComponent();
        }

        private void BacklButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu New_MM = new Main_Menu(EMP_ID);
            New_MM.Enabled = true;
            New_MM.Show();
        }

        private void SalesHistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void ExistOrderButton_Click(object sender, EventArgs e)
        {
            openOrdersHistory();
        }

        private void PhotoNewOrder_Click(object sender, EventArgs e)
        {
            openNewOrderPage();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            openNewOrderPage();
        }

        private void ExistOrderPhoto_Click(object sender, EventArgs e)
        {
            openOrdersHistory();
        }

        private void ORDRERS_MAIN_Load(object sender, EventArgs e)
        {

        }


        private void openNewOrderPage()
        {

            OrderProducts New_OP = new OrderProducts(EMP_ID);
            New_OP.Enabled = true;//maybe not needed
            New_OP.ShowDialog();
            this.Hide();
        }



        private void openOrdersHistory()
        {
            RemoveOrder New_UO = new RemoveOrder(EMP_ID);
            New_UO.Enabled = true;//maybe not needed
            New_UO.ShowDialog();
            this.Hide();
        }


        private void openDefective()
        {
            DefectedProducts New_DP = new DefectedProducts(EMP_ID);
            New_DP.Enabled = true;//maybe not needed
            New_DP.ShowDialog();
            this.Hide();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openDefective();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openDefective();
        }
    }
}
