using System;

namespace BranchingSubmissionAssignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package express!");

            // ask for the measurements of the package and convert them to data to be used. 

            Console.WriteLine("What is the weight of your package?");

            int pkgWht = Convert.ToInt32(Console.ReadLine());

            if (pkgWht > 50)
            {
                Console.Write("Your package is too heavy. ");
            }

            else if (pkgWht < 50)
           { 
                Console.WriteLine("What is the height of your package?");
                int pkgHt = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length of your package?");
                int pkgLen = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the width of your package?");
                int pkgWdth = Convert.ToInt32(Console.ReadLine());

                int pckgttl = pkgWdth + pkgHt + pkgHt;

                if (pckgttl > 50)
                {
                    Console.WriteLine("Your package is too large.");
                }

                else if (pckgttl < 50)

                {
                    double pckttl2 = pkgHt * pkgLen * pkgWdth;

                    // pkg ttl 2 * pkg weight
                    double pckttl3 = pckttl2 * pkgWht;

                    //package weight * pkg height * pck width * pkg length / 100

                    decimal pckttl4 = Convert.ToDecimal(pckttl3);
                    decimal pckttl5 = pckttl4 / 100;
                    Console.WriteLine("Your total is $" + pckttl5 + ".");
                }
             }











        }
    }
}
