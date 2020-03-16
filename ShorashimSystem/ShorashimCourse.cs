using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ShorashimSystem
{

    class ShorashimCourse
    {

        private string courseNumber;
        private string courseName;
        private DateTime courseDateTime;
        private string courseLecturerName;
        private string LecturerPhone;
        private int participantPrice;
        private int costToCompany;
        private string courseLocation;
        private string courseDescription;


        public System.Collections.Generic.List<CustomerInCourse> customersInThisCourse;
        public System.Collections.Generic.List<ProductInCourse> productsInThisCourse;

        public ShorashimCourse(string courseNumber, string courseName, DateTime courseDateTime, string courseLecturerName, string LecturerPhone, int participantPrice, int costToCompany, string location, string Description, bool is_new)
        {
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.courseDateTime = courseDateTime;
            this.courseLecturerName = courseLecturerName;
            this.LecturerPhone = LecturerPhone;
            this.participantPrice = participantPrice;
            this.costToCompany = costToCompany;
            this.courseLocation = location;
            this.courseDescription = Description;

            this.productsInThisCourse = new List<ProductInCourse>();
            this.customersInThisCourse = new List<CustomerInCourse>();

            if (is_new)
            {
                this.create_Course(); // new data to sql
                Program.Shorashim_Courses.Add(this); // add to courses list in program
            }

        }


        public void printAllcustomersInThisCourse()
        {
            foreach (CustomerInCourse pip in this.customersInThisCourse)
            {
                Console.WriteLine(pip.get_course().get_Coursenumber() + " " + pip.get_cust().get_customerID());
            }
        }

        public void printAllthisProductsInCourses()
        {
            foreach (ProductInCourse pip in this.productsInThisCourse)
            {
                Console.WriteLine(pip.get_course().get_Coursenumber() + " " + pip.get_product().get_productID() + " " + pip.get_quantity());
            }
        }





        public string get_CourseName()
        {
            return this.courseName;
        }
        public string get_Coursenumber()
        {
            return this.courseNumber;
        }

        public DateTime get_CourseDateTime()
        {
            return this.courseDateTime;
        }

        public string get_courseLecturerName()
        {
            return this.courseLecturerName;
        }

        public string get_LecturerPhone()
        {
            return this.LecturerPhone;
        }

        public int get_participantPrice()
        {
            return this.participantPrice;
        }

        public int get_costToCompany()
        {
            return this.costToCompany;
        }

        public string get_location()
        {

            return this.courseLocation;
        }

        public string get_Description()
        {
            return this.courseDescription;
        }

        public List<CustomerInCourse> get_customersInThisCourse()
        {
            return this.customersInThisCourse;
        }

        public List<ProductInCourse> get_ProductsInThisCourse()
        {
            return this.productsInThisCourse;
        }




        public void addCustomerToCourse(CustomerInCourse cic1)
        {
            if (cic1.get_course().get_Coursenumber() == this.courseNumber)
            {

                this.customersInThisCourse.Add(cic1);

            }

        }

        public void addProductsToCourse(ProductInCourse pic1)
        {

            this.productsInThisCourse.Add(pic1);



        }


        public void printCourseDetails()
        {
            Console.WriteLine(this.courseNumber + " " + this.courseName + " " + this.courseDateTime + " " + this.courseLecturerName + " " + this.LecturerPhone + " " + this.participantPrice + " " + this.costToCompany + " " + this.courseLocation + " " + this.courseDescription);
        }

        public void Set_CourseDescription(string value)
        {
            this.courseDescription = value;
        }



        //CRU FUNCTIONS:

        public void create_Course()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Course  @Course_Number, @Course_Name, @Course_Date_Time, @Course_Lecturer_Name, @Course_Lecturer_Phone, @Participant_Price, @Cost_To_Company, @Curse_Location, @Curse_Description ";
            c.Parameters.AddWithValue("@Course_Number", this.courseNumber);
            c.Parameters.AddWithValue("@Course_Name", this.courseName);
            c.Parameters.AddWithValue("@Course_Date_Time", this.courseDateTime);
            c.Parameters.AddWithValue("@Course_Lecturer_Name", this.courseLecturerName);
            c.Parameters.AddWithValue("@Course_Lecturer_Phone", this.LecturerPhone);
            c.Parameters.AddWithValue("@Participant_Price", this.participantPrice);
            c.Parameters.AddWithValue("@Cost_To_Company", this.costToCompany);
            c.Parameters.AddWithValue("@Curse_Location", this.courseLocation);
            c.Parameters.AddWithValue("@Curse_Description", this.courseDescription);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Course()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Course  @Course_Number, @Course_Name, @Course_Date_Time, @Course_Lecturer_Name, @Course_Lecturer_Phone, @Participant_Price, @Cost_To_Company, @Curse_Location, @Curse_Description ";
            c.Parameters.AddWithValue("@Course_Number", this.courseNumber);
            c.Parameters.AddWithValue("@Course_Name", this.courseName);
            c.Parameters.AddWithValue("@Course_Date_Time", this.courseDateTime);
            c.Parameters.AddWithValue("@Course_Lecturer_Name", this.courseLecturerName);
            c.Parameters.AddWithValue("@Course_Lecturer_Phone", this.LecturerPhone);
            c.Parameters.AddWithValue("@Participant_Price", this.participantPrice);
            c.Parameters.AddWithValue("@Cost_To_Company", this.costToCompany);
            c.Parameters.AddWithValue("@Curse_Location", this.courseLocation);
            c.Parameters.AddWithValue("@Curse_Description", this.courseDescription);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }

}

