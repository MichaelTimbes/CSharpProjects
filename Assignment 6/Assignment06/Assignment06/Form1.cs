using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment06
{
    public partial class InAddMul : Form
    {
        private int num2;
        private int num1;
        private int result;
        public InAddMul()
        {
          
            InitializeComponent();
        }

        private void Instructions_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void In_Num1_txt(object sender, EventArgs e)
        {
           
            int.TryParse(In_1.Text, out num1);
        }

        private void In_Num2_txt(object sender, EventArgs e)
        {
           
            int.TryParse(In_2.Text, out num2);
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
           
           result=  num2 + num1;
            string output;
            output = result.ToString();
            Out_Put.Show();
            Out_Put.Text = string.Format("Result: {0}", output);
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            result = num1 * num2;
            string output;
            output = result.ToString();
            Out_Put.Show();
            Out_Put.Text = string.Format("Result: {0}", output);
        }

        private void Out_Put_TextChanged(object sender, EventArgs e)
        {
            
                
            
        }
    }
}
