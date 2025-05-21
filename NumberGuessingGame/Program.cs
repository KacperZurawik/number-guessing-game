using System;

namespace NumberGuessingGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            bool isAppRunning = true;

            while (isAppRunning)
            {
                Console.WriteLine("Choose game mode");
                Console.WriteLine("1. Guess numbers from 0 to 100.");
                Console.WriteLine("2. Custom game");
                Console.WriteLine("3. Exit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        CasualGame();
                        break;

                    case "2":
                        Console.Clear();
                        CustomGame();
                        break;

                    case "3":
                        isAppRunning = false;
                        break;

                    default:
                        Console.WriteLine("Incorrect. Choose from 1 to 4.");
                        break;
                }
            }
        }

        public static void CasualGame()
        {
            Random random = new Random();
            int guessingValue = random.Next(1, 100);

            Console.WriteLine("Guess the number from 1 to 100.");

            int userGuess = 0;
            int userAttempts = 0;

            while (userGuess != guessingValue)
            {
                try
                {
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    userAttempts++;

                    if (userGuess > guessingValue)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }

                    if (userGuess < guessingValue)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }

                    if (userGuess == guessingValue)
                    {
                        Console.WriteLine($"Bravissimo! You guessed it on attempt number {userAttempts}!");
                        Console.WriteLine();
                    }
                }
                catch
                {
                    Console.WriteLine("The entered value must be an integer. Please try again.");
                }
            }
        }

        public static void CustomGame()
        {
            Console.WriteLine("You need to provide the range of numbers you want to guess.");

            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Range from {firstNumber} to {secondNumber}");

            Random random = new Random();
            int guessingValue = random.Next(firstNumber, secondNumber);

            Console.WriteLine($"Guess the number between {firstNumber} and {secondNumber}.");

            int userGuess = 0;
            int userAttempts = 0;

            while (userGuess != guessingValue)
            {
                try
                {
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    userAttempts++;

                    if (userGuess > guessingValue)
                    {
                        Console.WriteLine("The number is too high. Try again.");
                    }

                    if (userGuess < guessingValue)
                    {
                        Console.WriteLine("The number is too low. Try again.");
                    }

                    if (userGuess == guessingValue)
                    {
                        Console.WriteLine($"Congrats! You guessed it on attempt number {userAttempts}!");
                        Console.WriteLine();
                    }
                }
                catch
                {
                    Console.WriteLine("The entered value must be an integer. Please try again.");
                }
            }
        }

    }
}