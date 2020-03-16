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
    

    public partial class InsertProductsToCourse : Form
    {
        
        double Total_Price;
        public string courseNumber1;
        private int value;
        int EID;
        

        public InsertProductsToCourse(string CourseNumber , int eid)
        {
            InitializeComponent();
            this.courseNumber1 = CourseNumber;
            this.CourseNumberInput.Text = courseNumber1;
            this.CourseNameInput.Text = (Program.seekCourse(this.CourseNumberInput.Text).get_CourseName());
            this.EID = eid;
            Fill_combo_box();




            }

        private void OrderId_Click(object sender, EventArgs e)
        {

        }

        private void CourseNumberInput_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void ComboTextChooseProduct_SelectedIndexChanged(object sender, EventArgs e)
        
        {
            QuantityFromUser.Clear();
        }

        public void Fill_combo_box()
        {
            List<string> names = new List<string>();

            foreach (Product P in Program.products)
            {
                names.Add(P.get_productName());
            }
            ComboTextChooseProduct.DataSource = names;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            CoursesManagement New_CBM = new CoursesManagement(EID);
            New_CBM.Enabled = true;//maybe not needed
            New_CBM.ShowDialog();
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Product P = Program.seekProductByName(ComboTextChooseProduct.Text);

            if(P.get_productQuantity()< Int32.Parse(QuantityFromUser.Text))
            {

                MessageBox.Show(" Please enter quantity in stock", "Error", MessageBoxButtons.OK);
            }

            else if (int.TryParse(QuantityFromUser.Text, out value))
            {
            


                string data = string.Empty;
                bool isExist = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)    ///check if already exists - only 1 from each product
                {
                   
                    data = Convert.ToString(row.Cells[1].Value);
                    if (Equals(ComboTextChooseProduct.SelectedValue, data) == true)
                    {
                        isExist = true;
                    }

                }


                if (isExist == false)
                {
                    dataGridView1.Rows.Add(P.get_productID(), P.get_productName(), P.get_productCategory(), int.Parse(QuantityFromUser.Text), P.getSupplierPrice(), P.get_Description());
                    Total_Price = Total_Price + (double.Parse(QuantityFromUser.Text) * (P.getSupplierPrice()));
                    costoutput.Text = Total_Price.ToString();
                }
                else
                {
                    MessageBox.Show(" You already ordered this product!", "Invaild Input", MessageBoxButtons.OK);
                }




            }
            else
            {
                MessageBox.Show(" Please enter a number for quantity", "Error", MessageBoxButtons.OK);
            }
        }


        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;


                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    Total_Price = Total_Price - (Convert.ToDouble(dataGridView1.Rows[item.Index].Cells[3].Value) * (Convert.ToDouble(dataGridView1.Rows[item.Index].Cells[4].Value)));
                    costoutput.Text = Total_Price.ToString();
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void costoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityFromUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            ShorashimCourse sc = Program.seekCourse(this.courseNumber1);


            string data = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                data = Convert.ToString(row.Cells[1].Value);
                int quantity1 = Convert.ToInt32(row.Cells[3].Value);


                Product pnew = Program.seekProductByName(data);

                if (pnew != null)
                {

                    ProductInCourse NewPIC = new ProductInCourse(sc, pnew, quantity1, true);
                    pnew.setProductQuantity(pnew.get_productQuantity() - quantity1); // change to new quantity attribute
                    pnew.update_product();  // update sql
                    messageBoxForInventoryAlert();

                }


            }

            foreach (OrderFromSupplier o in Program.ordersFromSuppliers)  //check of hahalot - products of every order
            {
                o.PrintAll();
            }

            foreach (Product p in Program.products)    //check of hahalot - orders of this product
            {

                Console.WriteLine("printing ProductInCourse lists of products");
                p.printAllthisProductsInCourses();

            }


   

        }

        private void InsertProductsToCourse_Load(object sender, EventArgs e)
        {

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
                    OrderProducts OrderProducts = new OrderProducts(EID);
                    OrderProducts.Enabled = true;
                    OrderProducts.Show();



                }
                else
                {

                    this.Close();
                    Main_Menu mainMenu1 = new Main_Menu(EID);
                    mainMenu1.Enabled = true;
                    mainMenu1.Show();
                }
            }
        }




    }
}




