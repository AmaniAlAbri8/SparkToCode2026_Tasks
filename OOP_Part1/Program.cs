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
           


        }
    }
}
