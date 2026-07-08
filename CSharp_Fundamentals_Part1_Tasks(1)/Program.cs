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
            //Task5 - Grade letter lookup

            Console.WriteLine(" Enter a single character representing your grade ('A', 'B', 'C', 'D', or 'F'): ");
            char Grade = char.Parse(Console.ReadLine());

            switch (Grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////
            
            //Task6 - Temperature Converter

            Console.WriteLine("Enter a temperature in Celsius: ");
            float Celsius = float.Parse(Console.ReadLine());

            float F = (Celsius * 9 / 5) + 32;
            Console.WriteLine("Converted Fahrnheit value is: " + F);

            if (F < 10)
            {
                Console.WriteLine("weather classification is: Cold");
            }
            else if (F <= 30)
            {
                Console.WriteLine("weather classification is: Mild");
            }
            else
            {
                Console.WriteLine("weather classification is: Hot");
            }
            Console.WriteLine("_____________________________________");


            ///////////////////////////////////////////////////////
            
            //Task7 - Movie Ticket Pricing 

            Console.WriteLine("Enter your age: ");
            int TicketAge = int.Parse(Console.ReadLine());

            if (TicketAge >= 0 && TicketAge <= 12)
            {
                Console.WriteLine("Category name: Children");
                Console.WriteLine("Ticket Price: 2.000 OMR");
            }
            else if (TicketAge >= 13 && TicketAge <= 59)
            {
                Console.WriteLine("Category name: Adults ");
                Console.WriteLine("Ticket Price: 5.000 OMR");
            }
            else
            {
                Console.WriteLine("Category name: Senior ");
                Console.WriteLine("Ticket Price: 3.000 OMR");
            }
            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////
            
            //Task8 - Restaurant Bill with Membership Discount

            Console.WriteLine("Enter the total bill amount: ");
            double BillAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Are you a loyal member (yes/no)?");
            string Membership = Console.ReadLine();

            bool loyalmember = Membership == "yes";
            double DiscountedAmount = 0;

            if (loyalmember && BillAmount > 20)
            {
                DiscountedAmount = BillAmount * 0.15;
            }
            double FinalAmount = BillAmount - DiscountedAmount;

            Console.WriteLine("The Original Bill Amount is: " + BillAmount + " OMR");
            Console.WriteLine("The Discount Amount is: " + DiscountedAmount + " OMR");
            Console.WriteLine("The Final Amount is: " + FinalAmount + " OMR");

            Console.WriteLine("_____________________________________");


            ///////////////////////////////////////////////////////
            
            //Task9 - Day Name Finder

            Console.WriteLine("Enter a number from 1 to 7 representing a day of the week: ");
            int DayNumber = int.Parse(Console.ReadLine());

            switch (DayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thuersday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
            Console.WriteLine("_____________________________________");


            ///////////////////////////////////////////////////////








        }
    }
}
