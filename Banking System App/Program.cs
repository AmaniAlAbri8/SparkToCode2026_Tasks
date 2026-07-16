using System;
using System.Collections.Generic;
namespace Banking_System_App
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.

        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Search Customer");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 4:
                        ShowBalance();
                        break;

                    case 5:
                        TransferAmount();
                        break;

                    case 6:
                        ListAllAccounts();
                        break;

                    case 7:
                        SearchCustomer();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.

        // Service 1 - Add New Account
        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter account number: ");
            string account = Console.ReadLine();

            if (accountNumbers.Contains(account))
            {
                Console.WriteLine("Account number already exists.");
                return;
            }

            Console.Write("Enter initial deposit: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount < 0)
            {
                Console.WriteLine("Deposit cannot be negative.");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(account);
            balances.Add(amount);

            Console.WriteLine("Account created successfully.");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Account: " + account);
            Console.WriteLine("Balance: " + amount);
        }
        // Service 2 - Deposit Money
        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string account = Console.ReadLine();

            int index = accountNumbers.IndexOf(account);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter deposit amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
                return;
            }

            balances[index] += amount;

            Console.WriteLine("Deposit successful.");
            Console.WriteLine("New Balance: " + balances[index]);
        }

    }