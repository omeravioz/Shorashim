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
    public partial class InsertProductButton : Form
    {
        int EID;
        public InsertProductButton(int eid)
        {
            InitializeComponent();
          
            this.Donebutton.BackColor = Color.LightGreen;
            this.ReturnToManagementCoursebutton.BackColor = Color.Plum;
            courseDateTimeInput.MinDate = DateTime.Now.AddDays(1);
            //courseDateTimeInput.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            this.EID = eid;




        }

        public string get_CourseNumber()
        {
            return this.courseNumberInput.Text;
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



       

        private void Donebutton_Click(object sender, EventArgs e)
        {
            int value;
            var list = new string[] { CourseNameInput.Text, LecturerNameInput.Text ,LecturerNameInput.Text, participantPrice.Text, LocationBox.Text, courseDescriptionInput.Text };
            string v ="";
        

            if (int.TryParse(courseNumberInput.Text, out value) == false) // Dont Continue if null or String
            {
                MessageBox.Show(" Please enter a vaild ID Course!", "Numbers Only", MessageBoxButtons.OK);
                courseNumberInput.Clear();
            }

        


            else if (int.TryParse(participantPriceInput.Text, out value) == false ||  Int32.Parse(participantPriceInput.Text) <= 0 ) // Dont Continue if null or String
            {
                MessageBox.Show(" Please enter a vaild Participant Price", "Numbers Only", MessageBoxButtons.OK);
                courseNumberInput.Clear();
            }



            else if (list.Contains(v))
            {
                MessageBox.Show(" Please enter a values in all fields", "Error", MessageBoxButtons.OK);
               
            }
           

            else if(Program.seekCourse(courseNumberInput.Text.ToString())==null)// that a new course
            {

                DateTime Date = Convert.ToDateTime(courseDateTimeInput.Value, CultureInfo.InvariantCulture);
                ShorashimCourse cou = new ShorashimCourse(courseNumberInput.Text.ToString(), CourseNameInput.Text.ToString(), Date, LecturerNameInput.Text.ToString(), LecturerPhoneInput.Text.ToString(), int.Parse(participantPriceInput.Text.ToString()), 300, LocationBox.Text.ToString(), courseDescriptionInput.Text.ToString(), true);

                
                InsertProductsToCourse New_page = new InsertProductsToCourse(this.courseNumberInput.Text , EID);
                New_page.Enabled = true;//maybe not needed
                New_page.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("הקורס קיים במערכת", "המשך", MessageBoxButtons.OK);
            }
                

           
        }

        private void ReturnToManagementCoursebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            CoursesManagement New_page = new CoursesManagement(EID);
            New_page.Enabled = true;//maybe not needed
            New_page.Show();
           
        }

        private void InsertProductButton_Load(object sender, EventArgs e)
        {

        }

        private void courseNumberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LecturerPhoneInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseDateTimeInput_ValueChanged(object sender, EventArgs e)
        {

        }

 

        private void LocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

