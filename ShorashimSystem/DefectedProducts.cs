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
    public partial class DefectedProducts : Form
    {
        Boolean flag = false;
        int EMP_ID;
       
        public DefectedProducts(int EMP_ID)
        {
            this.EMP_ID = EMP_ID;
            InitializeComponent();

            Supplier.DataSource = GetSuppliers();
            Category.DataSource = Enum.GetValues(typeof(ProductCategory));
           
        }

        private void Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
                Category_SelectedIndexChanged(sender, e);
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductName.SelectedIndex = -1; // clear combobox
            flag = true;
            int Sup_ID = Get_Sup_ID();
            ProductCategory C = (ProductCategory)Category.SelectedValue;

            List<string> Product = new List<string>();

            foreach (Product P in Program.products)
            {

                if (C.Equals(P.get_productCategory()) && P.get_productSupplierID() == Sup_ID)
                {
                    Product.Add(P.get_productName());
                }

            }

            ProductName.DataSource = Product;
        }

        private void ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            int value;

            if (ProductName.SelectedItem == null)
                MessageBox.Show(" Please Choose Product", "Invaild Input", MessageBoxButtons.OK);

            else if (int.TryParse(textBox1.Text, out value) == false || string.IsNullOrWhiteSpace(textBox1.Text) || Int32.Parse(textBox1.Text) < 0  || (Get_Pro_QU()-Int32.Parse(textBox1.Text)) < 0)
                MessageBox.Show(" Please enter Valid Quantity", "Invaild Input", MessageBoxButtons.OK);

            else {


                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Return Defective Approval", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    int newQuantity = Get_Pro_QU() - Int32.Parse(textBox1.Text);
                    dataGridView1.Rows.Add(Supplier.Text, Category.Text, ProductName.Text, Get_Pro_QU(), newQuantity);
                    MessageBox.Show(" The Defected Product has Sent to the supplier", "Done!", MessageBoxButtons.OK);

                    Program.seekProductByName(ProductName.Text).setProductQuantity(newQuantity); // change to new quantity attribute
                    Program.seekProductByName(ProductName.Text).update_product();  // update sql
                    messageBoxForInventoryAlert();





                }
                else if (dialogResult == DialogResult.No)
                {

                }



            }

        

        
            
            {

            }
        }

        


        private List<string> GetSuppliers()
        {

            List<string> Suppliers = new List<string>();
            foreach (Supplier S in Program.suppliers)
            {
                Suppliers.Add(S.get_supplierName());
            }
            return Suppliers;
        }

        private int Get_Sup_ID()
        {
            foreach (Supplier S in Program.suppliers)
            {
                if (S.get_supplierName().Equals(Supplier.Text))
                {
                    return S.get_supplierID();
                }

            }
            return 0;
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ORDRERS_MAIN New_om = new ORDRERS_MAIN(EMP_ID);
            New_om.Enabled = true;
            New_om.Show();
        }


        public void messageBoxForInventoryAlert()
        {
            
            string s = Program.InventoryAlert();
            if (!String.Equals(s, ""))
            {
                DialogResult result = MessageBox.Show(s + "\n" + "Do you wish to make an order?", "INVENTORY ALERT!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    OrderProducts OrderProducts = new OrderProducts(EMP_ID);
                    OrderProducts.Enabled = true;
                    OrderProducts.Show();
                    this.Hide();
           

                }
                else
                {

                    
                }
            }
        }



    }
}
