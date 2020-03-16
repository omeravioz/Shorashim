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
   
    public partial class AddCustomerToCourse : Form
    {

        int EID;
        int CustomersinCourse;
        int MaxCustomes = 20;
        public AddCustomerToCourse(int eid)
        {
            InitializeComponent();
            GetCourses();
            this.EID = eid;
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void CN_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ShorashimCourse SC in Program.Shorashim_Courses)
            {
                if (SC.get_CourseName().Equals(CN.Text))
                {
                    DateTime.Text = SC.get_CourseDateTime().ToString();
                    CustomersinCourse = SC.get_customersInThisCourse().Count;
                }


            }



            ShorashimCourse SC1 = Program.seekCourseByName(CN.Text);

            DescrriptionBox.Text = SC1.get_Description() + Environment.NewLine  + "Location:" + SC1.get_location();

        }

        private void CID_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTime_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetCourses()     
        {
            List<string> names = new List<string>();

            foreach (ShorashimCourse SC in Program.Shorashim_Courses)
            {
                names.Add(SC.get_CourseName());
            }
            CN.DataSource = names;
        }

        private Boolean IDCustomer()
        {
            foreach (Customer C in Program.customers)
            {
              if(C.get_customerID()== Int32.Parse(CID.Text))
                {
                    return true;
                }
              
            }
            return false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int value;
            ShorashimCourse SC = GetSC();
          if( int.TryParse(CID.Text, out value) == false || string.IsNullOrWhiteSpace(CID.Text)|| IDCustomer() == false)
                MessageBox.Show(" Please enter right CustomerID", "Error", MessageBoxButtons.OK);
          else if(MaxCustomes< CustomersinCourse)
                MessageBox.Show(" this curse is full. please try another course", "Error", MessageBoxButtons.OK);
            else
            {

                

                string data1 = string.Empty;
                string data2 = string.Empty;
                bool isExist = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)    ///check if already exists - only 1 register of a person to same course !!
                {

                    data1 = Convert.ToString(row.Cells[0].Value);
                    data2 = Convert.ToString(row.Cells[1].Value);
                    if (Equals(CID.Text, data1) == true && Equals(CN.SelectedValue, data2) == true)
                    {
                        isExist = true;
                    }

                }


                if (isExist == false)
                {
                    dataGridView1.Rows.Add(CID.Text, CN.Text, DateTime.Text, SC.get_participantPrice());
                }
                else
                {
                    MessageBox.Show(" You already registered this person to this course!", "Invaild Input", MessageBoxButtons.OK);
                }

               
            }

        }

        private ShorashimCourse GetSC()
        {
            foreach (ShorashimCourse SC in Program.Shorashim_Courses)
            {
                if (SC.get_CourseName().Equals(CN.Text)) {
                    return SC;
                }
            

            }
              
             return null;
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;


                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {              
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void AddCustomerToCourse_Load(object sender, EventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {

            this.Close();
            CoursesManagement New_CBM = new CoursesManagement(EID);
            New_CBM.Enabled = true;//maybe not needed
            New_CBM.Show();


        }

        private void Submit_Click(object sender, EventArgs e)
        {

            //Customer C = Program.seekCustomer(Convert.ToInt32(CID.Text));
            //ShorashimCourse sc = Program.seekCourse(this.courseNumber1);


            string data = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                data = Convert.ToString(row.Cells[1].Value);
                int customer1 = Convert.ToInt32(row.Cells[0].Value);

                Customer chosenCustomer = Program.seekCustomer(customer1);
                ShorashimCourse chosenCourse = Program.seekCourseByName(data);


                if (chosenCustomer != null && chosenCourse != null)
                {

                    CustomerInCourse NewCIC = new CustomerInCourse(chosenCourse, chosenCustomer, true);

                }


            }




            //EMAIL HERE
        



            this.Close();
            Main_Menu mainMenu1 = new Main_Menu(EID);
            mainMenu1.Enabled = true;
            mainMenu1.Show();


            foreach (ShorashimCourse o in Program.Shorashim_Courses)  //check of hahalot - products of every order
            {
                o.printAllcustomersInThisCourse();
            }

            foreach (Customer c in Program.customers)    //check of hahalot - orders of this product
            {

                Console.WriteLine("printing CustomersInCourse lists of Customers");
                c.printAllCustomersInCourse();

            }


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DescrriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


    }
