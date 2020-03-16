using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace ShorashimSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        // initalizing lists
        public static System.Collections.Generic.List<Customer> customers;
        public static System.Collections.Generic.List<Employee> employees;
        public static System.Collections.Generic.List<Product> products;
        public static System.Collections.Generic.List<OrderFromSupplier> ordersFromSuppliers;
        public static System.Collections.Generic.List<Supplier> suppliers;
        public static System.Collections.Generic.List<Purchase> purchases;
        public static System.Collections.Generic.List<ProductInPurchases> productsInPurchase;
        public static System.Collections.Generic.List<ProductInOrder> productsInOrder;
        public static System.Collections.Generic.List<PromoCodes> promoCodes;
        public static System.Collections.Generic.List<ShorashimCourse> Shorashim_Courses;
        public static System.Collections.Generic.List<ProductInCourse> Products_In_Course;
        public static System.Collections.Generic.List<CustomerInCourse> Customers_In_Course;





        [STAThread]

        public static void initLists()    // initalizing data from sql
        {

            init_Courses();
            init_customers();
            init_Supplier();
            init_Products();
            init_employees();
            init_PromoCodes();
            init_Purchases();

            init_ordersFromSupplier();

            init_ProductsInOrder();
            init_Product_In_Purchases();
            init_Product_In_Courses();
            init_Customer_In_Courses();


        }





        public static string InventoryAlert() // returns a string with products names that reached lower bound / empty string if there are no such products
        {
            int indicator = 0; // 0 - no products below lower bound. 1 - there is at least one product below lower bound
            string alert = "";

            foreach (Product p in products)
            {
                if(p.get_productQuantity()<p.get_productLowerBound())
                {
                    if(indicator == 0) // happens only before the first product we found that is below lower bound
                    {
                        alert = "The following products reached their lower bound:" + "\n";
                        indicator = 1;
                    }
                    alert  = alert + p.get_productName() + "\n";    
                }
            }

            return alert;
        }

           
        public static void quantityUpdateOfProductInOrder(OrderFromSupplier o, Product p, int newQuantity)
        {
            
               foreach (ProductInOrder pio in o.ProductsInThisOrder)
               {
                   if((pio.getOrderFromSupplier().getID()==o.getID()) && (pio.get_ProductInOrder().get_productID()==p.get_productID()))
                   {
                        pio.setQuantity(newQuantity);
                        pio.updateProductsInOrder();     // ######################### to check if the procedure is right
                }
               }

         
            // prints the lists in this order and in this product to check if productInOrder changed 
            o.PrintAll();
            p.printAllSupplierOrdersOfThisProduct();

        }



        public static void deleteProductInOrder(OrderFromSupplier o, Product p)
        {
            ProductInOrder pioToRemove=null;
            foreach (ProductInOrder pio in o.ProductsInThisOrder)
            {
                if ((pio.getOrderFromSupplier().getID() == o.getID()) && (pio.get_ProductInOrder().get_productID() == p.get_productID()))
                {
                    pioToRemove = pio;
                }
            }

            o.ProductsInThisOrder.Remove(pioToRemove);
            p.SupplierOrdersOfThisProduct.Remove(pioToRemove);
            pioToRemove.DeleteProductInOrder();

            // prints the lists in this order and in this product to check if deleted them
            o.PrintAll();
            Console.WriteLine("\n");
            p.printAllSupplierOrdersOfThisProduct();
            
        }






        // seeking functions 
        public static Customer seekCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.get_customerID() == id)
                    return c;
            }
            return null;
        }

        public static Supplier seekSupplier(int id)
        {
            foreach (Supplier s in suppliers)
            {
                if (s.get_supplierID() == id)
                    return s;
            }
            return null;
        }

        public static Employee seekEmployee(int id)
        {

            foreach (Employee e in employees)
            {
                if (e.get_employeeID() == id)
                    return e;
            }
            return null;
        }

        public static OrderFromSupplier seekOrder_From_Supplier(int id)
        {
            foreach (OrderFromSupplier ofs in ordersFromSuppliers)
            {
                if (ofs.getID() == id)
                    return ofs;
            }
            return null;
        }

        public static Purchase seekPurchases(int id)
        {
            foreach (Purchase p in purchases)
            {
                if (p.getID() == id)
                    return p;
            }
            return null;
        }

        public static Purchase seekPurchase(int id)
        {
            foreach (Purchase p in purchases)
            {
                if (p.getID() == id)
                    return p;
            }

            return null;
        }


        public static Product seekProduct(string id)
        {
            foreach (Product p in products)
            {
                if (p.get_productID() == id)
                    return p;
            }
            return null;
        }

        public static PromoCodes seekPromoCode(string name)
        {
            foreach (PromoCodes p in promoCodes)
            {
                if (Equals(p.getPromoName(), name))
                    return p;
            }
            return null;
        }

    
        public static ShorashimCourse seekCourse(string number)
        {
            foreach (ShorashimCourse p in Shorashim_Courses)
            {
                if (String.Equals(p.get_Coursenumber(), number))
                    return p;
            }
            return null;
        }

        public static ShorashimCourse seekCourseByName(string name)
        {
            foreach (ShorashimCourse p in Shorashim_Courses)
            {
                if (String.Equals(p.get_CourseName(), name))
                    return p;
            }
            return null;
        }


        public static Product seekProductByName(string name)
        {
            foreach (Product p in products)
            {
                if (String.Equals(p.get_productName(), name))
                    return p;
            }
            return null;
        }


        public static Customer seekCustomerByEmail(string EmailToComp)
        {
            foreach (Customer c in customers)
            {
                if (String.Equals(c.get_Email(), EmailToComp))
                    return c;
            }
            return null;
        }

        public static Supplier seekSupplierByName(string name)
        {
            foreach (Supplier p in suppliers)
            {
                if (String.Equals(p.get_supplierName(), name))
                    return p;
            }
            return null;
        }



        // initalizing customer from sql
        public static void init_customers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            customers = new List<Customer>();

            while (rdr.Read())
            {
                Gender gender = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(3).ToString());
                Customer cu = new Customer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), gender, rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), DateTime.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), false);
                customers.Add(cu);
            }
        }


        // initalizing employees from sql
        public static void init_employees()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            employees = new List<Employee>();

            while (rdr.Read())
            {
                Role role = (Role)Enum.Parse(typeof(Role), rdr.GetValue(9).ToString());
                Gender gender = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(10).ToString());
                Employee e = new Employee(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), DateTime.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), role, gender);
                employees.Add(e);
            }
        }


        public static void init_Supplier()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Suppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            suppliers = new List<Supplier>();

            while (rdr.Read())
            {
                Supplier s = new Supplier(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), false);
                suppliers.Add(s);
            }
        }

        // initalizing products from sql
        public static void init_Products()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Products";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            products = new List<Product>();

            while (rdr.Read())
            {
                ProductCategory pc = (ProductCategory)Enum.Parse(typeof(ProductCategory), rdr.GetValue(5).ToString());
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), Program.seekSupplier(int.Parse(rdr.GetValue(2).ToString())), double.Parse(rdr.GetValue(3).ToString()), double.Parse(rdr.GetValue(4).ToString()), pc, rdr.GetValue(6).ToString(), int.Parse(rdr.GetValue(7).ToString()), int.Parse(rdr.GetValue(8).ToString()), int.Parse(rdr.GetValue(9).ToString()), int.Parse(rdr.GetValue(10).ToString()), 0, false);
                products.Add(p);
            }
        }


        // initalizing orders from sql
        public static void init_ordersFromSupplier()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Orders_From_Supplier";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            ordersFromSuppliers = new List<OrderFromSupplier>();

            while (rdr.Read())
            {
                PaymentMethod pm = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), rdr.GetValue(4).ToString());
                OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(5).ToString());
                OrderFromSupplier ofs = new OrderFromSupplier(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), pm, os, seekEmployee(int.Parse(rdr.GetValue(6).ToString())), seekSupplier(int.Parse(rdr.GetValue(7).ToString())), rdr.GetValue(8).ToString(), false);
                ordersFromSuppliers.Add(ofs);
            }
        }


        public static void init_PromoCodes()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_PromoCodes";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            promoCodes = new List<PromoCodes>();

            while (rdr.Read())
            {
                PromoCodes pc = new PromoCodes(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), DateTime.Parse(rdr.GetValue(4).ToString()), false);
                promoCodes.Add(pc);
            }
        }


        public static void init_Purchases()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Purchases";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            purchases = new List<Purchase>();

            while (rdr.Read())
            {
                PaymentMethod pm = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), rdr.GetValue(5).ToString());
                PromoCodes pc = seekPromoCode(rdr.GetValue(6).ToString());
                Purchase pu = new Purchase(int.Parse(rdr.GetValue(0).ToString()), double.Parse(rdr.GetValue(1).ToString()), seekEmployee(int.Parse(rdr.GetValue(2).ToString())), seekCustomer(int.Parse(rdr.GetValue(3).ToString())), DateTime.Parse(rdr.GetValue(4).ToString()), pm, pc, false);
                purchases.Add(pu);
            }
        }


        public static void init_ProductsInOrder()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Products_In_Supplier_Order";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            productsInOrder = new List<ProductInOrder>();

            while (rdr.Read())
            {
                ProductInOrder pio = new ProductInOrder(seekProduct(rdr.GetValue(1).ToString()), seekOrder_From_Supplier(int.Parse(rdr.GetValue(0).ToString())), int.Parse(rdr.GetValue(2).ToString()), false);
                productsInOrder.Add(pio);
            }
        }


        public static void init_Product_In_Purchases()//init  data from sql
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Products_In_Purchases";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            productsInPurchase = new List<ProductInPurchases>();

            while (rdr.Read())
            {

                ProductInPurchases proipur = new ProductInPurchases(seekPurchases(int.Parse(rdr.GetValue(0).ToString())), seekProduct(rdr.GetValue(1).ToString()), int.Parse(rdr.GetValue(2).ToString()), false);
                productsInPurchase.Add(proipur);
            }
        }


        public static void init_Courses()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Courses";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Shorashim_Courses = new List<ShorashimCourse>();

            while (rdr.Read())
            {

                ShorashimCourse cou = new ShorashimCourse(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), int.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), false);
                Shorashim_Courses.Add(cou);
            }
        }
        public static void init_Product_In_Courses()//init  data from sql
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Products_In_Courses";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Products_In_Course = new List<ProductInCourse>();

            while (rdr.Read())
            {

                ProductInCourse proipCo = new ProductInCourse(seekCourse(rdr.GetValue(0).ToString()), seekProduct((rdr.GetValue(1).ToString())), int.Parse(rdr.GetValue(2).ToString()), false);
                Products_In_Course.Add(proipCo);
            }

           
        }


        public static void init_Customer_In_Courses()//init  data from sql
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Customers_In_Courses";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Customers_In_Course = new List<CustomerInCourse>();

            while (rdr.Read())
            {
          
                
                CustomerInCourse CusiCou = new CustomerInCourse( seekCourse(rdr.GetValue(0).ToString()), seekCustomer(int.Parse(rdr.GetValue(1).ToString())), false);
                Customers_In_Course.Add(CusiCou);
            }
        }

        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();

            
            Application.Run(new Login_Screen());
            


        }
    }
}
