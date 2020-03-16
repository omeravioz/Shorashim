using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ShorashimSystem
{
    class Product : IComparable<Product>
    {


        private string productID;
        private string productName;
        private Supplier productSupplier;
        private double productSupplierPrice;
        private double productSalePrice;
        private ProductCategory productCategory;
        private string productDescription;
        private int productQuantity;
        private int productLowerBound;
        private int closetNum;
        private int shelfNum;
        private int priority;

        public System.Collections.Generic.List<ProductInPurchases> purchasesOfThisProduct; //הכלה
        public System.Collections.Generic.List<ProductInOrder> SupplierOrdersOfThisProduct;
        public System.Collections.Generic.List<ProductInCourse> thisProductsInCourses; //  מוצר בקורס הכלה


        public Product(string ID, string name, Supplier productSupplier, double productSupplierPrice, double productSalePrice, ProductCategory category, string Description, int productQuantity, int productLowerBound, int closetNum, int shelfnum, int priority, bool is_new)
        {
            this.productID = ID;
            this.productName = name;
            this.productSupplier = productSupplier;
            this.productSupplierPrice = productSupplierPrice;
            this.productSalePrice = productSalePrice;
            this.productCategory = category;
            this.productDescription = Description;
            this.productQuantity = productQuantity;
            this.productLowerBound = productLowerBound;
            this.closetNum = closetNum;
            this.shelfNum = shelfnum;
            this.priority = priority;

            this.purchasesOfThisProduct = new List<ProductInPurchases>(); //הכלה
            this.SupplierOrdersOfThisProduct = new List<ProductInOrder>();
            this.thisProductsInCourses = new List<ProductInCourse>();// הכלה




            if (is_new)
            {
                this.create_product();
                Program.products.Add(this);
            }
        }

        public void printAllProductsInPurchases()
        {
            foreach (ProductInPurchases pip in this.purchasesOfThisProduct)
            {
                Console.WriteLine(pip.get_ProductID() + " " + pip.get_PurchaseID() + " " + pip.get_Quantity());
            }
        }

        public void printAllSupplierOrdersOfThisProduct()
        {
            foreach (ProductInOrder i in this.SupplierOrdersOfThisProduct)
            {
                Console.WriteLine(i.get_ProductInOrder().get_productID() + " " + i.getOrderFromSupplier().getID() + " " + i.getQuantity());
            }
        }

        public void printAllthisProductsInCourses()
        {
            foreach (ProductInCourse pip in this.thisProductsInCourses)
            {
                Console.WriteLine(pip.get_course().get_Coursenumber() + " " + pip.get_product().get_productID() + " " + pip.get_quantity());
            }
        }

        //GETTERS:
        public string get_productID()
        {
            return this.productID;
        }

        public string get_productName()
        {
            return this.productName;
        }

        public int get_productSupplierID()
        {
            return this.productSupplier.get_supplierID();
        }

        public double getSupplierPrice()
        {
            return this.productSupplierPrice;
        }

        public int get_closetNum()
        {
            return this.closetNum;
        }
        public int get_shelfNum()
        {
            return this.shelfNum;
        }
        public int getPriority()
        {
            return this.priority;
        }
        public double getSalePrice()
        {
            return this.productSalePrice;
        }



        public ProductCategory get_productCategory()
        {
            return this.productCategory;
        }

        public string get_Description()
        {
            return this.productDescription;
        }

        public int get_productQuantity()
        {
            return this.productQuantity;
        }
        public int get_productLowerBound()
        {
            return this.productLowerBound;
        }

        //SETTERS:

        public void setID(string id)
        {
            this.productID = id; ;
        }

        public void setName(String name)
        {
            this.productName = name;
        }

        public void setSalePrice(Double p)
        {
            this.productSalePrice = p;
        }
        public void setCategory(ProductCategory c)
        {
            this.productCategory = c;
        }


        public void setCloset(int closet)
        {
            this.closetNum = closet;
        }

        public void setShelf(int shelf)
        {
            this.shelfNum = shelf;
        }

        public void setPriority(int quantity)
        {
            this.priority = quantity;
        } // updating priority 

        public void setProductQuantity(int newQuantity)
        {
            this.productQuantity = newQuantity;
        } // updating priority 


        public void addProductsInPurchase(ProductInPurchases pip1)
        {
            this.purchasesOfThisProduct.Add(pip1);
        }

        public void addSupplierOrdersOfThisProduct(ProductInOrder pio1)
        {
            this.SupplierOrdersOfThisProduct.Add(pio1);
        }

        public void addProductToCourse(ProductInCourse pic1)
        {

            this.thisProductsInCourses.Add(pic1);

        }



        public void increasePriority(int quantity)
        {
            this.priority = this.priority + quantity;
        } // updating priority 



        // Compare To function !!!
        public int CompareTo(Product p)
        {
            // A null value means that this object is greater.
            if (p == null)
                return 1;

            else
                return p.getPriority().CompareTo(this.priority);
        }

        public void printProductDetails()
        {
            Console.WriteLine(this.productID + " " + this.productName + " " + this.productCategory + " " + this.productSalePrice+" " + this.productQuantity);
        }





        //CRUD FUNCTIONS:
        public void create_product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Product @Product_ID, @Product_Name, @Product_Supplier, @Product_Supplier_Price,@Product_Sale_Price , @Product_Category, @Product_Description, @Product_Quantity, @Product_Lower_Bound, @Closet_Num, @Shelf_Num";
            c.Parameters.AddWithValue("@Product_ID", this.productID);
            c.Parameters.AddWithValue("@Product_Name", this.productName);
            c.Parameters.AddWithValue("@Product_Supplier", this.productSupplier.get_supplierID());
            c.Parameters.AddWithValue("@Product_Supplier_Price", this.productSupplierPrice);
            c.Parameters.AddWithValue("@Product_Sale_Price", this.productSalePrice);
            c.Parameters.AddWithValue("@Product_Category", this.productCategory.ToString());
            c.Parameters.AddWithValue("@Product_Description", this.productDescription);
            c.Parameters.AddWithValue("@Product_Quantity", this.productQuantity);
            c.Parameters.AddWithValue("@Product_Lower_Bound", this.productLowerBound);
            c.Parameters.AddWithValue("@Closet_Num", this.closetNum);
            c.Parameters.AddWithValue("@Shelf_Num", this.shelfNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Product @Product_ID, @Product_Name, @Product_Supplier, @Product_Supplier_Price,@Product_Sale_Price , @Product_Category, @Product_Description, @Product_Quantity, @Product_Lower_Bound, @Closet_Num, @Shelf_Num";
            c.Parameters.AddWithValue("@Product_ID", this.productID);
            c.Parameters.AddWithValue("@Product_Name", this.productName);
            c.Parameters.AddWithValue("@Product_Supplier", this.productSupplier.get_supplierID());
            c.Parameters.AddWithValue("@Product_Supplier_Price", this.productSupplierPrice);
            c.Parameters.AddWithValue("@Product_Sale_Price", this.productSalePrice);
            c.Parameters.AddWithValue("@Product_Category", this.productCategory.ToString());
            c.Parameters.AddWithValue("@Product_Description", this.productDescription);
            c.Parameters.AddWithValue("@Product_Quantity", this.productQuantity);
            c.Parameters.AddWithValue("@Product_Lower_Bound", this.productLowerBound);
            c.Parameters.AddWithValue("@Closet_Num", this.closetNum);
            c.Parameters.AddWithValue("@Shelf_Num", this.shelfNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }




    }
}
