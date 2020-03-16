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
    public partial class Map : Form
    {


        int EMP_ID;
        public Map(int EMP_ID)
        {
            InitializeComponent();
            Fill_combo_box();
            this.EMP_ID = EMP_ID;


            this.buttons = new List<Button>();
            buttons.Add(this.button1);
            buttons.Add(this.button2);
            buttons.Add(this.button3);
            buttons.Add(this.button4);
            buttons.Add(this.button5);
            buttons.Add(this.button6);
            buttons.Add(this.button7);
            buttons.Add(this.button8);
            buttons.Add(this.button9);
            buttons.Add(this.button10);


            this.Header.BackColor = Color.Sienna;

            this.ChooseProduct.BackColor = Color.OldLace;
            this.ChooseProduct.BackColor = Color.OldLace;
            this.SetPriorityBt.BackColor = Color.OldLace;
            this.FindBt.BackColor = Color.OldLace;
            this.comboBox1.BackColor = Color.OldLace;

            this.toolTip1.SetToolTip(this.SetPriorityBt, "Press to allocate products in the store by priority");

            this.SetPriorityBt.FlatStyle = FlatStyle.Flat;
            this.SetPriorityBt.FlatAppearance.BorderColor = Color.Black;
            this.SetPriorityBt.FlatAppearance.BorderSize = 1;


            toolTip1.ShowAlways = true;


        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e) // Find button
        {
            for (int i = 0; i <= 9; i++)    // reset colors
                this.buttons[i].BackColor = Color.Black;


            string s = comboBox1.Text;
            Product p = Program.seekProductByName(s);
            this.lastProductSearched = p;
            if (p != null)
            {
                this.buttons[p.get_closetNum()].BackColor = Color.Red;
                MessageBox.Show("Search completed successfully", "Map notification", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("ID number is wrong", "try again ", MessageBoxButtons.OK);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        public void Fill_combo_box()
        {
            List<string> names = new List<string>();

            foreach (Product P in Program.products)
            {
                names.Add(P.get_productName());
            }
            comboBox1.DataSource = names;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (button1.BackColor == Color.Red)
            { 
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum() , "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button1.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (button2.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button2.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (button3.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button3.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (button4.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button4.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (button5.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button5.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (button6.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button6.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            if (button7.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button7.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (button8.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button8.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            if (button9.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button9.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            if (button10.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Right)
                {
                    MessageBox.Show("Shelf number for this product is: " + this.lastProductSearched.get_shelfNum(), "Noitce ", MessageBoxButtons.OK);
                }
            }

            if (button10.BackColor == Color.Red)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    Closet closet = new Closet(this.lastProductSearched.get_shelfNum());
                    closet.Enabled = true;
                    closet.Show();
                }
            }
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }




        public void initStoreMap()
        {
            setPriorities();
            setLocations();

            foreach(Button b in this.buttons) // paints all buttons in black after setting the map by priority
            {
                if(b.BackColor==Color.Red)
                {
                    b.BackColor = Color.Black;
                }
            }
        }

      

        public static void setPriorities()
        {
            foreach (Product p in Program.products)
            {
                p.setPriority(0);
            }

            foreach (Purchase p in Program.purchases)
            {
                foreach (ProductInPurchases pin in p.Products_In_Purchase)
                {
                    pin.get_Product().increasePriority(pin.get_Quantity());
                } // setting products priorities by the quantity bought from this product
            }
        }

        public static void setLocations()
        {
            Program.products.Sort(); // sorting by priority - compareTo function in Products class
            foreach (Product p in Program.products) // printing to check the sorting worked
                Console.WriteLine(p.get_productID() + "     " + p.getPriority());


            int ClosetCounter = 0;
            int ShelfCounter = 1;
            foreach (Product p in Program.products)
            {
                p.setCloset(ClosetCounter);
                p.setShelf(ShelfCounter);
                ShelfCounter++;

                if (ShelfCounter == 7) // each closet have space for 3 products
                {
                    ShelfCounter = 1;
                    ClosetCounter++;
                }

                if (ClosetCounter == 10) // cant add more products - 10 Closets are full
                {
                    MessageBox.Show("There is not enough space in the store for all products" +"/n" + "The system allocated the products with higher priority", "Map Notification", MessageBoxButtons.OK);
                    break;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e) // set map by priority button
        {
            initStoreMap();
            MessageBox.Show("Map setting is completed successfully", "Map Notification", MessageBoxButtons.OK);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void BacklButton_Click(object sender, EventArgs e)
        {
            
            InventoryManagement inventoryManagement = new InventoryManagement(EMP_ID);
            inventoryManagement.Enabled = true;
            inventoryManagement.Show();
            this.Hide();
            
        }

        private void Header_Click(object sender, EventArgs e)
        {

        }
    }




}
