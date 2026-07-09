namespace CSharp_Fundamentals_part2_Tasks_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Countdown Timer

            Console.WriteLine("Enter a starting number: ");
            int startingNumber = int.Parse(Console.ReadLine());

            for (int counter = startingNumber; counter >= 1; counter--)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("Liftoff!");

            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////

            //Task2 - Sum of Numbers 1 to N

            Console.WriteLine("Enter a positive whole number: ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int counter = 1; counter <= N; counter++)
            {
                sum = sum + counter;
            }

            Console.WriteLine("The sum is: " + sum);

            Console.WriteLine("_____________________________________");


            ///////////////////////////////////////////////////////

            //Task3 - Multiplication Table

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine(number + " x " + counter + " = " + (number * counter));
            }

            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////

            //Task4 - Password Retry

            string password = "Spark2026";
            bool Exit = false;
            string input;

            while (Exit == false)
            {
                Console.Write("Enter password: ");
                input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine("Access Granted");
                    Exit = true;
                }
               else
                {
                    Console.WriteLine("Incorrect password, try again");
                }
            }
            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////

            //Task5 - Number Guessing Game

            Console.Write("Guess the secret number: ");

            int secretNumber = 42;
            int guess;
            int attempts = 0;
            bool correctGuess = false;

            do
            {
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    correctGuess = true;
                }

            } while (correctGuess == false);

            Console.WriteLine("Attempts: " + attempts);

            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////

            //Task6 - Safe Division Calculator

            try
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid numbers.");
            }

            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////

            //Task7 - Repeating Menu with Exit Option

            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Greeting");
                Console.WriteLine("3. Exit");

                try
                {
                    Console.Write("Choose an option: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;

                        case 2:
                            Console.WriteLine("Good Day!");
                            break;

                        case 3:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number.");
                }
            }

            Console.WriteLine("_____________________________________");






        }
    }
}
