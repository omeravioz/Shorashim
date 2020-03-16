using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShorashimSystem
{
    class ProductInPurchases
    {

        private Purchase purchase; //הכלה
        private Product product; //הכלה
        private int quantity;


        public ProductInPurchases(Purchase purchaseToCustomer, Product product, int quantity, bool is_new)
        {
            this.quantity = quantity;
            this.purchase = purchaseToCustomer; //הכלה
            this.product = product; //הכלה
            this.purchase.addProductsInPurchase(this); // הכלה
            this.product.addProductsInPurchase(this);

            if (is_new)
            {
                createProductInPurchase();
            }

        }

        public string get_ProductID()
        {
            return this.product.get_productID();
        }
        public void set_Product_In_Purchaes(Product Value)
        {
            this.product = Value;

        }
     

        public int get_PurchaseID()
        {
            return this.purchase.getID();
        }

        public int get_Quantity()
        {
            return this.quantity;
        }

        public void set_Quantity(int value)
        {
            this.quantity = value;
        }


        public Product get_Product()
        {
            return this.product;
        }

        public void printProductDetails()
        {

            Console.WriteLine(this.product.get_productID() + " " + this.product.get_productName() + " " + this.product.get_productSupplierID() + " " + this.product.getSupplierPrice() + " " + this.product.getSalePrice() + " " + this.product.get_productCategory() + " " + this.product.get_Description() + " " + this.product.get_productQuantity() + " " + this.product.get_productLowerBound(), this.product.get_shelfNum(), this.product.get_closetNum());
        }

        public void printPurchasesDetails()
        {

            Console.WriteLine(this.purchase.get_purchasePromoCodeName() + " " + this.purchase.get_purchcaseCustomerID() + " " + this.purchase.get_purchcaseEmployeeID());
        }



        public void createProductInPurchase()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Products_In_Purchase @Purchase_ID, @Product_ID, @Quantity";
            c.Parameters.AddWithValue("@Product_ID", this.product.get_productID());
            c.Parameters.AddWithValue("@Purchase_ID", this.purchase.getID());
            c.Parameters.AddWithValue("@Quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void UpdateProductInPurchase()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Products_In_Purchase @Purchase_ID, @Product_ID, @Quantity";
            c.Parameters.AddWithValue("@Product_ID", this.product.get_productID());
            c.Parameters.AddWithValue("@Purchase_ID", this.purchase.getID());
            c.Parameters.AddWithValue("@Quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }




    }
}
