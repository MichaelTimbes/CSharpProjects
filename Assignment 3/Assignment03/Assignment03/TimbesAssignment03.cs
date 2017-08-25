/*
 Michael Timbes
 Assignment-03 2080
 Date: 09/21/2016
 Compiler C# via Visual Studios 2015 (v140) .NET45 
 
 Purpose:
 This assignment's purpose is to use a calss in C# and to practice: declaring member variables of different access types,
 member properties using set and get, member methods, and implement overloaded functions. 
 */

using System;
using static System.Console;
using System.Text;

namespace Assignment03
{
    public class Park {
        //Member variables declared with repective types
        private string parkname, parklocation, parktype,parkfacilities;
        private int  num_employees, num_visitors;
        //Fee per customer, the budget for the park, the revenue per year, the costs per year
        private double entrancefee, budget,revenue,costs;

        /*These are the Properties:*/
        public double EntranceFee
        {
            get { return entrancefee; }
            set { entrancefee = value; }
        }
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public int Num_Employees
        {
            get { return num_employees; }
            set { num_employees = value; }
        }
        public int Num_Visitors
        {
            get { return num_visitors; }
            set { num_visitors = value; }
        }
        public string ParkName
        {
            get { return parkname; }
            set { parkname = value; }
        }
        public string ParkLocation
        {
            get { return parklocation; }
            set { parklocation = value; }
        }
        public string ParkType
        { get
            { return parktype; }
            set { parktype = value; }
        }
        public string ParkFacilities
        {
            get { return parkfacilities; }
            set { parkfacilities = value; }

        }
        /*These are the Acessors*/
        //a) return a string representing name of the park, the location and type of park.
        public string get_name_location_type(){
            string returninfo;
            //Set up return string
            returninfo = "Park Information: \n";
            returninfo +="Park Name: " + parkname + "\n";
            returninfo +="Park Location: " + parklocation + "\n";
            returninfo +="Park Type: " + parktype + "\n";
            //Return Resulting String
            return returninfo;


        }
        //b) return a string representing the name of the park, the location and facilities available.
        public string get_name_location_facilities()
        {   string returninfo;
            //Set up return string
            returninfo = "Park Information: \n";
            returninfo += "Park Name: " + parkname + "\n";
            returninfo += "Park Location: " + parklocation + "\n";
            returninfo += "Park Facilities: " + parkfacilities + "\n";
            //Return Resulting String
            return returninfo;
        }


        /*These are methods to calculate member variables:*/
        //c) compute cost per visitor based on annual budget and the number of visitors during the last 12 months.
        public double cost_per_visitor()
        {
            //Just to be more realistic- two tier salary for employees
            double salaryI = 30000;
            double salaryII = 60000;
            double employeecost = ((.5 * num_employees) * salaryI) + ((.5 * num_employees) * salaryII);
            costs  = (((budget + employeecost) / ((double) num_visitors))); //Have to cast to preserve int data type
            return costs;
        }
        //d) compute revenue from fees for the past year based on number of visitors and fee.
        public double rev_per_year() {
            //Earnings - Costs
            revenue = (num_visitors * entrancefee) - costs;
            return revenue;
        }
        /*Default Constructor- No arguments but default values are given to some member variables*/
        public Park()
        {
            //Default Values of 1 are given to avoid accidental divide by zero error
            num_employees = 1;
            num_visitors = 1;
            entrancefee = 0;
            revenue = 0;
            costs = 0;
            budget = 1;
        }
        /*This is the override ToString() implementation*/

        //e)Also include a ToString() method that returns all data members with appropriate labels.
        public override string ToString()
        {
            string returninfo="";
            //Set up return string
            returninfo += "Park Name: " + parkname + "\n";
            returninfo += "Park Location: " + parklocation + "\n";
            returninfo += "Park Type: " + parktype + "\n";
            returninfo += "Park Facilities: " + parkfacilities + "\n";
            returninfo += "Entrance Fee: " + entrancefee.ToString( "C");
            returninfo += "\nNumber of Employees: " + Num_Employees.ToString("N");
            returninfo += "\nNumber of Visitors Last Year: " + Num_Visitors.ToString("N");
            returninfo += "\nAnnual Buget for the Park: " + budget.ToString("C");
            returninfo += "\nRevenue from Entrance Fee: " + rev_per_year().ToString("C");
            returninfo += "\nCosts Per Visitor: " + cost_per_visitor().ToString("C");
            return returninfo;
        }



    }
    class TimbesAssignment03
    {
        static void Main(string[] args)
        {
            Park First = new Park();
            //Define Each Variable:

            First.ParkName = "Clear Waters";
            First.ParkFacilities = "Camping, Hiking, Boating";
            First.ParkLocation = "Parkview,Oregon";
            First.ParkType = "National";
            First.Budget = 750000;
            First.Num_Employees = 500;
            First.Num_Visitors = 1000000;
            First.EntranceFee = 15;
            First.rev_per_year();
            First.cost_per_visitor();
            First.get_name_location_facilities();
            First.get_name_location_type();
            Write(First.ToString());
            Console.ReadLine();
        }
    }
}
