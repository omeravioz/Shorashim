using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace ShorashimSystem
{
    class OrderFromSupplier
    {

        private int orderID;
        private DateTime orderDate;
        private DateTime orderDueDate;
        private double orderTotalPrice;
        private PaymentMethod paymentMethod;
        private OrderStatus orderStatus;
        private Employee employeeMakes; //הכלה 
        private Supplier supplier; //הכלה 
        private string Description;
        public System.Collections.Generic.List<ProductInOrder> ProductsInThisOrder; //הכלה

        public OrderFromSupplier(int id, DateTime date, DateTime dueDate, double totalPrice, PaymentMethod paymentMethod, OrderStatus status, Employee employeeMakes, Supplier supplier, string Description, bool is_new)
        {
            this.orderID = id;
            this.orderDate = date;
            this.orderDueDate = dueDate;
            this.orderTotalPrice = totalPrice;
            this.paymentMethod = paymentMethod;
            this.orderStatus = status;
            this.supplier = supplier;
            this.employeeMakes = employeeMakes;
            this.Description = Description;

            this.ProductsInThisOrder = new List<ProductInOrder>(); // initializing list
            this.supplier.supplierOrders.Add(this);
            this.employeeMakes.ordersFromSuppliers.Add(this);

            if (is_new)
            {
                this.create_orderFromSupplier();
                Program.ordersFromSuppliers.Add(this);
            }
        }

        //GETTERS:
        public int getID()
        {
            return this.orderID;
        }

        public double getTotalPrice()
        {
            return this.orderTotalPrice;
        }

        public DateTime getDateOfOrder()
        {
            return this.orderDate;
        }

        public DateTime getDueDateOfOrder()
        {
            return this.orderDueDate;
        }

        public PaymentMethod getPaymentMethod()
        {
            return this.paymentMethod;
        }

        public OrderStatus getOrderStatus()
        {
            return this.orderStatus;
        }

        public Employee getOrderEmployee()
        {
            return this.employeeMakes;
        }

        public Supplier getOrderSupplier()
        {
            return this.supplier;
        }

        public string getDescription()
        {
            return this.Description;
        }

        //SETTERS:

        public void setID(int id)
        {
            this.orderID = id; ;
        }

        public void setTotalPrice(double p)
        {
            this.orderTotalPrice = p;
        }

        public void setDateOfOrder(DateTime d)
        {
            this.orderDate = d;
        }

        public void setDueDateOfOrder(DateTime d)
        {
            this.orderDueDate = d;
        }

        public void setPaymentMethod(PaymentMethod m)
        {
            this.paymentMethod = m;
        }

        public void setOrderStatus(OrderStatus o)
        {
            this.orderStatus = o;
        }


        public void addProductInOrder(ProductInOrder pio1)
        {
            this.ProductsInThisOrder.Add(pio1);
        }


        public void PrintAll()
        {
            foreach (ProductInOrder pio in this.ProductsInThisOrder)
            {
                Console.WriteLine(pio.get_ProductInOrder().get_productID() + " " + pio.getOrderFromSupplier().getID() + " " + pio.getQuantity());
            }
        }


        //CRU FUNCTIONS:
        public void create_orderFromSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Orders_From_Supplier @Order_ID, @Order_Date, @Order_Due_Date, @Order_Total_Price, @Payment_Method, @Order_Status, @Employee_Makes, @Supllier_receives, @Description";//-------check Employee and supplier
            c.Parameters.AddWithValue("@Order_ID", this.orderID);
            c.Parameters.AddWithValue("@Order_Date", this.orderDate);
            c.Parameters.AddWithValue("@Order_Due_Date", this.orderDueDate);
            c.Parameters.AddWithValue("@Order_Total_Price", this.orderTotalPrice);
            c.Parameters.AddWithValue("@Payment_Method", this.paymentMethod.ToString());
            c.Parameters.AddWithValue("@Order_Status", this.orderStatus.ToString());
            c.Parameters.AddWithValue("@Employee_Makes", this.employeeMakes.get_employeeID());
            c.Parameters.AddWithValue("@Supllier_receives", this.supplier.get_supplierID());
            c.Parameters.AddWithValue("@Description", this.Description);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }




    }
}
