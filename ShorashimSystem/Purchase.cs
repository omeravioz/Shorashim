using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ShorashimSystem
{
    class Purchase
    {


        private int purchaseID;
        private double purchasePrice;
        private Employee purchaseByEmployee;
        private Customer purchaseByCustomer;
        private DateTime purchaseDate;
        private PaymentMethod paymentMethod;
        private PromoCodes purchasePromoCode;
        public System.Collections.Generic.List<ProductInPurchases> Products_In_Purchase; //הכלה


        public Purchase(int ID, double price, Employee purchaseByEmployee, Customer purchaseByCustomer, DateTime date, PaymentMethod paymentMethod, PromoCodes purchasePromoCode, bool is_new)
        {
            this.purchaseID = ID;
            this.purchasePrice = price;
            this.purchaseByEmployee = purchaseByEmployee;
            this.purchaseByCustomer = purchaseByCustomer;
            this.purchaseDate = date;
            this.paymentMethod = paymentMethod;
            this.purchasePromoCode = purchasePromoCode;
            this.purchaseByEmployee = purchaseByEmployee;

            this.Products_In_Purchase = new List<ProductInPurchases>();
            this.purchaseByCustomer.CustomersPurchases.Add(this);
            this.purchaseByEmployee.purchasesToCustomers.Add(this);


            if (purchasePromoCode != null)
            {
                this.purchasePromoCode.promoCodeInPurchase.Add(this);
            }


            if (is_new)
            {
                this.create_purchase();
                Program.purchases.Add(this);
            }
        }

        public void printAllProductsInPurchases()
        {
            foreach (ProductInPurchases pip in this.Products_In_Purchase)
            {
                Console.WriteLine(pip.get_ProductID() + " " + pip.get_PurchaseID() + " " + pip.get_Quantity());
            }
        }


        public int getID()
        {
            return this.purchaseID;
        }

        public double getPrice()
        {
            return this.purchasePrice;
        }

        public int get_purchcaseEmployeeID()
        {
            return this.purchaseByEmployee.get_employeeID();
        }

        public int get_purchcaseCustomerID()
        {
            return this.purchaseByCustomer.get_customerID();
        }

        public DateTime getDateOfPurchase()
        {
            return this.purchaseDate;
        }

        public PaymentMethod getPaymentMethod()
        {
            return this.paymentMethod;
        }

        public string get_purchasePromoCodeName()
        {
            if (purchasePromoCode != null)
            {
                return this.purchasePromoCode.getPromoName();
            }
            return null;
        }

        public void printAll()
        {
            foreach (ProductInPurchases p in Products_In_Purchase)
            {
                Console.WriteLine(p.get_ProductID());
            }

        }




        //SETTERS:

        public void setID(int id)
        {
            this.purchaseID = id; ;
        }

        public void setPrice(double p)
        {
            this.purchasePrice = p;
        }

        public void setDateOfPurchase(DateTime d)
        {
            this.purchaseDate = d;
        }

        public void setPaymentMethod(PaymentMethod m)
        {
            this.paymentMethod = m;
        }


        public void addProductsInPurchase(ProductInPurchases pip1)
        {
            this.Products_In_Purchase.Add(pip1);
        }

        public void PrintAll()
        {
            foreach (ProductInPurchases pio in this.Products_In_Purchase)
            {
                Console.WriteLine(pio.get_ProductID() + " " + pio.get_PurchaseID()+ " " + pio.get_Quantity());
            }
        }


        //CRU FUNCTIONS:
        public void create_purchase()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Purchase @Purchase_ID, @Purchase_Price, @Purchase_By_Employee, @Purchase_By_Customer, @Purchase_Date, @Payment_Method, @Purchase_Promo_Code";
            c.Parameters.AddWithValue("@Purchase_ID", this.purchaseID);
            c.Parameters.AddWithValue("@Purchase_Price", this.purchasePrice);
            c.Parameters.AddWithValue("@Purchase_By_Employee", this.purchaseByEmployee.get_employeeID());
            c.Parameters.AddWithValue("@Purchase_By_Customer", this.purchaseByCustomer.get_customerID());
            c.Parameters.AddWithValue("@Purchase_Date", this.purchaseDate);
            c.Parameters.AddWithValue("@Payment_Method", this.paymentMethod.ToString());
            c.Parameters.AddWithValue("@Purchase_Promo_Code", this.purchasePromoCode.getPromoName());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_purchase()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Purchase @Purchase_ID, @Purchase_Price, @Purchase_By_Employee, @Purchase_By_Customer, @Purchase_Date, @Payment_Method, @Purchase_Promo_Code";
            c.Parameters.AddWithValue("@Purchase_ID", this.purchaseID);
            c.Parameters.AddWithValue("@Purchase_Price", this.purchasePrice);
            c.Parameters.AddWithValue("@Purchase_By_Employee", this.purchaseByEmployee.get_employeeID());
            c.Parameters.AddWithValue("@Purchase_By_Customer", this.purchaseByCustomer.get_customerID());
            c.Parameters.AddWithValue("@Purchase_Date", this.purchaseDate);
            c.Parameters.AddWithValue("@Payment_Method", this.paymentMethod.ToString());
            c.Parameters.AddWithValue("@Purchase_Promo_Code", this.purchasePromoCode.getPromoName());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
