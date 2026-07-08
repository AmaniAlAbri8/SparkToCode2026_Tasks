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
            //Task4 - Voting Eligibility

            Console.WriteLine(" Enter you age:  ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(" Do you hold a valid national ID (yes/no)?  ");
            string ID = Console.ReadLine();

            bool HasValidID = ID == "yes";
            if (HasValidID && age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
                Console.WriteLine("_____________________________________");

            }

            ///////////////////////////////////////////////////////





        }
    }
}
