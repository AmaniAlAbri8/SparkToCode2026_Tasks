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

        }
    }
}
