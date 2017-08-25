/* CalculatePayByEmployType
 *  * This classes tests the Employee
 * class by instantiating objects of the class. It also
 * tests for type of employee and allows users to
 * input values based on the type of employee.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePayByEmployType
{
    class Program
    {
        static void Main(string[] args)
        {
            string anEmployeeFirstName,
                   anEmployeeLastName,
                   employeeID,
                   typeOfEmployee;
            double grossSalariedWages = 0,
                   rateOfPay = 0,
                   hours = 0;
            DisplayInstructions();
            anEmployeeFirstName = GetInfo("an employee first name");
            anEmployeeLastName = GetInfo("an employee last name");
            employeeID = GetInfo("the employee identification number");
            typeOfEmployee = GetTypeOfEmployee();
            if (typeOfEmployee == "Salaried")
                grossSalariedWages = GetGrossPay();
            else
            {
                hours = GetHours( );
                rateOfPay = GetRate( );
            }

            Employee oneEmployee = new Employee(employeeID, anEmployeeLastName, anEmployeeFirstName, 
                                                    typeOfEmployee);
            if (typeOfEmployee == "Salaried")
                oneEmployee.GrossSalariedAmount = grossSalariedWages;
            else
            {
                oneEmployee.HoursForHourlyEmployee = hours;
                oneEmployee.RateForHourlyEmployee = rateOfPay;
            }

            DisplayResults(oneEmployee);

            Console.WriteLine("Press any key to see the next test...");
            Console.ReadKey();

            Console.Clear();
            Employee secondEmployee = new Employee("00987", "Hitower", "Alma");
            secondEmployee.TypeWage = "Salaried";
            secondEmployee.GrossSalariedAmount = 5000.00;
            Console.WriteLine("\tSecond Test\n\n");
            Console.WriteLine(secondEmployee);
            Console.ReadKey();
        }

        public static void DisplayInstructions()
        {
            Console.Write("You will be asked to enter the name of an employee" +
                "\nand the type of employee (Hourly or Salaried). " +
                "\n\nCalculations will be performed to " +
                "\ndetermine his/her deductions and take home pay.\n\n");
            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();
            Console.Clear();
        }

        public static string GetInfo(string info)
        {
            Console.Write("Please enter {0}: ", info);
            return (Console.ReadLine());
        }

		public static string GetTypeOfEmployee( )
		{
			string inputValue,
                   empType;

			Console.Write("\nPlease enter an S for salaried employee, \n" +
				            "or an H for hourly employee: ");
			inputValue = Console.ReadLine();
			switch(inputValue )
			{
				case "s":
                case "S": empType = "Salaried";
					break;
				case "h":
                case "H": empType = "Hourly";
					break;
                default: empType = "unknown";
					break;
			}
            return empType;
		}

		public static double GetGrossPay( )
		{
            double gross;
			Console.Write( "\nPlease enter weekly salary: ");
			if (double.TryParse(Console.ReadLine( ), out gross) == false)	
                Console.WriteLine("Invalid Data entered - 0 recorded for gross");
            return gross;
		}

        public static double GetHours( )
		{
            double hours;
			Console.Write( "\nPlease enter hours for the week: ");
			if (double.TryParse(Console.ReadLine( ), out hours) == false)	
                Console.WriteLine("Invalid Data entered - 0 recorded for hours");
            return hours;
		}


        public static double GetRate( )
		{
            double rate;
			Console.Write( "\nPlease enter hourly pay rate: ");
			if (double.TryParse(Console.ReadLine( ), out rate) == false)	
                Console.WriteLine("Invalid Data entered - 0 recorded for rate");
            return rate;
		}


		public static void DisplayResults(Employee person )
		{
            Console.Clear();
            Console.WriteLine("Weekly information for {0} {1}", person.EmployeeFirstName, person.EmployeeLastName);
            Console.WriteLine();
            Console.WriteLine("{0,-25} {1,12:C}",
                "Employee ID: ", person.EmployeeID);
            Console.WriteLine("{0,-25} {1,12:C}",
                "Gross pay: ", person.CalculateGrossPay( ));
            Console.WriteLine("{0,-25} {1,12:C}",
                "Federal tax paid: ", person.CalculateFedTaxPaid());
            Console.WriteLine("{0,-25} {1,12:C}",
                "Social security paid: ", person.CalculateSocSecPaid());
            Console.WriteLine("{0,-25} {1,12:C}",
                "Retirement contribution: ", person.CalculateRetirementPaid());
            Console.WriteLine("{0,-25} {1,12:C}",
                "Total deductions: ", person.CalculateTotalDeductions());
            Console.WriteLine();
            Console.WriteLine("{0,-25} {1,12:C}",
                "Take home pay: ", person.CalculateTakeHomePay());
		  }
        }
    }