namespace OOP_Part1
{
    // Class 1 - BankAccount
    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        //  Method- Deposit
        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }
        // Method- Withdraw
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        // Method- CheckBalance
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }
        // Method - PrintInformation
        private void PrintInformation()
        {
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
        // Method - SendEmail
        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }
    }
    // Class 2 - Student
    class Student
    {
        public int Grade;
        public string Name;
        public string Address;

        private string email;
        int age;

        // Method - Register
        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        // Method - SendEmail
        private void SendEmail()
        {
            Console.WriteLine("Registration email sent.");
        }
    }
    // Class 3 - Product
    class Product
    {
        public string ProductName;
        public double Price;
        public int StockQuantity;

        // Method - Sell
        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock.");
            }

            LogTransaction();
        }
        // Method - Restock
        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }
        // Method - GetInventoryValue
        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }
        // Method - PrintDetails
        private void PrintDetails()
        {
            Console.WriteLine("Product: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Stock: " + StockQuantity);
        }
        // Method - LogTransaction
        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Object 1 -  BankAccount
            BankAccount account1 = new BankAccount();
            account1.AccountNumber = 1163;
            account1.HolderName = "Karim";
            account1.Balance = 120;

            //Object 2 -  BankAccount
            BankAccount account2 = new BankAccount();
            account2.AccountNumber = 15203;
            account2.HolderName = "Ali";
            account2.Balance = 63;

            //Object 1 -  Student
            Student student1 = new Student();
            student1.Name = "Ali";
            student1.Address = "Muscat";
            student1.Grade = 65;

            //Object 2 -  Student
            Student student2 = new Student();
            student2.Name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 70;

            //Object 1 - Product
            Product product1 = new Product();
            product1.ProductName = "Wireless Mouse";
            product1.Price = 5.500;
            product1.StockQuantity = 50;

            //Object 2 - Product
            Product product2 = new Product();
            product2.ProductName = "Mechanical Keyboard";
            product2.Price = 15.750;
            product2.StockQuantity = 20;

            //Main Menu
            int choice = 0;

            while (choice != 9)
            {
                Console.WriteLine();
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make Deposit");
                Console.WriteLine("4. Make Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("6. Register Student");
                Console.WriteLine("7. Compare Account Balances");
                Console.WriteLine("8. Restock Product");
                Console.WriteLine("9. Exit");

                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    // Case 1 - View Account Details
                    case 1:

                        Console.Write("Choose Account (1 or 2): ");
                        int acc = int.Parse(Console.ReadLine());

                        if (acc == 1)
                            account1.CheckBalance();
                        else
                            account2.CheckBalance();

                        break;
                    //Case 2 - Update Student Address
                    case 2:

                        Console.Write("Choose Student (1 or 2): ");
                        int stu = int.Parse(Console.ReadLine());

                        Console.Write("New Address: ");
                        string address = Console.ReadLine();

                        if (stu == 1)
                        {
                            student1.Address = address;
                            Console.WriteLine("New Address: " + student1.Address);
                        }
                        else
                        {
                            student2.Address = address;
                            Console.WriteLine("New Address: " + student2.Address);
                        }

                        break;

                    //Case 3 - Make a Deposit
                    case 3:

                        Console.Write("Choose Account (1 or 2): ");
                        acc = int.Parse(Console.ReadLine());

                        Console.Write("Amount: ");
                        double deposit = double.Parse(Console.ReadLine());

                        if (acc == 1)
                        {
                            account1.Deposit(deposit);
                            Console.WriteLine(account1.HolderName);
                            Console.WriteLine("Balance: " + account1.Balance);
                        }
                        else
                        {
                            account2.Deposit(deposit);
                            Console.WriteLine(account2.HolderName);
                            Console.WriteLine("Balance: " + account2.Balance);
                        }

                        break;

                    // Case 4 - Make a Withdrawal
                    case 4:

                        Console.Write("Choose Account (1 or 2): ");
                        acc = int.Parse(Console.ReadLine());

                        Console.Write("Amount: ");
                        double withdraw = double.Parse(Console.ReadLine());

                        if (acc == 1)
                        {
                            account1.Withdraw(withdraw);
                            Console.WriteLine("Balance: " + account1.Balance);
                        }
                        else
                        {
                            account2.Withdraw(withdraw);
                            Console.WriteLine("Balance: " + account2.Balance);
                        }

                        break;




                }
            }
}
