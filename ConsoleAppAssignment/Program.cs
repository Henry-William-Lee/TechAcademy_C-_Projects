using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //console assignment 1


            ////create a list of sentences
            //List<string> sentences = new List<string>() { "Hi, ", "My name is ", "I found our boat, ", "Sail ho, ", "You are my friend, ", " Leave her, " };

            ////asks for the user's name
            //Console.WriteLine("Please input your name.");
            //string name = Console.ReadLine();

            //foreach (string sentence in sentences)
            //{
            //    Console.WriteLine(sentence + name + ".");
            //    Console.ReadLine();
            //}




            //Console Assignment 2

            //// Creating infinite loop
            //// Using for loop
            //for (; ; )

            //    // This statement will be printed
            //    // infinite times
            //    Console.WriteLine("What do you do with a drunken sailor?!");

            
           // Console Assignment 3:
           // 
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //console part 4 assignment

            //List<string> sentences2 = new List<string>() { "Hello","Ahoy", "Hello there", "Avast", "Take what you can", " Give nothing back" };
           
            //Console.WriteLine("Pick an item from the list of strings.");
            //string answers = Console.ReadLine();


            //if (sentences2.Contains(answers))
            //{


            //    for (int i = 0; i < sentences2.Count; i++)
            //    {
            //        if (answers == sentences2[i])
            //        {
            //            Console.WriteLine("item chosen at index = " + i);
            //        }
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("You did not chose the correct item.");
            //}

            
            ////console assignment 5
            //      List<string> sentences3 = new List<string>() { "Ahoy", "Ahoy", "Hello there.", "Avast.", "Take what you can.", "Give nothing back." };

            //Console.WriteLine("Pick an item from the list of strings.");
            //string answers2 = Console.ReadLine();


            //if (sentences3.Contains(answers2))
            //{


            //    for (int i = 0; i < sentences3.Count; i++)
            //    {
            //        if (answers2 == sentences3[i])
            //        {
            //            Console.WriteLine("item chosen at index = " + i + " " + sentences3[i]);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You did not chose the correct item.");
            //}

            // Assignment 6


            List<string> sentences4 = new List<string>() { "Ahoy", "Avast.", "Hello there.", "Avast.", "Take what you can.", "Give nothing back." };
            List<string> sentences5 = new List<string>() { };
            
            foreach (string sentence in sentences4)
            {


                if (sentences5.Contains(sentence))
                {
                    Console.WriteLine(sentence + "  This is a duplicate");
                }
                sentences5.Add(sentence);
            }
            {

            }

        }




    }    
}
