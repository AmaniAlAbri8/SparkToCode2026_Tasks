namespace CSharp_Fundamentals_part3_Tasks_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Absolute Difference

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int difference = Math.Abs(num2 - num1);

            Console.WriteLine("Positive difference: " + difference);
            Console.WriteLine("_____________________________________");


            ///////////////////////////////////////////////////////


            //Task2 - Power & Root Explorer

            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("Square: " + square);
            Console.WriteLine("Square Root: " + squareRoot);
            Console.WriteLine("_____________________________________");


            ///////////////////////////////////////////////////////

            //Task3 - Name Formatter

            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Lowercase: " + name.ToLower());
            Console.WriteLine("Characters: " + name.Length);
            Console.WriteLine("_____________________________________");


            ///////////////////////////////////////////////////////

            //Task4 - Subscription End Date

            Console.Write("Enter the number of a free trial days: ");
            int days = int.Parse(Console.ReadLine());

            DateTime endDate = DateTime.Today.AddDays(days);

            Console.WriteLine("End Date: " + endDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("_____________________________________");


            ///////////////////////////////////////////////////////





        }
    }
}
