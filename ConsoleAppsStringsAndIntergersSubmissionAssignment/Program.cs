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


            try
            {
                
                Console.WriteLine("Write a number to divide the list by. ");

                int dividedBy = Convert.ToInt32(Console.ReadLine());

                foreach (int i in firstlist)
                {
                    Console.WriteLine( i / dividedBy);
                }
            }
             

            catch (FormatException y)

            {
                Console.WriteLine(y.Message);
                return;
            }

            catch (DivideByZeroException z)

            {
                Console.WriteLine(z.Message);
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
