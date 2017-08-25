/*************************************** 
 By: Michael Timbes
 Class: 2080-W1
 Date: 9/13/2015
 Purpose:
    This assignmnet asks me to write a small console application to read an employee name and week sales then 
 to calculate, as well as output line by line, the various deductions with two final lines outputting the total  
 deductions, and the last line to be the total gross pay. 
 Compiler Used: Visual Studios 2015 .NET v 4.5.2
 */




using System;
using static System.Console;

namespace CsharpAssignmnet02MichaelTimbes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Declaration of tax rates used:
            const double FEDTAX = 0.18;
            const double RETIRECONTR = 0.15;
            const double SOCIALSEC = 0.09;
            double commissionr = 0.07;
            //Declaration of variables used:
            string emplyname;
            string inpt;
            double weeksales;
            double deductions= 0;
            Write("Enter Employee Name: ");
            emplyname = ReadLine();
            Write("Enter Weekly Sales: ");
            inpt = ReadLine();
            //experimenting with the parse function
            weeksales = double.Parse(inpt);
            WriteLine();
            WriteLine("     Weekly Payroll App ");
            WriteLine("Employee Name: {0:G}", emplyname);
            WriteLine("Comission Rate: {0,10:F3}", commissionr);
            WriteLine();
            WriteLine("This Week's Slaes:{0,25:C}", weeksales);
            WriteLine("Gross Pay: {0,32:C}", grosspay(weeksales, commissionr));
            //Example of using a function to write a line and using pass by reference in C#
            rtax(weeksales, FEDTAX,commissionr, ref deductions);
            stax(weeksales,SOCIALSEC,commissionr,ref deductions);
            retire(weeksales, RETIRECONTR, commissionr, ref deductions);
            WriteLine();
            WriteLine("Total Deductions: {0,25:C}", deductions);
            WriteLine();
            WriteLine("Total Pay: {0,32:C}", grosspay(weeksales, commissionr)-deductions);
            ReadKey();
        }
        //Writes the line needed for the federal tax deductions
        static void rtax(double weeksales,double Ftax,double commr,ref double deductions) {
            
           //Example of nested function calling
            WriteLine("Federal Taxes Witheld:< {0:P} >{1,10:C2}" ,Ftax, grosspay(weeksales,commr)*Ftax);
            deductions = grosspay(weeksales, commr) * Ftax;
        }
        //Writes line for Social Security
        static void stax(double weeksales, double socurity, double commr,ref double deductions)
        {
            
            WriteLine("Social Security Witheld:< {0:P} >{1,9:C2}", socurity, grosspay(weeksales, commr) * socurity);
           deductions += grosspay(weeksales, commr) * socurity;
        } //Function to write retire
        static void retire(double weeksales, double rtirerate, double commr, ref double deductions)
        {

            WriteLine("Retirement Contribution:< {0:P} >{1,8:C2}", rtirerate, grosspay(weeksales, commr) * rtirerate);
            deductions += grosspay(weeksales, commr) * rtirerate;
        }
        //Calculate the gross pay. It is noted that the out parameter could have been used as well.B
        static double grosspay(double weeklypay,double commr) {
            //Example of return statement witin function
            return (weeklypay* commr);

    }
}
}
