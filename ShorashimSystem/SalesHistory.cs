using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ShorashimSystem
{
    public partial class ED : Form
    {
        int EMP_ID;
        public ED(int EMP_ID)
        {
            InitializeComponent();
            this.EMP_ID = EMP_ID;
            



        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EndDate_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Show_Click(object sender, EventArgs e)
        {
            MoreDetails.Visible = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            
            DateTime dateS = Convert.ToDateTime(StartDate.Value, CultureInfo.InvariantCulture);
            DateTime dateE = Convert.ToDateTime(EndDate.Value, CultureInfo.InvariantCulture);
            if(dateS>dateE)
                MessageBox.Show(" Start Date is later then End Date. please enter the dates again.", "Invaild Input", MessageBoxButtons.OK);
            foreach (Purchase P in Program.purchases)
            {
                if (P.getDateOfPurchase() > dateS && P.getDateOfPurchase() < dateE)
                {
                    dataGridView1.Rows.Add(P.getID(),P.getPrice(),P.get_purchcaseEmployeeID(),P.get_purchcaseCustomerID(),P.getPaymentMethod(),P.getDateOfPurchase());
                }


            }

        }

        private void ED_Load(object sender, EventArgs e)
        {
            {



            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BacklButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Page New_SP = new Sales_Page(EMP_ID);
            New_SP.Enabled = true;
            New_SP.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MoreDetails_Click(object sender, EventArgs e)
        {

            dataGridView2.Visible = true;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                
                Purchase P = Program.seekPurchase(Convert.ToInt32(dataGridView1.Rows[selectedrowindex].Cells[0].Value));

                foreach (ProductInPurchases PIP in P.Products_In_Purchase)
                {
                    dataGridView2.Rows.Add(PIP.get_ProductID(),PIP.get_Product().get_productName(), PIP.get_Quantity(), PIP.get_Quantity() * PIP.get_Product().getSalePrice());
                }
            }


            
        }
    }
}