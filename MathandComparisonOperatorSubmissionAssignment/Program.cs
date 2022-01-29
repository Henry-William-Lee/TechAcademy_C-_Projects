using System;

namespace MathandComparisonOperatorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program!");

            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate:");
            int hrlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week: ");
            int hrsPerWk1 = Convert.ToInt32(Console.ReadLine());
            int ttlmny1 = hrlyRate1 * hrsPerWk1;
            int annualSal1 = ttlmny1 * 52;
            Console.WriteLine("Annual Salary of Person 1 is; " + annualSal1);

            //Person 2

            Console.WriteLine("Person 2");
            Console.WriteLine("Enter Hourly Rate:");
            int hrlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week: ");
            int hrsPerWk2 = Convert.ToInt32(Console.ReadLine());
            int ttlmny2 = hrlyRate2 * hrsPerWk2;
            int annualSal2 = ttlmny2 * 52;
            Console.WriteLine("Annual salary of Person 2: " + annualSal2);

            bool makemore = annualSal1 > annualSal2;

            Console.WriteLine("Does Person 1 make more money than Person 2?" + makemore);








        }
    }
}
