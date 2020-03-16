using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShorashimSystem
{
    class CustomerInCourse
    {
        private ShorashimCourse course;
        private Customer customer;



        public CustomerInCourse(ShorashimCourse course1, Customer customer1, bool is_new)
        {
            this.course = course1; //הכלה
            this.customer = customer1; // הכלה
            this.course.addCustomerToCourse(this);
            this.customer.addCustomerToCourse(this);


            if (is_new)
            {
                this.createCustomerInCourse();
            }

        }



        public ShorashimCourse get_course()
        {
            return this.course;
        }
        public Customer get_cust()
        {
            return this.customer;
        }





        public void createCustomerInCourse()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_CUSTOMERS_In_Course @Course_Number, @Customer_ID";
            c.Parameters.AddWithValue("@Course_Number", this.course.get_Coursenumber());
            c.Parameters.AddWithValue("@Customer_ID", this.customer.get_customerID());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
