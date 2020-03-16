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

    public partial class OrderProducts : Form
    {
        Boolean flag = false;
        int EMP_ID;
        double Total_Price;
        public OrderProducts(int EMP_ID)
        {

            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now.AddDays(14);
            OrderDateInput.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            this.EMP_ID = EMP_ID;
            int maxID = 0;
            foreach (OrderFromSupplier ofs in Program.ordersFromSuppliers)
            {
                if (ofs.getID() > maxID)
                    maxID = ofs.getID();
            }
            maxID++;
            OrderIDInput.Text = Convert.ToString(maxID);
            SupllierInput.DataSource = GetSuppliers();

            comboBox1.DataSource = Enum.GetValues(typeof(ProductCategory));
            PMInput.DataSource = Enum.GetValues(typeof(PaymentMethod));

            OrderDateInput.ReadOnly = true;
            OrderDateInput.Enabled = false;
            OrderOutput.ReadOnly = true;
            OrderOutput.Enabled = false;
            OrderIDInput.ReadOnly = true;
            OrderIDInput.Enabled = false;
            
         
        }



        private void OrderFromSupplierButton_Click(object sender, EventArgs e)
        {

        }

        private void OrderProducts_Load(object sender, EventArgs e)
        {

        }

        private void OrderIDInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SupplierIDInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendPromotionCodeMail_Click(object sender, EventArgs e)// wrong name but this is the add product button
        {
         



        }

        private void Category_Click(object sender, EventArgs e)
        {

        }

        private void CategoryCombe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1; // clear combobox
            flag = true;
            int Sup_ID = Get_Sup_ID();
            ProductCategory C = (ProductCategory)comboBox1.SelectedValue;





            List<string> Product = new List<string>();

            foreach (Product P in Program.products)
            {

                if (C.Equals(P.get_productCategory()) && P.get_productSupplierID() == Sup_ID)
                {
                    Product.Add(P.get_productName());
                }

            }

            comboBox2.DataSource = Product;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_Click(object sender, EventArgs e)
        {

        }

        private void SupllierInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
                comboBox1_SelectedIndexChanged(sender, e);

           

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
                if (S.get_supplierName().Equals(SupllierInput.Text))
                {
                    return S.get_supplierID();
                }

            }
            return 0;
        }
        private void Update_Product()
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ORDRERS_MAIN New_om = new ORDRERS_MAIN(EMP_ID);
            New_om.Enabled = true;
            New_om.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderDateInput_TextChanged(object sender, EventArgs e)
        {

        }



        private void OrderOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private double Product_Price()
        {

            foreach (Product P in Program.products)
            {
                if (comboBox2.Text.Equals(P.get_productName()))
                    return P.getSupplierPrice();
            }
            return 0.0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;


                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    Total_Price = Total_Price - Convert.ToDouble(dataGridView1.Rows[item.Index].Cells[4].Value);
                    dataGridView1.Rows.RemoveAt(item.Index);
                    
                
                OrderOutput.Text = Convert.ToString(Total_Price);
                }
            }


            if (dataGridView1.Rows.Count == 1) {

                SupllierInput.Enabled = true;

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (OrderOutput.Text == "" || Int32.Parse(OrderOutput.Text)==0)
                MessageBox.Show(" Please field all the fields ", "Invaild Input", MessageBoxButtons.OK);
            else
            {
                DateTime date = Convert.ToDateTime(OrderDateInput.Text, CultureInfo.InvariantCulture);
                DateTime duedate = Convert.ToDateTime(dateTimePicker1.Value, CultureInfo.InvariantCulture);
                string description1 = DescrriptionBox.Text;


                // str = dataGridView1.Rows[DataGridView.SelectedRows[0].Index].Cells[X].Value.ToString();

                OrderFromSupplier OFS = new OrderFromSupplier(Convert.ToInt32(OrderIDInput.Text, CultureInfo.InvariantCulture), date, duedate, Convert.ToDouble(Total_Price, CultureInfo.InvariantCulture),
                    (PaymentMethod)Enum.Parse(typeof(PaymentMethod), PMInput.Text), (OrderStatus)Enum.Parse(typeof(OrderStatus), "UnderTreatment"), Program.seekEmployee(EMP_ID), Program.seekSupplierByName(SupllierInput.Text), description1,true);

                string data = string.Empty;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                   
                    data = Convert.ToString(row.Cells[2].Value);
                    int quantity1 = Convert.ToInt32(row.Cells[3].Value);
                    
                    
                    Product pnew = Program.seekProductByName(data);

                    if(pnew != null) { 

                    ProductInOrder NewPIP = new ProductInOrder(pnew, OFS, quantity1, true);

                    }


                }

                
            }





            foreach (OrderFromSupplier o in Program.ordersFromSuppliers)  //check of hahalot - products of every order
            {
                o.PrintAll();
            }

            foreach (Product p in Program.products)    //check of hahalot - orders of this product
            {

                Console.WriteLine("printing ProductInOrder lists of products");
                p.printAllSupplierOrdersOfThisProduct();

            }


            this.Close();
            Main_Menu New_MM = new Main_Menu(EMP_ID);
            New_MM.Enabled = true;
            New_MM.Show();

        }


    



        private void PMInput_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void DescrriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            int value;

            if (comboBox2.SelectedItem == null)
                MessageBox.Show(" Please Choose Product", "Invaild Input", MessageBoxButtons.OK);

            else if (int.TryParse(textBox1.Text, out value) == false || string.IsNullOrWhiteSpace(textBox1.Text) || Int32.Parse(textBox1.Text) < 0)
                MessageBox.Show(" Please enter Valid Quantity", "Invaild Input", MessageBoxButtons.OK);

            else
            {

                string data = string.Empty;
                bool isExist = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)    ///check if already exists - only 1 from each product
                {

                    data = Convert.ToString(row.Cells[2].Value);
                    if (Equals(comboBox2.SelectedValue, data) == true)
                    {
                        isExist = true;
                    }
      
                }


                if (isExist==false) { 
                    dataGridView1.Rows.Add(SupllierInput.Text, comboBox1.Text, comboBox2.Text, textBox1.Text, Product_Price() * (Int32.Parse(textBox1.Text)));
                Total_Price = Total_Price + (Product_Price() * (Int32.Parse(textBox1.Text)));
                OrderOutput.Text = Convert.ToString(Total_Price);
                textBox1.Clear();
                comboBox2.SelectedIndex = -1;
                SupllierInput.Enabled = false;
                }
                else
                {
                    MessageBox.Show(" You already ordered this product!", "Invaild Input", MessageBoxButtons.OK);
                }

            }
        }

        private void PaymentMethod_Click(object sender, EventArgs e)
        {

        }
    }
}

