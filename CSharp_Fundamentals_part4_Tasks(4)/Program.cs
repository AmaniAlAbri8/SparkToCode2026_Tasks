namespace CSharp_Fundamentals_part4_Tasks_4_
{
    internal class Program
    {
       
        /////////////////////    Functions   ///////////////////////////
        

        // Task 1 – Personalized Welcome Function
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }

        // Task 2 – Square Number Function
        static int Square(int number)
        {
            return number * number;
        }

        /////////////////////    Main     ///////////////////////////
        static void Main(string[] args)
        {
            // Task1 
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            PrintWelcome(name);

            Console.WriteLine();

            // Task 2 
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int square = Square(number);

            Console.WriteLine("Square = " + square);

            Console.WriteLine();

        }
    }
}
