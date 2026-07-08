namespace CSharp_Fundamentals_Part1_Tasks_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personal Info Card

            string Name = "Sara";
            int Age = 21;
            double HeightInMeters = 1.65;
            bool Student = true;

            Console.WriteLine("Name: " + Name + ", Age: " + Age + ", Hieght: " + HeightInMeters + ", Students: " + Student);
            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////

            //Task2 - Rectangule Calculator

            Console.WriteLine(" Enter the length:  ");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the Width:  ");
            float width = float.Parse(Console.ReadLine());

            float Area = length * width;
            float Perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + Area + ", Perimeter: " + Perimeter);
            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////
            
            //Task3 - Even or Odd Number Checker

            Console.WriteLine(" Enter a whole number:  ");
            int WholeNum = int.Parse(Console.ReadLine());

            if (WholeNum % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
                Console.WriteLine("_____________________________________");
            }
            ///////////////////////////////////////////////////////
            




        }
    }
}
