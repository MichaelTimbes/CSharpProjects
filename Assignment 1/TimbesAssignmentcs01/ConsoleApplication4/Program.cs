using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication4
{
    class Assignmet01
    {
        static void Main(string[] args)
        {
            double price=150; //100 bars*$1.50
            int boxes=29; //Amount Sold-given
            double rev=(boxes*price); //Total revenue
            double costs = boxes * 100; //Total Cost of product
            double SGAF = (rev-costs)*.1; //(Revenue - Bars Cost) - SGA Fee or 90% of total profit is kept
            WriteLine("Cases Sold:{0,15:F0} ",boxes);
            WriteLine("Gross Sales:{0,14:C2}",rev);
            WriteLine("Product Costs:{0,12:C2}", costs);
            WriteLine("SGA Fee:{0,18:C2}",SGAF);


        }
    }
}
