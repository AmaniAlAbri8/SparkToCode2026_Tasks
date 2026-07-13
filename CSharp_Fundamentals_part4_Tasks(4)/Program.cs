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
        // Task 4 - Fixed Menu Display Function
        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        // Task 5 - Even or Odd Function
        static bool IsEven(int Num)
        {
            return Num % 2 == 0;
        }
        // Task 6 - Rectangle Area & Perimeter Functions
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }
        // Task 7 - Grade Letter Function
        static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        // Task 8 - Countdown Function
        static void Countdown(int start)
        {
            for (int counter = start; counter >= 1; counter--)
            {
                Console.WriteLine(counter);
            }
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

            // Task 4

            DisplayMenu();

            Console.WriteLine();

            // Task 5
            Console.Write("Enter a number: ");
            int evenOddNumber = int.Parse(Console.ReadLine());

            if (IsEven(evenOddNumber))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.WriteLine();

            // Task 6
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);

            Console.WriteLine();

            // Task 7
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            string grade = GetGradeLetter(score);

            Console.WriteLine("Grade = " + grade);

            Console.WriteLine();

            // Task 8
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());

            Countdown(start);

        }
    }
}
