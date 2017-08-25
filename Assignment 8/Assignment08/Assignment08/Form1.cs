using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Assignment08
{
    public partial class App : Form
    {
        private StreamWriter fil;
        private StreamReader InFile;
        bool IFisopen = false,OFisopen=false;
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            try {
                fil = new StreamWriter("empdata.txt");
                OFisopen = true;
            }
            catch (System.IO.IOException exc) {
                lblMessage.Text = exc.Message;
                lblMessage.Show();
            }
                       
        }
        private void STORE_DATA_BUTTON_Click(object sender, EventArgs e)
        {
            if (OFisopen == false)
            {
                try
                {
                    fil = new StreamWriter("empdata.txt");
                    OFisopen = true;
                }
                catch (System.IO.IOException exc)
                {
                    lblMessage.Text = exc.Message;
                    lblMessage.Show();
                }
            }
            double pay=0, hours=0, wage=0;
            
            //Parse input, then calculate pay
            try
            {
               
                double.TryParse(PAY_RATE_VAL.Text, out pay);
                double.TryParse(HOURS_VAL.Text, out hours);
                wage = pay * hours;

            }
            catch {
                lblMessage.Text = "Cannot convert pay or hours to numbers.";
                lblMessage.Show();

            }
            fil.WriteLine("{0} ID:{1} {2:C} ",NAME_VAL.Text,NUMBER_VAL.Text,wage);
            lblMessage.Text = NAME_VAL.Text+" written to file";
            lblMessage.Show();
            NAME_VAL.Text = "";
            HOURS_VAL.Text = "";
            PAY_RATE_VAL.Text = "";
            NUMBER_VAL.Text = "";
        }
        private void RETRIEVE_DATA_BUTTON_Click(object sender, EventArgs e)
        {
            STORE_DATA_BUTTON.Enabled = false;
            lblMessage.Text = "File is Read Only..";
            lblMessage.Show();
            if (OFisopen == true)
            {
                try
                {
                    fil.Close();
                  
                }
                catch
                {
                    lblMessage.Text = "File did not close properly.";
                }
            }
            string inValue;
            if (File.Exists("empdata.txt"))
            {
                try
                {
                    InFile = new StreamReader("empdata.txt");
                    while ((inValue = InFile.ReadLine()) != null)
                    {
                        this.OUTPUT_BOX.AppendText(inValue+"\n");

                    }
                    IFisopen = true;
                }
                catch (System.IO.IOException exc)
                {
                    lblMessage.Text = exc.Message;
                    lblMessage.Show();

                }
            }
            OFisopen = false;
        }

        private void App_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OFisopen == true)
            {
                try
                {
                    fil.Close();
                }
                catch
                {
                    lblMessage.Text = "File did not close properly.";
                }
            }
            if (IFisopen)
            {
                try
                {
                    InFile.Close();
                }
                catch
                {
                    lblMessage.Text = "File did not close properly.";
                }
            }
        }

       
    }
}
