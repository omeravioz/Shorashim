using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShorashimSystem
{
    public partial class PromotionByMailing : Form
    {
        int EMP_ID;
        public PromotionByMailing(int EMP_ID)
        {
            InitializeComponent();
            this.EMP_ID = EMP_ID;
            Fill_combo_box();
            DescrriptionBox.ReadOnly = true;
            DescrriptionBox.Enabled = false;

        }

        private void PromotionByMailing_Load(object sender, EventArgs e)
        {

        }

        private void SendPromotionCodeMail_Click(object sender, EventArgs e)
        {
            int value;
            List<String> emailsToSendList = new List<String>();
            if (int.TryParse(IDtextbook.Text, out value) == false && comboBox1.Text == "") // Check Integer or null
            {
                MessageBox.Show(" Please Choose a vaild Id or Targeted Group!", "Invaild Input", MessageBoxButtons.OK);
            }
            else if (int.TryParse(IDtextbook.Text, out value) == true && comboBox1.Text != "") // Check if 2 textbox filled
            {
                MessageBox.Show(" You can't choose both options! Please choose one.", "Wrong Input", MessageBoxButtons.OK);
                IDtextbook.Clear();
                comboBox1.SelectedIndex = -1; // clear combobox
            }
            else if (int.TryParse(IDtextbook.Text, out value) == true && comboBox1.Text == "")   //Specifiec ID
            {
                Customer customer = Program.seekCustomer(int.Parse(IDtextbook.Text));
                if (customer == null)
                {
                    MessageBox.Show(" Customer ID is not exists!", "Wrong Input", MessageBoxButtons.OK); //dont find Specifiec ID
                    IDtextbook.Clear();
                }
                else
                {
                    emailsToSendList.Add(customer.get_Email());




                }

            }
            else//Targeted Group
            {

                emailsToSendList = getEmailsToPromotion(comboBox1.Text);

            }

            if (emailsToSendList.Count() != 0)
            {


                // send email to supplier after creating an order
                MessageBox.Show(" PromoCode " + PromoCodeChooseBox.Text + " was sent to the customer!");

                foreach (String EM in emailsToSendList)//SEND MAILS
                {

                    String messageMail = "Hello " + Program.seekCustomerByEmail(EM).get_CustomerFirstName() + " " + Program.seekCustomerByEmail(EM).get_CustomerLastName() + ",\n" + "You have received a PromoCode: " + PromoCodeChooseBox.Text + "\n" +
                   "The PromoCode Descripion:" + DescrriptionBox.Text + "\n" + "We are looking forward to see you soon at our store " + "\n" + "Thank you!" + "\n" + "Shorashim - Yavne Nature House!";
                    Email.sendingEmail(EM, messageMail);


                }



                this.Close();
                Main_Menu New_MM = new Main_Menu(EMP_ID);
                New_MM.Enabled = true;
                New_MM.Show();


            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu New_MM = new Main_Menu(EMP_ID);
            New_MM.Enabled = true;
            New_MM.Show();


        }

        private void IDtextbook_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void PromoCodeChooseBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            PromoCodes PC_new = Program.seekPromoCode(PromoCodeChooseBox.Text);

            DescrriptionBox.Text = PC_new.getPromoDescription() + Environment.NewLine + Environment.NewLine + "Expired date:" + PC_new.getPromoEndDate();

        }

        public void Fill_combo_box()
        {

            List<string> names = new List<string>();

            foreach (PromoCodes P in Program.promoCodes)
            {
                names.Add(P.getPromoName());
            }

            PromoCodeChooseBox.DataSource = names;
        }

        private void DescrriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        public static List<String> getEmailsToPromotion(string group)
        {


            List<String> emailsList = new List<String>();
            switch (group)
            {
                case "January Birthdays":
                    emailsList = getEmailsByMonth(1);
                    break;
                case "February Birthdays":
                    emailsList = getEmailsByMonth(2);
                    break;
                case "March Birthdays":
                    emailsList = getEmailsByMonth(3);
                    break;
                case "April Birthdays":
                    emailsList = getEmailsByMonth(4);
                    break;
                case "May Birthdays":
                    emailsList = getEmailsByMonth(5);
                    break;
                case "June Birthdays":
                    emailsList = getEmailsByMonth(6);
                    break;
                case "July Birthdays":
                    emailsList = getEmailsByMonth(7);
                    break;
                case "August Birthdays":
                    emailsList = getEmailsByMonth(8);
                    break;
                case "Septemeber Birthdays":
                    emailsList = getEmailsByMonth(9);
                    break;
                case "October Birthdays":
                    emailsList = getEmailsByMonth(10);
                    break;
                case "November Birthdays":
                    emailsList = getEmailsByMonth(11);
                    break;
                case "December Birthdays":
                    emailsList = getEmailsByMonth(12);
                    break;

                case "Gold Club":
                    emailsList = getEmailsByMembership("GOLD");
                    break;
                case "Silver Club":
                    emailsList = getEmailsByMembership("SILVER");
                    break;
                case "Black Club":
                    emailsList = getEmailsByMembership("BLACK");
                    break;

                case "ALL Customers":
                    emailsList = getAllEmails();
                    break;

                default:
                    break;

            }


            return emailsList;
        }


        public static List<String> getAllEmails()
        {
            List<String> emailsList = new List<String>();

            foreach (Customer c in Program.customers)
            {
                emailsList.Add(c.get_Email());
            }

            return emailsList;
        }



        public static List<string> getEmailsByMembership(string membership)
        {
            List<string> emailsList = new List<string>();

            foreach (Customer c in Program.customers)
            {
                if (String.Equals(membership, c.get_CustomerMember()))
                    emailsList.Add(c.get_Email());
            }

            return emailsList;
        }



        public static List<String> getEmailsByMonth(int Month)
        {
            List<String> emailsList = new List<String>();

            foreach (Customer c in Program.customers)
            {
                if (c.getBirthDate().Month == Month)
                    emailsList.Add(c.get_Email());
            }

            return emailsList;

        }

        private void GenerateCode_Button_Click(object sender, EventArgs e)
        {

            
            Generate_Code_Tool New_GC = new Generate_Code_Tool(this);
            New_GC.ShowDialog();
            

        }
    }


}






