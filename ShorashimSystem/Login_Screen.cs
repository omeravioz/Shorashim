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
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();
     

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

   
        private void ID_LABEL_Click(object sender, EventArgs e)
        {

        }

        private void ID_TEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }   

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int value;
            if(int.TryParse(ID_TEXTBOX.Text, out value) == false) // Dont Continue if null or String
            {
                MessageBox.Show(" Please enter a vaild ID!", "Invaild Input", MessageBoxButtons.OK);
                ID_TEXTBOX.Clear();
            }
            else { 


            Employee emp = Program.seekEmployee(int.Parse(ID_TEXTBOX.Text));
            if (emp == null)
            {
                MessageBox.Show(" employee ID is not exists!", "Wrong Input", MessageBoxButtons.OK);
                ID_TEXTBOX.Clear();
            }
            else //valid input
            {
                if (emp.get_employeePassword() != PasswordTextBox.Text)
                {
                    MessageBox.Show(" Password incorrect! please", "Wrong Input", MessageBoxButtons.OK);
                    PasswordTextBox.Clear();
                }
                else
                {
                        Main_Menu New_MM = new Main_Menu(emp.get_employeeID());
                        New_MM.Enabled = true;//maybe not needed
                        New_MM.Show();
                        this.Hide();

                  

           
                    }

            }
            }
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DayLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            DayLabel.Text = DateTime.Now.ToString("dddd" + "  dd MMMM yyyy");
        }
    }
}
