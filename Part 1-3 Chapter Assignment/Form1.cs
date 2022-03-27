using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_3_Chapter_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            string height = txtHeight.Text;

            int age1 = Convert.ToInt32(age);
            int averageAge = 82;
            int ageBelow;
            ageBelow = averageAge - age1;

            double tallest = 2.72;
            double height1;
            double.TryParse(height, out height1);
            double heightBelow;
            heightBelow = tallest - height1;
            heightBelow = Math.Round(heightBelow, 2);

            lblMessage.Text = "Greetings " + name + ". You are " + ageBelow + " years below life expectancy." 
                + " You are " + heightBelow + "m shorter than the tallest person.";
        }
    }
}
