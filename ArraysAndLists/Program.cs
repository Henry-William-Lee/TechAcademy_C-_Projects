using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {

           //integer array
            int[] numArray = new int[5];
            numArray[0] = 6;
            numArray[1] = 21;
            numArray[2] = 42;
            numArray[3] = 300;
            numArray[4] = 50000;
           
            //function used to pick the number in the array. 
            Console.WriteLine("Pick an index between 0 and 4.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer >= 0 && answer <= 4)
            {
                Console.WriteLine("item chosen at index " + numArray[answer]);
            }
            else 
            {
                Console.WriteLine("You did not pick the right number!");
            }


            List<string> intList = new List<string>();
            intList.Add("G'Day");
            intList.Add("Mate");
            intList.Add("How");
            intList.Add("Are");
            intList.Add("You");
            intList.Add("Today?");


            Console.WriteLine("Pick an index between 0 and 5.");
            int answers = Convert.ToInt32 (Console.ReadLine());

            if (answers >= 0 && answers <= 5)
            {
                Console.WriteLine("item chosen at index = " + intList[answers]);
            }
            else
            {
                Console.WriteLine("You did not pick the right number!");
            }

            Console.ReadLine();
        }

    }
 }
