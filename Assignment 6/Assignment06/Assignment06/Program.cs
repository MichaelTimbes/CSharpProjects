using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment06
{
    static class Program
    {
        /// <summary>
       /*
        Assignment 5 in C# class. 
        -Windows application that contains two textboxes and two buttons
        -The textboxes should be used to allow the user to input two numeric value
        -The buttons should be labeled "Add" and "Multiply"
        - Create event-handler methods that retrieve the values, perform the calculations, 
        and display the result of the calculations on a label
        -The label should initially be set to be invisible. Additional labels will be needed for the textboxes caption
  
         *AutoResize property of the Label to False so that it can be resized   to display text on multiple lines
             
        */
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InAddMul());
           
        }
    }
}
