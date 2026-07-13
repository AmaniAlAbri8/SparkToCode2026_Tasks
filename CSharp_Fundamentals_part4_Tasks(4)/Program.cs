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

        /////////////////////    Main   ///////////////////////////
        static void Main(string[] args)
        {
            // Task1 
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            PrintWelcome(name);

            Console.WriteLine();

        }
    }
}
