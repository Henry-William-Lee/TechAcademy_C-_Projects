using System;
using System.Collections.Generic;



namespace ConsoleAppsStringsAndIntergersSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstlist = new List<int>();

            // adding elements in firstlist
            firstlist.Add(8);
            firstlist.Add(36);
            firstlist.Add(47);
            firstlist.Add(21);
            firstlist.Add(47);
            firstlist.Add(23);
            firstlist.Add(58);
            firstlist.Add(61);


            Console.WriteLine("Write a number to divide the list by. ");

            int dividedBy = Convert.ToInt32(Console.ReadLine());

            try {

                int i = 0; i < firstlist.Count; i++;
                 Console.WriteLine(firstlist[i] / dividedBy);
                
            }
             

            catch (FormatException)

            {
                Console.WriteLine("Please type a whole number.");
                return;
            }

            catch (DivideByZeroException)

            {
                Console.WriteLine("Please don't divide by  zero.");
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
