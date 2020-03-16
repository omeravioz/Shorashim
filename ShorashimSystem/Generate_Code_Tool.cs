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
    public partial class Generate_Code_Tool : Form
    {
        private object random;
        PromotionByMailing pbm1;

        public Generate_Code_Tool(PromotionByMailing pbm)
        {
            InitializeComponent();
            DescrriptionBox.ReadOnly = true;
            DescrriptionBox.Enabled = false;
            this.pbm1 = pbm;
           
        }

        private void Generate_Code_Tool_Load(object sender, EventArgs e)
        {

        }

        private void GenerateCode_Button_Click(object sender, EventArgs e)
        {
            DescrriptionBox.Text = RandomString(8);
        }

        private void DescrriptionBox_TextChanged(object sender, EventArgs e)
        {

        }


        private readonly Random _rng = new Random();
        private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private string RandomString(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = _chars[_rng.Next(_chars.Length)];
            }
            return new string(buffer);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Value, CultureInfo.InvariantCulture);
            string promo1 = DescrriptionBox.Text;
            string percent = PERCENTBOX.Text;
            double convertedPer = 0;
            int value;
            if (PERCENTBOX.Text != "" && int.TryParse(PERCENTBOX.Text, out value) == true) {
                convertedPer = Convert.ToDouble(percent, CultureInfo.InvariantCulture);
            }
            string description = textBox1.Text;
           
            if (DateTime.Compare(DateTime.Now, date1)>=0 )
            {
                MessageBox.Show(" You muse choose a date after today!.", "Wrong Input", MessageBoxButtons.OK);

            }
            else if(int.TryParse(PERCENTBOX.Text, out value) == false) {

                MessageBox.Show(" You muse choose a Numeric Number !", "Wrong Input", MessageBoxButtons.OK);
            }
            else if (DescrriptionBox.Text=="")
            {

                MessageBox.Show(" Please Generate a new code !", "Wrong Input", MessageBoxButtons.OK);
            }
            else
            {
               
                PromoCodes newpc = new PromoCodes(promo1, description, DateTime.Now, convertedPer, date1, true);

                pbm1.Fill_combo_box();
                this.Close();
            }


            

        }

        private void IDtextbook_TextChanged(object sender, EventArgs e)
        {

        }

        private void PERCENTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void PromoGeneratorLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




