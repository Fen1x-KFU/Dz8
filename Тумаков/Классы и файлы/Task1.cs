using System;
using System.Text;

namespace Tumakov
{
    public class BankScore1
    {
        private string bankscore;
        private decimal balance;
        private string scoreType;

        public BankScore1(decimal balance)
        {
            this.balance = balance;
            this.bankscore = RandomBankScore();
            this.scoreType = "Неопределён";
        }

        public BankScore1(string scoreType)
        {
            this.scoreType = scoreType;
            this.bankscore = RandomBankScore();
            this.balance = 0;
        }

        public BankScore1(decimal balance, string scoreType)
        {
            this.scoreType = scoreType;
            this.bankscore = RandomBankScore();
            this.balance = balance;
        }

        public BankScore1()
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

        public void Print(BankScore1 bankScore2)
        {
            Console.WriteLine($"На первом счету: {this.balance} рублей!");
            Console.WriteLine($"На втором счету: {bankScore2.balance} рублей!");
        }

        public void MoneyTransfer(BankScore1 bankScore2, decimal sum)
        {
            if (this.balance - sum >= 0)
            { 
                this.balance = this.balance - sum; 
                bankScore2.balance += sum;
            }
            else
            {
                Console.WriteLine("Операцию совершить невозможно! На счету не хватает денег!");
            }
        }
    }
}