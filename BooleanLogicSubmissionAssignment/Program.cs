using System;

namespace BooleanLogicSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for client age and prints it. 
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? You must say true or false.");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());

            bool qualified = age > 15 && dui == false && ticket < 3;
            Console.WriteLine(qualified);


        }
    }
}
