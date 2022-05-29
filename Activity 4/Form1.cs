using System;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBT_Click(object sender, EventArgs e)
        {
            NumLBL.Text = "";
            TypeLBL.Text = "";

            int input = -1;
            int.TryParse(InputTB.Text, out input);
         

            if (input >= 86400)
            {
                NumLBL.Text = (input / 86400).ToString();
                TypeLBL.Text = "Days";
            }
            else if (input >= 3600)
            {
                NumLBL.Text = (input / 3600).ToString();
                TypeLBL.Text = "Hours";
            }
            else if (input >= 60)
            {
                NumLBL.Text = (input / 60).ToString();
                TypeLBL.Text = "Minutes";
            }
            else if (input > 0)
            {
                NumLBL.Text = input.ToString();
                TypeLBL.Text = "Seconds";
            }
            else
            {
                TypeLBL.Text = "Please enter a value";
            }
        }
    }
}
