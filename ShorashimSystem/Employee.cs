using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ShorashimSystem
{
    class Employee
    {


        private int employeeID;
        private string employeeFirstName;
        private string employeeLastName;
        private string employeePhone;
        private string employeeEmail;
        private DateTime employeeBirthDate;
        private DateTime employeeStartWorkDate;
        private string employeeAddress;
        private string employeePassword;
        private Role employeeRole;
        private Gender employeeGender;
        public System.Collections.Generic.List<OrderFromSupplier> ordersFromSuppliers; //הכלה
        public System.Collections.Generic.List<Purchase> purchasesToCustomers; //הכלה

        public Employee(int ID, string firstname, string lastname, string phone, string Email, DateTime birthDate, DateTime StartWorkDate, string address, string password, Role role, Gender gender)
        {
            this.employeeFirstName = firstname;
            this.employeeLastName = lastname;
            this.employeeID = ID;
            this.employeePhone = phone;
            this.employeeEmail = Email;
            this.employeeBirthDate = birthDate;
            this.employeeStartWorkDate = StartWorkDate;
            this.employeeAddress = address;
            this.employeePassword = password;
            this.employeeRole = role;
            this.employeeGender = gender;
            ordersFromSuppliers = new List<OrderFromSupplier>(); //הכלה
            purchasesToCustomers = new List<Purchase>(); //הכלה


        }

        public void printAllOrdersOfEmployee()
        {
            foreach (OrderFromSupplier i in this.ordersFromSuppliers)
            {
                Console.WriteLine(i.getID() + " " + i.getDateOfOrder() + " " + i.getDueDateOfOrder() + " " + i.getTotalPrice() + " " + i.getPaymentMethod() + " " + i.getOrderStatus() + " " + i.getOrderEmployee().get_employeeID() + " " + i.getOrderSupplier().get_supplierID() + " " + i.getDescription());
            }
        }

        public void printAllPurchasesOfEmployee()
        {
            foreach (Purchase i in this.purchasesToCustomers)
            {
                Console.WriteLine(i.getID() + "  " + i.getPrice() + " " + i.get_purchcaseEmployeeID() + " " + i.get_purchcaseCustomerID() + " " + i.getDateOfPurchase() + " " + i.getPaymentMethod() + " " + i.get_purchasePromoCodeName());
            }
        }


        public int get_employeeID()
        {
            return this.employeeID;
        }

        public String get_employeePassword()
        {
            return this.employeePassword;
        }

        public String get_employeeFirstName()
        {
            return this.employeeFirstName;
        }
        public String get_employeeLastName()
        {
            return this.employeeLastName;
        }

        public String get_employeePhone()
        {
            return this.employeePhone;
        }

        public String get_employeeEmail()
        {
            return this.employeeEmail;
        }
        public DateTime get_employeeBirthDate()
        {
            return this.employeeBirthDate;
        }

        public DateTime get_employeeStartWorkDate()
        {
            return this.employeeStartWorkDate;
        }
        public String get_employeeAddress()
        {
            return this.employeeAddress;
        }

        public Role get_employeeRole()
        {
            return this.employeeRole;
        }
        public Gender get_employeeGender()
        {
            return this.employeeGender;
        }
    }
}
