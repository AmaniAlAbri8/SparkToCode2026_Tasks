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

        }
    }
}
