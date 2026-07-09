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

        }
    }
}
