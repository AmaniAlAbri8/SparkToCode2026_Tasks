using System.Diagnostics.Metrics;
using System.Reflection;

namespace CSharp_Fundamentals_part5_Tasks_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Task 1 - Fixed Grades Array

            int[] grades = new int[5];

            for (int counter = 0; counter < grades.Length; counter++)
            {
                Console.Write("Enter grade " + (counter + 1) + ": ");
                grades[counter] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////////

            //Task 2 - Dynamic To-Do List

            List<string> toDoList = new List<string>();

            int Count;

            for (Count = 0; Count < 5; Count++)
            {
                Console.WriteLine("Enter task:");
                toDoList.Add(Console.ReadLine());
            }

            Console.WriteLine("To-Do List:");

            Count = 1;

            foreach (string task in toDoList)
            {
                Console.WriteLine(Count + ". " + task);
                Count++;
            }
            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////////

            //Task 3 - Browsing History Stack

            Stack<string> browserHistory = new Stack<string>();
            int webcounter;

            for (webcounter = 0; webcounter < 3; webcounter++)
            {
                Console.WriteLine("Enter website:");
                browserHistory.Push(Console.ReadLine());
            }

            string removedPage = browserHistory.Pop();

            Console.WriteLine("Back Button Pressed");
            Console.WriteLine("Removed Page: " + removedPage);

            Console.WriteLine("Current Page:");
            Console.WriteLine(browserHistory.Peek());
            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////////

            //Task 4- Customer Service Queue
            Queue<string> customers = new Queue<string>();

            int CustomerCounter;

            for (CustomerCounter = 0; CustomerCounter < 3; CustomerCounter++)
            {
                Console.WriteLine("Enter customer name:");
                customers.Enqueue(Console.ReadLine());
            }

            string servedCustomer = customers.Dequeue();

            Console.WriteLine("Customer Served:");
            Console.WriteLine(servedCustomer);

            Console.WriteLine("Remaining Customers:");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("_____________________________________");

            ///////////////////////////////////////////////////////////

            //Task 5- Array Grade Range

            int[] grades2 = new int[5];
            int total = 0;
            int counterr;

            for (counterr = 0; counterr < grades2.Length; counterr++)
            {
                Console.WriteLine("Enter grade:");
                grades2[counterr] = int.Parse(Console.ReadLine());
            }

            Array.Sort(grades2);

            for (counterr = 0; counterr < grades2.Length; counterr++)
            {
                total = total + grades2[counterr];
            }

            double average = (double)total / grades2.Length;

            Console.WriteLine("Lowest Grade: " + grades2[0]);
            Console.WriteLine("Highest Grade: " + grades2[grades2.Length - 1]);
            Console.WriteLine("Average Grade: " + average);

        }
    }
}
