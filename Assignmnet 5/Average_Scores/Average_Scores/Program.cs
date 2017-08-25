using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Average_Scores
{
    class Program
    {
        static public double avg(double[] arr,int i)
        {
            double average=0;
            foreach (double val in arr) { average += val; }
            return (average / i);

        }
        static public char get_grade(double average) {
            if (average <= 100 & average >= 90) { return 'A'; }
            else if (average <= 89 & average >= 80) { return 'B'; }
            else if (average <= 79 & average >= 70) { return 'C'; }
            else if (average <= 69 & average >= 60) { return 'D'; }
            else { return 'F'; }

        }

        static void Main(string[] args)
        {
            WriteLine("**** You will be prompted to enter scores ranging from 0 to 100. ***");
            WriteLine("**** The scores entered will be averaged and then assigned a letter grade. ***");
            WriteLine("**** The results will be displayed and you can repeat as many times as needed. ***");
            ReadKey();
            string cont = "Y";
            while (cont == "Y") {
                double score = 1;
                double result;
                double[] scores = new double [100];
                string input;
                char grade;
                int i=0;
                //While the scores are greater than or equal to zero- continue to read the scores.
                WriteLine("Begin");
                do
                {
                   
                    //Display instructions and add it to the mass input (tote_input)
                    WriteLine("Please enter a score 0-100.");
                    WriteLine("Enter a number LESS than 0 to STOP entering scores: ");
                    input = ReadLine();
                    score = double.Parse(input);
                    if (score >= 0)
                    {
                        scores[i] = score; i++;
                    } 
                   // WriteLine("Score: {0}", score);
                    
                   
                   
                } while ( (score >= 0));
                result= avg(scores, i);
                grade = get_grade(result);
                WriteLine("The average of the {0} scores entered is {1:f2}",i, result);
                WriteLine("The assigned letter grade is {0}", grade);
                WriteLine("Would you like to enter another set of scores?");
                cont = ReadLine();
            }
            
        }
    }
}
