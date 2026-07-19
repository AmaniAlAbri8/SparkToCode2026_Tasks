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


    internal class Program
    {
        static void Main(string[] args)
        {
           


        }
    }
}
