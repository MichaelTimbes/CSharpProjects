using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment07
{
    public partial class TuitionCalc : Form
    {
        public string student_id;
        public string student_name;
        public bool is_resident;
        public const double RESIDENT_RATE = 300;
        public const double NONRESIDENT_RATE = 800;
        public double tuition { set; get; }
        public int hours;

        public TuitionCalc()
        {
            InitializeComponent();
        }

        private void STUDENT_ID_TEXTBOX_TextChanged(object sender, EventArgs e)
        {
            student_id = STUDENT_ID_TEXTBOX.ToString();
        }

        private void STUDENT_NAME_TEXTBOX_TextChanged(object sender, EventArgs e)
        {
            student_name = STUDENT_NAME_TEXTBOX.ToString();
        }

        private void CREDITS_TEXTBOX_TextChanged(object sender, EventArgs e)
        {
            hours = int.Parse(CREDITS_TEXTBOX.Text);
        }

        private void RESIDENT_RADIO_BUTTON_CheckedChanged(object sender, EventArgs e)
        {
            is_resident = true;
        }

        private void NON_RESIDENT_RADIO_BUTTON_CheckedChanged(object sender, EventArgs e)
        {
            is_resident = false;
        }
        private void TUITION_TEXTBOX_TextChanged(object sender, EventArgs e) {


        }

        private void CALC_BUTTON_Click(object sender, EventArgs e)
        {
            string message;
            if (is_resident == true)
            {
                tuition = hours * RESIDENT_RATE;
                message = tuition.ToString();
                TUITION_TEXTBOX.Text = message;
            }
            else if (is_resident == false)
            {

                tuition = hours * NONRESIDENT_RATE;
                message = tuition.ToString();
                TUITION_TEXTBOX.Text = message;

            }
            else {
                TUITION_TEXTBOX.Text = "Can not calculate.";


            }
        }
    }
}
