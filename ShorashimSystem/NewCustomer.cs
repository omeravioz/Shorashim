using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace ShorashimSystem
{
    public partial class NewCustomerPage : Form
    {
        public NewCustomerPage()
        {
            InitializeComponent();
            Gender.DataSource = Enum.GetValues(typeof(Gender));
            MemberClub.Text = "Black";
            MemberClub.Enabled = false;
        }

        private void NewCustomerPage_Load(object sender, EventArgs e)
        {

        }

        private void Main_Label_Click(object sender, EventArgs e)
        {

        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Save_Click(object sender, EventArgs e)
        {
            int value;

            if (CustomerID.Text == "" || (int.TryParse(CustomerID.Text, out value)) == false)
                MessageBox.Show(" Please enter correct id !", "Invaild Input", MessageBoxButtons.OK);

            else if (IDCustomer() == true)
                MessageBox.Show(" The Customer Alerady exists!", "Invaild Input", MessageBoxButtons.OK);

            else if (FirstName.Text == "" || (int.TryParse(FirstName.Text, out value)))
                 MessageBox.Show(" Please enter correct first name", "Invaild Input", MessageBoxButtons.OK);

            else if(LastName.Text == "" || (int.TryParse(LastName.Text, out value)))
                 MessageBox.Show(" Please enter correct last name", "Invaild Input", MessageBoxButtons.OK);

            else if (Phone.Text == null || (int.TryParse(Phone.Text, out value))==false)
                MessageBox.Show(" Please enter only digits", "Invaild Input", MessageBoxButtons.OK);

            else if (IsValidEmail(Email.Text) == false)
                MessageBox.Show(" Please enter correct Email", "Invaild Input", MessageBoxButtons.OK);

            else if (Address.Text == "")
                MessageBox.Show(" Please enter address", "Invaild Input", MessageBoxButtons.OK);

            
            else
            {
                Customer cust = new Customer(Convert.ToInt32(CustomerID.Text), FirstName.Text, LastName.Text, (Gender)Enum.Parse(typeof(Gender), Gender.Text), Phone.Text, Email.Text, Convert.ToDateTime(dateTimePicker1.Value, CultureInfo.InvariantCulture), Address.Text, "BLACK", true);
                this.Close();
            }

        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void MemberClub_TextChanged(object sender, EventArgs e)
        {

        }


        private Boolean IDCustomer()
        {
            foreach (Customer C in Program.customers)
            {
                if (C.get_customerID() == Int32.Parse(CustomerID.Text))
                {
                    return true;
                }

            }
            return false;
        }
    }
}

