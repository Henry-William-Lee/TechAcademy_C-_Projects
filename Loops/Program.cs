using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your password?");
            string password = Console.ReadLine();
            bool isGuessed = password == "Password";

            do
            {
                switch (password)
                {

                    case "Fido":
                        Console.WriteLine("You guessed Fido. Try again.");
                        Console.WriteLine("Guess your password.");
                        password = Console.ReadLine();
                        break;


                    case "Cujo":
                        Console.WriteLine("You guessed Cujo. Try again.");
                        Console.WriteLine("Guess your password.");
                        password = Console.ReadLine();
                        break;

                    case "Scooby Doo":
                        Console.WriteLine("You guessed Scooby Doo. Try again.");
                        Console.WriteLine("Guess your password.");
                        password = Console.ReadLine();
                        break;


                    case "Password":
                        Console.WriteLine("You guessed \"Password\". That is correct.");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess your password");
                        password = Console.ReadLine();
                        break;

                }    
            }
            while (!isGuessed);
         


        }
    }
}
