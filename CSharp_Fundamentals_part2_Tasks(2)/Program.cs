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



        }
    }
}
