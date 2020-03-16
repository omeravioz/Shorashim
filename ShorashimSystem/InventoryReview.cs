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
    public partial class InventoryReview : Form
    {

        int ID = 0; 

        public InventoryReview(int EM_ID)
        {

            this.ID = EM_ID;

            InitializeComponent();
            

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

            this.yellowLabel.BackColor = Color.LightYellow;
            this.orangeLabel.BackColor = Color.Orange;
            this.redLabel.BackColor = Color.DarkRed;
            this.orderBt.BackColor = Color.MintCream;


            productsWithState = new Dictionary<Product, int>();

            setStatus();

            timer1.Interval = 300; // time interval for blinking closets with status 3
            timer1.Start();

           

            for (int i =0; i<=9; i++)
                toolTip1.SetToolTip(buttons[i], getToolMessage(i)); // initializing tooltip for every closet


            toolTip1.ShowAlways = true;
        }


        private string getToolMessage(int closetNum)
        {
            string s="";

            int newstatus = 0;
            int status=0;
              
            toolTip1.ToolTipTitle = "Storage status:";
            foreach(Product p in Program.products) // setting the closet status
            {
                if (p.get_closetNum() == closetNum)
                {
                    newstatus = productsWithState[p];
                }
                if(newstatus>status)
                {
                    status = newstatus;
                } 
             }

            if(status==0) // setting tool tip message for closet with status 0
            {
                    s = "Full stock for all of the products in this cupboard";
            }

            if (status == 1) // setting tool tip message for closet with status 1
            {
                foreach (Product p in Program.products)
                {
                    if (p.get_closetNum() == closetNum)
                    {
                        if(productsWithState[p]==1)
                            s = s + p.get_productName() + " has between 25%-50% items above lower bound in the stock" +"\n";
                    } 
                }    
            }

            if (status == 2) // setting tool tip message for closet with status 2
            {
                foreach (Product p in Program.products)
                {
                    if (p.get_closetNum() == closetNum)
                    {
                        if (productsWithState[p] == 1)
                            s = s + p.get_productName() + " has between 25%-50% items above lower bound in the stock" + "\n";
                        if (productsWithState[p] == 2)
                            s = s + p.get_productName() + " has between 0%-25% items above lower bound in the stock" + "\n";
                    }
                }
            }

            if (status == 3) // setting tool tip message for closet with status 3 
            {
                foreach (Product p in Program.products)
                {
                    if (p.get_closetNum() == closetNum)
                    {
                        if (productsWithState[p] == 1)
                            s = s + p.get_productName() + " has between 25%-50% items above lower bound in the stock" + "\n";
                        if (productsWithState[p] == 2)
                            s = s + p.get_productName() + " has between 0%-25% items above lower bound in the stock" + "\n";
                        if (productsWithState[p] == 3)
                            s = s + p.get_productName() + " has exceeded its lower bound!!" + "\n";
                    }
                }
            }

            return s;
        }

        private void setStatus() // setting closet status and changes its color accordingly
        {
           
            int Closetstate = 0;
            for (int i = 0; i <= 9; i++)
            {
                Closetstate = 0;

                foreach (Product p in Program.products) // setting products status
                {
                    if (p.get_closetNum() == i)
                    {
                        if ((p.get_productQuantity() <= 1.5 * p.get_productLowerBound()) && (p.get_productQuantity() >= 1.25 * p.get_productLowerBound())) // checks the amount in stock comparing to lowerBound
                        {
                            Closetstate = Math.Max(Closetstate,1);

                        }
                        if ((p.get_productQuantity() < 1.25 * p.get_productLowerBound()) && (p.get_productQuantity() >= p.get_productLowerBound()))// checks the amount in stock comparing to lowerBound
                        {
                            Closetstate = Math.Max(Closetstate, 2);
                        }
                        if (p.get_productQuantity() < p.get_productLowerBound())// checks the amount in stock comparing to lowerBound
                        {
                            Closetstate = 3;
                        }

                        productsWithState.Add(p, Closetstate); // adding product with its status to the dictionary
                    }

                }



                // changing closet colors by closet status
                if (Closetstate == 1)
                {
                    buttons[i].BackColor = Color.LightYellow;
                    buttons[i].ForeColor = Color.Black;
                }
                if (Closetstate == 2)
                { 
                    buttons[i].BackColor = Color.Orange;
                    buttons[i].ForeColor = Color.Black;
                }
                if (Closetstate == 3)
                {
                    buttons[i].BackColor = Color.DarkRed;
                   
                    buttons[i].ForeColor = Color.Black;
                }
            }

        }



        private void header_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void timer1_Tick(object sender, EventArgs e) // blink in closets which have products below their lowerBound
        {


            this.counter++;
            if (counter == 10)
                timer1.Stop();

            foreach (Button b in buttons)
            {
                if (b.BackColor == Color.DarkRed)
                    b.Visible = !b.Visible;

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void BacklButton_Click(object sender, EventArgs e)
        {
            InventoryManagement inventoryManagement = new InventoryManagement(this.ID);
            inventoryManagement.Enabled = true;
            inventoryManagement.Show();
            this.Hide();

        }

        private void orderBt_Click(object sender, EventArgs e)
        {
            OrderProducts OrderProducts = new OrderProducts(this.ID);
            OrderProducts.Enabled = true;
            OrderProducts.Show();
            this.Hide();

        }

        private void InventoryReview_Load(object sender, EventArgs e)
        {

        }

        private void InventoryStateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
