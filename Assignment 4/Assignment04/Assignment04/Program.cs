using System;
using static System.Console;


namespace Assignment04
{
    class Program
    {
        static void instructs()
        {
            WriteLine("You will be asked the employee's first and last name. Then if they are hourly or salary.");
            WriteLine();
            WriteLine("Calculations will be performed to calculate his/her pay.");
            ReadKey();


        }
        static void Main(string[] args)
        {
            string choice, fname, lname, ID,PARIN;
            double hour, hour_rate, salary;
            instructs();
            WriteLine("Please choose 'H' for hourly or 'S' for salary");
            choice = ReadLine();
            if (choice == "H")
            {
                WriteLine("Employee First name: ");
                fname = ReadLine();
                WriteLine("Employee Last name: ");
                lname = ReadLine();
                WriteLine("Enter Employee ID: ");
                ID = ReadLine();
                WriteLine("Please input the number of hours: ");
                PARIN = ReadLine();
                hour = double.Parse(PARIN);
                WriteLine("Please Enter the hourly wage:");
                PARIN = ReadLine();
                hour_rate = double.Parse(PARIN);
                HourlyEmp Q = new HourlyEmp(hour, hour_rate, ID, fname, lname);
                Q.Calc_Hourly_Pay();
                
                Q.ToString();
            }
            else if (choice == "S")
            {

                WriteLine("Employee First name: ");
                fname = ReadLine();
                WriteLine("Employee Last name: ");
                lname = ReadLine();
                WriteLine("Enter Employee ID: ");
                ID = ReadLine();
                WriteLine("Please input the salary: ");
                PARIN = ReadLine();
               salary = double.Parse(PARIN);
               SalaryEmp J = new SalaryEmp(salary, ID, fname, lname);
                J.Calc_Pay(salary);
                J.ToString();
            }
            ReadKey();
        }

    }
}

