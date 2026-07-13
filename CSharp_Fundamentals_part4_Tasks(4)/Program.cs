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

        // Task 3 – Celsius to Fahrenheit Function
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
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

            // Task 3
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

            Console.WriteLine();



        }
    }
}
