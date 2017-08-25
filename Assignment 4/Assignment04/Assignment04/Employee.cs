using System;
using static System.Console;
//Inheritance and Polymorphism FTW!
namespace Assignment04
{
    public class Employee
    {
        //Public member variables
            //Constant Vals
        public const double FED_TAX_RATE = 0.18;
        public const double SS_TAX_RATE = .06;
        public const double RET_CONTRIBUTION = .10;
        //Variables
        protected string lastname;
        protected string firstname;
        protected string empID;
        protected string type_pay;
        protected double gross_pay;
        protected double takehome_pay;
        protected double totededuct;
        protected double fed_tax_paid;
        protected double ret_contr_paid;
        protected double ss_paid;
        protected double total_deductions;
        protected double takehomepay;

        //Constructors
        public  Employee() { } //Default
        //Properties
        protected string LastName { set { lastname = value; } get { return lastname; } }
        protected string FirstName { set { firstname = value; } get { return firstname; } }
        protected string EmpId { set { empID = value; } get { return empID; } }
        protected double Gross_Pay { set { gross_pay = value; } get { return gross_pay; } }
        protected double Fed_Tax_Paid { set { fed_tax_paid = value; } get { return fed_tax_paid; } }
        protected double Ret_Contr_Paid { set { ret_contr_paid = value; } get { return ret_contr_paid; } }
        protected double SS_Paid  { set { ss_paid = value; } get { return ss_paid ; } }
        protected double Total_Deductions { set { total_deductions = value; } get { return total_deductions; } }
        protected double Take_Home_Pay { set { takehomepay = value; } get { return takehomepay; } }
        public string Type_Pay { set { type_pay = value; } get { return type_pay; } }
        public void Calc_Pay(double inpay)
        {
            
            //Send it to the base class Gross_Pay
            Gross_Pay = (inpay);
            //Create a Federal Tax deduction variable
            double FtaxDeduct = inpay * FED_TAX_RATE;
            //Set the base class value
            Fed_Tax_Paid = FtaxDeduct;
            //Create a social security deduction variable
            double SSDeduct = inpay * SS_TAX_RATE;
            //Set the base class value
            SS_Paid = SSDeduct;
            //Create a contribution deduction variable
            double RtireDeduct = inpay * RET_CONTRIBUTION;
            //Set the base class value
            Ret_Contr_Paid = RtireDeduct;
            //Just For ease of reading- create a seperate total deduction val instead of an outside function
            Total_Deductions = (FtaxDeduct + RtireDeduct + SSDeduct);
            //Total take home pay is the total hour pay - all the deductions
            Take_Home_Pay = (inpay - Total_Deductions);
        }
        public override string ToString()
        {
            WriteLine("Weekly Information for:{0} {1}",firstname,lastname);
            WriteLine("Employee ID: {0}", EmpId);
            WriteLine("Gross Pay: {0,10:C}", Gross_Pay);
            WriteLine("Federal Tax Paid: {0,10:C}", Fed_Tax_Paid);
            WriteLine("Social Security Paid: {0,10:C}", SS_Paid);
            WriteLine("Retirement Contribution: {0,10:C}", Ret_Contr_Paid);
            WriteLine("Total Deductions: {0,10:C}", Total_Deductions);
            WriteLine();
            WriteLine("Total Take Home Pay: {0,10:C}", Take_Home_Pay);
            return base.ToString();
        }


    }
    public class HourlyEmp : Employee {
        protected double hours;
        protected double hour_rate;
       
        protected double Hours { set { hours = value; } get { return hours; } }
        protected double Hour_Rate { set { hour_rate = value; } get { return hour_rate; } }
        //Default Constructor
       public  HourlyEmp() { }
        //Default Args are included in constructor        
        public HourlyEmp(double Time=0, double Pay=0, string ID="A", string Fname="John",string Lname = "Doe") {
            hours = Time;
            hour_rate = Pay;
            EmpId = ID;
            FirstName = Fname;
            LastName = Lname;
            Type_Pay = "Hourly";
        }
            //Based on hours and hourly rate calcs all finanical info needed for this type of empoyee
           public void Calc_Hourly_Pay() { 
           double tmp =  hours* hour_rate;
              base.Calc_Pay(tmp);
                    }
    }
    public class SalaryEmp : Employee {
        protected double gross_salary;
        protected double Gross_Salary { set { gross_salary = value; } get { return gross_salary; } }
        //Default Constructor 
        public SalaryEmp() { }
        //Constructor with args
        public SalaryEmp(double Pay = 0, string ID = "A", string Fname = "John", string Lname = "Doe") {
            Gross_Salary = Pay;
            EmpId = ID;
            FirstName = Fname;
            LastName = Lname;
            Type_Pay = "Salary";
        }
        void Calc_Salary_Pay() {
            base.Calc_Pay(gross_salary);
        }
        
    }
}
