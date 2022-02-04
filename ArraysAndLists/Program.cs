using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {

            List<string> intList = new List<string>();
            intList.Add("G'Day");
            intList.Add("Mate");
            intList.Remove("Mate");

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            int[] numArray = new int[5];
            numArray[0] = 6;
            numArray[1] = 21;
            numArray[2] = 42;
            numArray[3] = 300;
            numArray[4] = 50000;
           
            Console.WriteLine("Pick a number from the list: \n 6 \n 21 \n 42 \n 300 \n 50000. ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer != numArray[0] || answer != numArray[1] || answer != numArray[2] || answer != numArray[3] || answer != numArray[4])
            {
                Console.WriteLine("You did not pick the right number!");
            }
            else (answer == numArray[0] || answer == numArray[1] || answer == numArray[2] || answer == numArray[3] || answer == numArray[4])
            {
                Console.WriteLine("You did not pick the right number!");
            }


            Console.ReadLine();
        }

    }
 }
