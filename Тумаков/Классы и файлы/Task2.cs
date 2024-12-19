using System;
using System.Text;


namespace Tumakov
{
    public class BankTransaction2
    {
        public readonly DateTime TransactionDate;
        public readonly decimal Amount;

        public BankTransaction2(decimal amount)
        {
            TransactionDate = DateTime.Now;
            Amount = amount;
        }
    }

    public class BankScore2
    {
        private string bankscore;
        private decimal balance;
        private string scoreType;
        private readonly Queue<BankTransaction2> transactions = new Queue<BankTransaction2>();

        public BankScore2(decimal balance)
        {
            this.balance = balance;
            this.bankscore = RandomBankScore();
            this.scoreType = "Неопределён";
        }

        public BankScore2(string scoreType)
        {
            this.scoreType = scoreType;
            this.bankscore = RandomBankScore();
            this.balance = 0;
        }

        public BankScore2(decimal balance, string scoreType)
        {
            this.scoreType = scoreType;
            this.bankscore = RandomBankScore();
            this.balance = balance;
        }

        public BankScore2()
        {
            this.bankscore = RandomBankScore();
            this.balance = 0;
            this.scoreType = "Неопределён";
        }

        static string RandomBankScore()
        {
            Random random = new Random();
            StringBuilder bankScore = new StringBuilder();
            while (bankScore.Length < 8)
            {
                int digit = random.Next(0, 10);
                bankScore.Append(digit);
            }
            return bankScore.ToString();
        }

        public void Print(BankScore2 bankScore2)
        {
            Console.WriteLine($"На первом счету: {this.balance} рублей!");
            Console.WriteLine($"На втором счету: {bankScore2.balance} рублей!");
        }

        public void MoneyTransferUp(decimal sum)
        {
            this.balance += sum;
            BankTransaction2 transaction = new BankTransaction2(sum);
            transactions.Enqueue(transaction);
        }

        public void MoneyTransferDown(decimal sum)
        {
            if (balance - sum >= 0)
            {
                balance -= sum;
                BankTransaction2 transaction = new BankTransaction2(-sum);
                transactions.Enqueue(transaction);
            }
            else
            {
                Console.WriteLine("Операцию совершить невозможно! На счету не хватает денег!");
            }
        }
    }
}