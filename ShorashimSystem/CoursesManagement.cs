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
    public partial class CoursesManagement : Form
    {

        int EMP_ID;
        public CoursesManagement(int EMP_ID)
        {
            InitializeComponent();
            this.EMP_ID = EMP_ID;
        }

        private void AddNewCoursebutton_Click(object sender, EventArgs e)
        {
            InsertProductButton AddNewCourse = new InsertProductButton(EMP_ID); // Tipos wrong. need to be AddNewCourses
            AddNewCourse.Enabled = true;
            AddNewCourse.ShowDialog();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddCustomerToCourse New_CBM = new AddCustomerToCourse(EMP_ID);
            New_CBM.Enabled = true;//maybe not needed
            New_CBM.ShowDialog();
            this.Hide();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu New_MM = new Main_Menu(EMP_ID);
            New_MM.Enabled = true;
            New_MM.Show();
        }
    }
}
 