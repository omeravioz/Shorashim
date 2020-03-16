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
    public partial class RemoveOrder : Form
    {
        int EMP_ID;
        OrderFromSupplier ol;
        Product pr;
        int quantity2;
        public RemoveOrder(int EMP_ID)
        {
            this.EMP_ID = EMP_ID;
            InitializeComponent();
            ShowActiveOrders();
        
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowActiveOrders()
        {
            foreach (OrderFromSupplier OFS in Program.ordersFromSuppliers)
            {
                if(Convert.ToString(OFS.getOrderStatus()).Equals("UnderTreatment"))
                     dataGridView1.Rows.Add(OFS.getID(),OFS.getOrderSupplier().get_supplierName(),OFS.getDateOfOrder(),OFS.getTotalPrice());
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            if (dataGridView1.SelectedCells.Count > 0) { 
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                Console.WriteLine("row" + selectedrowindex);
                OrderFromSupplier OFS =Program.seekOrder_From_Supplier(Convert.ToInt32(dataGridView1.Rows[selectedrowindex].Cells[0].Value));
                this.ol = OFS;

                foreach (ProductInOrder PIO in OFS.ProductsInThisOrder)
                {
                    dataGridView2.Rows.Add(PIO.get_ProductInOrder().get_productID(),PIO.get_ProductInOrder().get_productName(), PIO.getQuantity(),(  PIO.get_ProductInOrder().getSupplierPrice()* PIO.get_ProductInOrder().get_productQuantity() ) );
                }
            }
            



                dataGridView2.Visible = true;
                button3.Visible = true;
                Quantitybutton.Visible = true;
                NewQuantity.Visible = true;


        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to deltee this product from the order?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {       
                    int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                    pr = Program.seekProduct(Convert.ToString(dataGridView2.Rows[selectedrowindex].Cells[0].Value));
                    foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                    {
                        dataGridView2.Rows.RemoveAt(selectedrowindex);
                    }

                    Program.deleteProductInOrder(ol, pr);
                }
            }
        }

        private void Quantitybutton_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(NewQuantity.Text, out value) == false || string.IsNullOrWhiteSpace(NewQuantity.Text) || Int32.Parse(NewQuantity.Text) <= 0 )
                MessageBox.Show(" Please enter Valid Quantity", "Invaild Input", MessageBoxButtons.OK);
            else if (dataGridView2.SelectedCells[0].ColumnIndex==2)
            {
               
                int col = 2; int row= dataGridView2.SelectedCells[0].RowIndex; 
                pr = Program.seekProduct(Convert.ToString(dataGridView2.Rows[row].Cells[col - 2].Value));
                quantity2 = Convert.ToInt32(NewQuantity.Text);
                dataGridView2.Rows[row].Cells[col].Value = NewQuantity.Text;
                dataGridView2.Rows[row].Cells[col + 1].Value = pr.getSupplierPrice() * quantity2;

                Program.quantityUpdateOfProductInOrder(ol, pr, quantity2);
            }
            else{
                MessageBox.Show(" Please type on the right cell", "Invaild Input", MessageBoxButtons.OK);
            }
        }

        private void NewQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ORDRERS_MAIN New_om = new ORDRERS_MAIN(EMP_ID);
            New_om.Enabled = true;
            New_om.Show();
        }
    }
}

