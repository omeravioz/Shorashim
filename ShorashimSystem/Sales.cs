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
    public partial class Sales_Page : Form
    {
        int EMP_ID;
        public Sales_Page(int EMP_ID)
        {
            this.EMP_ID = EMP_ID;
            InitializeComponent();
        }

        private void SalesHistory_Click(object sender, EventArgs e)
        {
            openSalesHistory();
        }

        private void NewSale_Click(object sender, EventArgs e)
        {
            openNewSalePage();
        }

        private void Sales_Page_Load(object sender, EventArgs e)
        {

        }

        private void photoHistorySales_Click(object sender, EventArgs e)
        {
            openSalesHistory();
        }

        private void PhotoNewSale_Click(object sender, EventArgs e)
        {
            openNewSalePage();
        }

        private void BacklButton_Click(object sender, EventArgs e)
        {

            this.Close();
            Main_Menu New_MM = new Main_Menu(EMP_ID);
            New_MM.Enabled = true;
            New_MM.Show();


        }


        private void openSalesHistory()
        {

            ED New_SH = new ED(EMP_ID);
            New_SH.Enabled = true;//maybe not needed
            New_SH.ShowDialog();
            this.Hide();
        }



        private void openNewSalePage()
        {
            CancleSale New_SALE = new CancleSale(EMP_ID);
            New_SALE.Enabled = true;//maybe not needed
            New_SALE.ShowDialog();
            this.Hide();
        }

        private void ID_LABEL_Click(object sender, EventArgs e)
        {

        }
    }



    
}
