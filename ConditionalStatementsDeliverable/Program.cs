using System;

namespace ConditionalStatementsDeliverable
{
    internal class Program
    {    
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your expected grade in ISM4300");
                decimal grade = decimal.Parse(Console.ReadLine());


                if (grade > 89)
                {
                    Console.WriteLine("Your letter grade is A");
                }

                else if ((grade < 90) && (grade > 79))
                {
                    Console.WriteLine("Your letter grade is B");
                }

                else if ((grade < 80) && (grade > 69))
                {
                    Console.WriteLine("Your letter grade is C");
                }

                else if ((grade < 70) && (grade > 59))
                {
                    Console.WriteLine("Your letter grade is D");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Your letter grade is F");
                }
            }
            catch 
            {
                Console.WriteLine("Enter Numeric Value");
            }
            
        }
 
    }
}