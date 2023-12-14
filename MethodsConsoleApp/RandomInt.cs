using System;  

namespace MethodsConsoleApp
{
    internal class RandomInt
    {
        public static void GuessRandom() 
        {
            Random numberGenerator = new Random();
            int randomNumber, selectedNumber;
            int tries = 0;

            Console.WriteLine("Good morning user, let's play a game shall we?\n" +
                              "I will select a random number between 0 and 100 and " +
                              "you have to guess which one is it.\n" +
                              "Don't worry, I will help you by saying if it's above " +
                              "or below the actual value.");

            randomNumber = numberGenerator.Next(0, 101); //101 because it's: number < maxValue

            Console.WriteLine("Well then, let's start...");

            do
            {

                tries++;
                Console.WriteLine("The number is?: ");
                try
                {
                    selectedNumber = Convert.ToInt32(Console.ReadLine());

                    if (randomNumber > selectedNumber) Console.WriteLine("You are below it!");

                    else if (randomNumber < selectedNumber) Console.WriteLine("You are above it!");
                }
                catch (FormatException) //SPECIFIC EXCEPTIONS FIRST
                {

                    Console.WriteLine("You wrote an invalid format. Only whole numbers are allowed.");
                    Console.WriteLine("Try again.");
                    selectedNumber = 101;
                }
                catch (OverflowException) 
                {

                    Console.WriteLine("That number is way to big! It's only a number between 0 and 100.");
                    Console.WriteLine("Try again.");
                    selectedNumber = 101;
                }
                catch (Exception) //GENERALISTIC EXCEPTIONS LAST
                {
                    Console.WriteLine("An error has ocurred. Try again.");
                    selectedNumber = 101;
                }

            } while (randomNumber != selectedNumber);

            Console.WriteLine("Congrats! You guessed the correct number!");
            Console.WriteLine("It took you {0} attempt/s to guess the number.", tries);

        }
    }
}
