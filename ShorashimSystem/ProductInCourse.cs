using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ShorashimSystem
{
    class ProductInCourse
    {
        private Product product;
        private ShorashimCourse course;
        private int quantity;

        public ProductInCourse(ShorashimCourse course, Product product, int quantity, bool is_new)
        {
            this.product = product; // הכלה
            this.course = course; //הכלה
            this.quantity = quantity;
            this.course.addProductsToCourse(this);
            this.product.addProductToCourse(this);
            if (is_new)
            {
                this.createProductInCourse();
            }

        }

        public ShorashimCourse get_course()
        {
            return this.course;
        }
        public Product get_product()
        {
            return this.product;
        }

        public int get_quantity()
        {
            return this.quantity;
        }


        public void printProductDetails()
        {

            Console.WriteLine(this.product.get_productID() + " " + this.product.get_productName() + " " + this.product.get_productSupplierID() + " " + this.product.getSupplierPrice() + " " + this.product.getSalePrice() + " " + this.product.get_productCategory() + " " + this.product.get_Description() + " " + this.product.get_productQuantity() + " " + this.product.get_productLowerBound(), this.product.get_shelfNum(), this.product.get_closetNum());
        }
        public void printCourseDetails()
        {
            Console.WriteLine(this.course.get_Coursenumber() + " " + this.course.get_CourseName() + " " + this.course.get_CourseDateTime() + " " + this.course.get_courseLecturerName() + " " + this.course.get_LecturerPhone() + " " + this.course.get_participantPrice() + " " + this.course.get_costToCompany() + " " + this.course.get_location() + " " + this.course.get_Description());
        }

        public void printQuantity()
        {
            Console.WriteLine(this.quantity);
        }

        public void createProductInCourse()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Products_In_Courses @Course_Number, @Product_ID, @Quantity";
            c.Parameters.AddWithValue("@Course_Number", this.course.get_Coursenumber());
            c.Parameters.AddWithValue("@Product_ID", this.product.get_productID());
            c.Parameters.AddWithValue("@Quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }



    }
}
