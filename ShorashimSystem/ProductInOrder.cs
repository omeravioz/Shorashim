using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShorashimSystem
{
    class ProductInOrder
    {
        private Product productInOrder;  // הכלה
        private OrderFromSupplier orderFromSupplier; //הכלה
        private int quantity;


        public ProductInOrder(Product productInOrder, OrderFromSupplier orderFromSupplier, int quantity, bool is_new)
        {
            this.productInOrder = productInOrder; // הכלה
            this.orderFromSupplier = orderFromSupplier; //הכלה
            this.quantity = quantity;

            this.orderFromSupplier.addProductInOrder(this);
            this.productInOrder.addSupplierOrdersOfThisProduct(this);

            if (is_new)
            {
                this.createProductsInOrder();
            }


        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public Product get_ProductInOrder()
        {
            return this.productInOrder;
        }

        public OrderFromSupplier getOrderFromSupplier()
        {
            return this.orderFromSupplier;
        }


        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void createProductsInOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Products_In_Supplier_Order @Order_ID, @Product_ID, @Quantity";
            c.Parameters.AddWithValue("@Order_ID", this.orderFromSupplier.getID());
            c.Parameters.AddWithValue("@Product_ID", this.productInOrder.get_productID());
            c.Parameters.AddWithValue("@Quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateProductsInOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Products_In_Supplier_Order @Order_ID, @Product_ID, @Quantity";
            c.Parameters.AddWithValue("@Order_ID", this.orderFromSupplier.getID());
            c.Parameters.AddWithValue("@Product_ID", this.productInOrder.get_productID());
            c.Parameters.AddWithValue("@Quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void DeleteProductInOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Delete_Product_In_order @Order_ID, @Product_ID ";
            c.Parameters.AddWithValue("@Order_ID", this.orderFromSupplier.getID());
            c.Parameters.AddWithValue("@Product_ID", this.productInOrder.get_productID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
