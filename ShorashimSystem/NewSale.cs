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
    public partial class CancleSale : Form
    {
        int EMP_ID;
        double Total_Price;
        public CancleSale(int EMP_ID)
        {
            InitializeComponent();          
            PurchaseID.ReadOnly = true;
            PurchaseID.Enabled = false;
            EmployeeID.ReadOnly = true;
            EmployeeID.Enabled = false;
            TotalPrice.ReadOnly = true;
            TotalPrice.Enabled = false;
            this.EMP_ID = EMP_ID;   
            PurchaseID.Text = Convert.ToString(Get_Purchase_ID());
            EmployeeID.Text = Convert.ToString(EMP_ID);
            Category.DataSource = Enum.GetValues(typeof(ProductCategory));
            PMInput.DataSource = Enum.GetValues(typeof(PaymentMethod));
            Fill_combo_box();
            PromotionCode.SelectedIndex = -1;
           




        }

       

        private void PurchaseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductName.DataSource = GetProducts();
        }

        private void ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private int Get_Purchase_ID()
        {
            int Purchase_ID=0;
            foreach (Purchase S in Program.purchases)
            {
                if (S.getID() > Purchase_ID)
                    Purchase_ID = S.getID();
                   
                }
            return Purchase_ID + 1;
            }

        private List<string> GetProducts()
        {
            ProductCategory C = (ProductCategory)Category.SelectedValue;
            List<string> Product = new List<string>();

            foreach (Product P in Program.products)
            {

                if (C.Equals(P.get_productCategory()))

                    Product.Add(P.get_productName());

            }
            return Product;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            int value;
            if (ProductName.Text == "")
                MessageBox.Show(" Please Choose a Product", "Invaild Input", MessageBoxButtons.OK);

            else if (int.TryParse(Quantity.Text, out value) == false || string.IsNullOrWhiteSpace(Quantity.Text) || Int32.Parse(Quantity.Text) <= 0 || (Get_Pro_QU() - Int32.Parse(Quantity.Text)) < 0)
                MessageBox.Show(" Please enter Valid Quantity", "Invaild Input", MessageBoxButtons.OK);
            else
            {

                string data = string.Empty;
                bool isExist = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)    ///check if already exists - only 1 from each product
                {

                    data = Convert.ToString(row.Cells[1].Value);
                    if (Equals(ProductName.SelectedValue, data) == true)
                    {
                        isExist = true;
                    }

                }


                if (isExist == false)
                {
                    dataGridView1.Rows.Add(Category.Text, ProductName.Text, Quantity.Text, Product_Price() * (Int32.Parse(Quantity.Text)));
                    Total_Price = Total_Price + (Product_Price() * (Int32.Parse(Quantity.Text)));
                    TotalPrice.Text = Convert.ToString(Total_Price);
                    Quantity.Clear();
                    ProductName.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(" You already ordered this product!", "Invaild Input", MessageBoxButtons.OK);
                }




             





            }
        }

        public void Fill_combo_box()
        {

            List<string> names = new List<string>();

            foreach (PromoCodes P in Program.promoCodes)
            {
                names.Add(P.getPromoName());
            }

            PromotionCode.DataSource = names;
        }

        private void PromotionCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private double Product_Price()
        {

            foreach (Product P in Program.products)
            {
                if (ProductName.Text.Equals(P.get_productName()))
                    return P.getSalePrice();
            }
            return 0.0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DeleteOrder_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;


                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    Total_Price = Total_Price - Convert.ToDouble(dataGridView1.Rows[item.Index].Cells[3].Value);
                    dataGridView1.Rows.RemoveAt(item.Index);


                    TotalPrice.Text = Convert.ToString(Total_Price);
                }
            }




        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Page New_SP = new Sales_Page(EMP_ID);
            New_SP.Enabled = true;
            New_SP.Show();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if(TotalPrice.Text == "" || Int32.Parse(TotalPrice.Text)==0 )
                MessageBox.Show(" You must enter at least one pruduct to complete the sale ", "Invaild Input", MessageBoxButtons.OK);
            else if (CustomerID.Text == "" || CheckCustomerID()==false)
                MessageBox.Show("Please enter valid Customer ID ", "Invaild Input", MessageBoxButtons.OK);

            else
            {
                
               
                DialogResult dialogResult = MessageBox.Show("Do you want to finish the purchase?", "Finish the Purchase", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CalculateFinalPrice();
                    MessageBox.Show(" Thank you, the total amount is : " + Total_Price, "Invaild Input", MessageBoxButtons.OK);

                    DateTime date = Convert.ToDateTime(DateTime.Now, CultureInfo.InvariantCulture);

                    Purchase pfc = new Purchase(Convert.ToInt32(PurchaseID.Text, CultureInfo.InvariantCulture), Convert.ToDouble(Total_Price, CultureInfo.InvariantCulture), Program.seekEmployee(EMP_ID), Program.seekCustomer(Convert.ToInt32(CustomerID.Text, CultureInfo.InvariantCulture)), date,
                          (PaymentMethod)Enum.Parse(typeof(PaymentMethod), PMInput.Text), Program.seekPromoCode(PromotionCode.Text), true);


                    string data2 = string.Empty;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        data2 = Convert.ToString(row.Cells[1].Value);
                        int quantity1 = Convert.ToInt32(row.Cells[2].Value);


                        Product pnew = Program.seekProductByName(data2);

                        if (pnew != null)
                        {

                            ProductInPurchases NewPIP = new ProductInPurchases(pfc, pnew, quantity1, true);
                            pnew.setProductQuantity(pnew.get_productQuantity() - quantity1); // change to new quantity attribute
                            pnew.update_product();  // update sql
                            messageBoxForInventoryAlert();

                        }

                       
                        


                    }


                }
                else if (dialogResult == DialogResult.No)
                {

                }

                foreach (Purchase p in Program.purchases)  //check of hahalot - products of every Purchase
                {
                    p.PrintAll();
                }

                foreach (Product p in Program.products)    //check of hahalot - Purchase of everyProduct
                {

                    Console.WriteLine("printing ProductIn lists of products");
                    p.printAllProductsInPurchases();

                }

            }
        




        }

        private Boolean CheckCustomerID()
        {
            foreach (Customer C in Program.customers)
            {
                if (Int32.Parse(CustomerID.Text) == (C.get_customerID()))
                    return true;
            }
            return false;
        }

        private void CalculateFinalPrice()
        {

            if (PromotionCode.Text != "")
               
            {
                foreach (PromoCodes C in Program.promoCodes)
                {
                    if (C.getPromoName().Equals(PromotionCode.Text))
                        Total_Price = Total_Price * ((100 - C.getPromoDiscount())/100);


                }
            }
        }

  

        private void CancleSale_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
           
         
            NewCustomerPage O_M = new NewCustomerPage();
            O_M.ShowDialog();
        }

        public void messageBoxForInventoryAlert()
        {

            string s = Program.InventoryAlert();
            if (!String.Equals(s, ""))
            {
                DialogResult result = MessageBox.Show(s + "\n" + "Do you wish to make an order?", "INVENTORY ALERT!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    OrderProducts OrderProducts = new OrderProducts(EMP_ID);
                    OrderProducts.Enabled = true;
                    OrderProducts.Show();
                    


                }
                else
                {

                    this.Close();
                    Sales_Page New_SP = new Sales_Page(EMP_ID);
                    New_SP.Enabled = true;
                    New_SP.Show();
                }
            }
        }

        private int Get_Pro_QU()
        {
            foreach (Product P in Program.products)
            {
                if (P.get_productName().Equals(ProductName.Text))
                {
                    return P.get_productQuantity();
                }

            }
            return 0;
        }


    }
}




