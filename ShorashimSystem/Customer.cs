using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ShorashimSystem
{
    class Customer
    {

        private int customerID;
        private string customerFirstName;
        private string customerLastName;
        private Gender customerGender;
        private string customerPhone;
        private string customerEmail;
        private DateTime customerBirthDate;
        private string customerAddress;
        private string customerMemberClub;

        public System.Collections.Generic.List<Purchase> CustomersPurchases;
        public System.Collections.Generic.List<CustomerInCourse> customerCourses;

        public Customer(int ID, string firstName, string lastName, Gender gender, string phone, string Email, DateTime birthDate, string address, string customerMemberClub, bool is_new)
        {
            this.customerID = ID;
            this.customerFirstName = firstName;
            this.customerLastName = lastName;
            this.customerGender = gender;
            this.customerPhone = "972-" + phone;
            this.customerEmail = Email;
            this.customerBirthDate = birthDate;
            this.customerAddress = address;
            this.customerMemberClub = customerMemberClub;
            this.CustomersPurchases = new List<Purchase>();
            this.customerCourses = new List<CustomerInCourse>();

            if (is_new)
            {
                this.createCustomer();
                Program.customers.Add(this);
            }

        }


        public void printAllCustomersInCourse()
        {
            foreach (CustomerInCourse cic in this.customerCourses)
            {
                Console.WriteLine(cic.get_course().get_Coursenumber() + " " + cic.get_cust().get_customerID());
            }
        }

        public void printAllPurchases()
        {
            foreach (Purchase i in this.CustomersPurchases)
            {
                Console.WriteLine(i.getID() + "  " + i.getPrice() + " " + i.get_purchcaseEmployeeID() + " " + i.get_purchcaseCustomerID() + " " + i.getDateOfPurchase() + " " + i.getPaymentMethod() + " " + i.get_purchasePromoCodeName());
            }
        }

        public int get_customerID()
        {
            return this.customerID;
        }

        public String get_CustomerFirstName()
        {
            return this.customerFirstName;
        }

        public String get_CustomerLastName()
        {
            return this.customerLastName;
        }

        public String get_Email()
        {
            return this.customerEmail;
        }

        public String getCustomePhone()
        {
            return this.customerPhone;
        }

        public String getCustomerAddress()
        {
            return this.customerAddress;
        }

        public void set_customerID(int value)
        {
            this.customerID = value;
        }

        public Gender getCustomeGendr()
        {
            return this.customerGender;
        }

        public DateTime getBirthDate()
        {
            return this.customerBirthDate;
        }
        public string get_CustomerMember()
        {
            return this.customerMemberClub;
        }

        public void addCustomerToCourse(CustomerInCourse cic1)
        {
            if (cic1.get_cust().get_customerID() == this.customerID)
            {
                this.customerCourses.Add(cic1);
            }
        }

        public void printCustomerDetails()
        {
            Console.WriteLine(this.customerID + " " + this.customerFirstName + " " + this.customerLastName + " " + this.customerPhone);
        }



        public void createCustomer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Customer @Customer_ID, @Customer_FirstName, @Customer_LastName, @Customer_Gender, @Customer_Phone, @Customer_Email, @Customer_Birth_Date, @Customer_Address, @Customer_Member_Club";
            c.Parameters.AddWithValue("@Customer_ID", this.customerID);
            c.Parameters.AddWithValue("@Customer_FirstName", this.customerFirstName);
            c.Parameters.AddWithValue("@Customer_LastName", this.customerLastName);
            c.Parameters.AddWithValue("@Customer_Gender", this.customerGender.ToString());
            c.Parameters.AddWithValue("@Customer_Phone", this.customerPhone);
            c.Parameters.AddWithValue("@Customer_Email", this.customerEmail);
            c.Parameters.AddWithValue("@Customer_Birth_Date", this.customerBirthDate);
            c.Parameters.AddWithValue("@Customer_Address", this.customerAddress);
            c.Parameters.AddWithValue("@Customer_Member_Club", this.customerMemberClub);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }







    }
}
