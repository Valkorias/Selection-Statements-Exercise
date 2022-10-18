using System;
using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;
            var counter = 0;

            do
            {


                Console.WriteLine("Pick a number between 1 - 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine($"You guessed it! {userInput} is correct!");
                }
                counter++;

                Console.WriteLine($"You have guessed {counter} times");
            } while (userInput != favNumber);

            //Switch-Case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                    Console.WriteLine("I've always loved science!");
                    break;
                case "history":
                    Console.WriteLine("History is very important!");
                    break;
                case "pe":
                    Console.WriteLine("PE is very fun!");
                    break;
                case "english":
                    Console.WriteLine("I've always found English boring.");
                    break;
                case "lunch":
                    Console.WriteLine("Lunch isn't a subject!");
                    break;
                case "recess":
                    Console.WriteLine("Recess! Now you're just messing with me!");
                    break;
                default:
                    Console.WriteLine("I don't know what subject that is.");
                    break;
            }
        }
    }
}