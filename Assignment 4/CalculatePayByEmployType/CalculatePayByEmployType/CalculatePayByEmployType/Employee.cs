/*Employee.cs
 * This class includes data members for name, employee type
 * and pay. Methods are defined to calculate deductions and
 * overall take home pay for each employee
 * object instantiated in another class.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePayByEmployType
{
    class Employee
    {
        private const double FED_TAX_RATE = 0.18;
        private const double RETIREMENT_CONTR = 0.10;
        private const double SOC_SEC_TAX_RATE = 0.06;

        private string employeeLastName;
        private string employeeFirstName;
        private string employeeID;
        private string typeWage;
        private double grossSalariedAmount;
        private double hoursForHourlyEmployee;
        private double rateForHourlyEmployee;

        public Employee()
        {
        }

        public Employee(string id, string last, string first, string wageType, double hours, double rate)
        { 
            employeeID = id;
            employeeLastName = last;
            employeeFirstName = first;
            typeWage = wageType;
            hoursForHourlyEmployee = hours;
            rateForHourlyEmployee = rate;
        }

        public Employee(string id,  double hours, double rate)
        {
            employeeID = id;
            hoursForHourlyEmployee = hours;
            rateForHourlyEmployee = rate;
        }

        public Employee(string id, string last, string first, string wageType)
        {
            employeeID = id;
            employeeLastName = last;
            employeeFirstName = first;
            typeWage = wageType;
        }

        public Employee(string id, string last, string first, string wageType, double grossPayForSalariedEmp)
        {
            employeeID = id;
            employeeLastName = last;
            employeeFirstName = first;
            typeWage = wageType;
            grossSalariedAmount = grossPayForSalariedEmp;
        }

        public Employee(string id, string last, string first)
        {
            employeeID = id;
            employeeLastName = last;
            employeeFirstName = first;
        }

        public Employee(string id, string wageType, double grossPayForSalariedEmp)
        {
            employeeID = id;
            typeWage = wageType;
            grossSalariedAmount = grossPayForSalariedEmp;
        }

        public Employee(string id, string wageType)
        {
            employeeID = id;
            typeWage = wageType;
        }
        //Property definitions
        public string EmployeeFirstName
        {
            get
            {
                return employeeFirstName;
            }
            set
            {
                employeeFirstName = value;
            }
        }

        public string EmployeeLastName
        {
            get
            {
                return employeeLastName;
            }
            set
            {
                employeeLastName = value;
            }
        }

        public string EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string TypeWage
        {
            get
            {
                return typeWage;
            }
            set
            {
                typeWage = value;
            }
        }

        public double GrossSalariedAmount
        {
            get
            {
                return grossSalariedAmount;
            }
            set
            {
                grossSalariedAmount = value;

            }
        }

        public double HoursForHourlyEmployee
        {
            get
            {
                return hoursForHourlyEmployee;
            }
            set
            {
                hoursForHourlyEmployee= value;

            }
        }

        public double RateForHourlyEmployee
        {
            get
            {
                return rateForHourlyEmployee;
            }
            set
            {
                rateForHourlyEmployee = value;

            }
        }

        public double CalculateGrossPay()
        {
            double gross;

            if (typeWage == "Salaried")
                gross = grossSalariedAmount;
            else
                if (hoursForHourlyEmployee > 40) //For overtime
                    gross = rateForHourlyEmployee * 40 + 1.5 * rateForHourlyEmployee * (hoursForHourlyEmployee - 40);
                else
                    gross = rateForHourlyEmployee * hoursForHourlyEmployee;
            return gross;
        }
        
        public double CalculateFedTaxPaid()
        {
            return CalculateGrossPay() * FED_TAX_RATE;
        }

        public double CalculateSocSecPaid()
        {
            return CalculateGrossPay() * SOC_SEC_TAX_RATE;
        }

        public double CalculateRetirementPaid()
        {
            return CalculateGrossPay() * RETIREMENT_CONTR;
        }

        public double CalculateTotalDeductions()
        {
            return CalculateFedTaxPaid() + CalculateSocSecPaid() + CalculateRetirementPaid();
        }

        public double CalculateTakeHomePay()
        {
            return CalculateGrossPay() - CalculateTotalDeductions();
        }

        public override string ToString()
        {
            return "Name: " + employeeFirstName + " " + employeeLastName  +
                "\nEmployee ID: " + employeeID +
                "\nEmployee Type: " + typeWage +
                "\nGross Pay: " + CalculateGrossPay().ToString("C") +
                "\nFed. Taxes: " + CalculateFedTaxPaid().ToString("C") +
                "\nSoc. Sec.: " + CalculateSocSecPaid().ToString("C") +
                "\nRetirement: " + CalculateRetirementPaid().ToString("C") +
                "\n\nTotal Deductions: " + CalculateTotalDeductions().ToString("C") +
                "\nTake home pay: " + CalculateTakeHomePay().ToString("C");
        }
    }
}
