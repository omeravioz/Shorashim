using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShorashimSystem
{
    class Supplier
    {

        private int supplierID;
        private string supplierName;
        private string supplierPhone;
        private string supplierEmail;
        private string supplierAddress;
        private string supplierDescription;
        public System.Collections.Generic.List<OrderFromSupplier> supplierOrders; //הכלה


        public Supplier(int ID, string name, string phone, string Email, string address, string Description, bool is_new)
        {
            this.supplierName = name;
            this.supplierID = ID;
            this.supplierPhone = phone;
            this.supplierEmail = Email;
            this.supplierAddress = address;
            this.supplierDescription = Description;
            supplierOrders = new List<OrderFromSupplier>();

            if (is_new)
            {
                this.create_supplier();
                Program.suppliers.Add(this);
            }

        }

        public void printAllOrdersFromThisSupplier()
        {
            foreach (OrderFromSupplier i in this.supplierOrders)
            {
                Console.WriteLine(i.getID() + " " + i.getDateOfOrder() + " " + i.getDueDateOfOrder() + " " + i.getTotalPrice() + " " + i.getPaymentMethod() + " " + i.getOrderStatus() + " " + i.getOrderEmployee().get_employeeID() + " " + i.getOrderSupplier().get_supplierID() + " " + i.getDescription());
            }
        }

        public int get_supplierID()
        {
            return this.supplierID;
        }

        public string get_supplierName()
        {
            return this.supplierName;
        }

        public string get_supplierPhone()
        {
            return this.supplierPhone;
        }


        public string get_supplierEmail()
        {
            return this.supplierEmail;
        }

        public string get_supplierAddress()
        {
            return this.supplierAddress;
        }

        public string get_supplierDescription()
        {
            return this.supplierDescription;
        }

        public void create_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Suppliers @Supplier_ID, @Supplier_Name, @Supplier_Phone, @Supplier_Email, @Supplier_Address, @Supplier_Description";
            c.Parameters.AddWithValue("@Supplier_ID", this.supplierID);
            c.Parameters.AddWithValue("@Supplier_Name", this.supplierName);
            c.Parameters.AddWithValue("@Supplier_Phone", this.supplierPhone);
            c.Parameters.AddWithValue("@Supplier_Email", this.supplierEmail);
            c.Parameters.AddWithValue("@Supplier_Address", this.supplierAddress);
            c.Parameters.AddWithValue("@Supplier_Description", this.supplierDescription);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }





    }
}
