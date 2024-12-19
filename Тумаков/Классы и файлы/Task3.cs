using System.Text;

namespace Tumakov
{
    public class BankTransaction3
    {
        public readonly DateTime TransactionDate;
        public readonly decimal Amount;

        public BankTransaction3(decimal amount)
        {
            TransactionDate = DateTime.Now;
            Amount = amount;
        }
    }

    public class BankScore3
    {
        private string bankscore;
        private decimal balance;
        private string scoreType;
        private readonly Queue<BankTransaction3> transactions = new Queue<BankTransaction3>();

        public BankScore3(decimal balance)
        {
            this.balance = balance;
            this.bankscore = RandomBankScore();
            this.scoreType = "Неопределён";
        }

        public BankScore3(string scoreType)
        {
            this.scoreType = scoreType;
            this.bankscore = RandomBankScore();
            this.balance = 0;
        }

        public BankScore3(decimal balance, string scoreType)
        {
            this.scoreType = scoreType;
            this.bankscore = RandomBankScore();
            this.balance = balance;
        }

        public BankScore3()
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

        public void Print(BankScore3 bankScore2)
        {
            Console.WriteLine($"На первом счету: {this.balance} рублей!");
            Console.WriteLine($"На втором счету: {bankScore2.balance} рублей!");
        }

        public void MoneyTransferUp(decimal sum)
        {
            this.balance += sum;
            BankTransaction3 transaction = new BankTransaction3(sum);
            transactions.Enqueue(transaction);
            Dispose(transaction);
        }

        public void MoneyTransferDown(decimal sum)
        {
            if (balance - sum >= 0)
            {
                balance -= sum;
                BankTransaction3 transaction = new BankTransaction3(-sum);
                transactions.Enqueue(transaction);
                Dispose(transaction);
            }
            else
            {
                Console.WriteLine("Операцию совершить невозможно! На счету не хватает денег!");
            }
        }

        public void Dispose(BankTransaction3 bankTransaction)
        {
            WriteTransactionsToFile(bankTransaction);
            GC.SuppressFinalize(this);
        }

        public void WriteTransactionsToFile(BankTransaction3 bankTransaction)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string newDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "..", "..","..", "Классы и файлы"));
            Console.WriteLine(newDirectory);
            string filePath = Path.Combine(newDirectory, "BankTransactions.txt");

            if (Directory.Exists(Path.GetFullPath(newDirectory)))
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Transaction Date: {bankTransaction.TransactionDate}, Amount: {bankTransaction.Amount}");
                }
            }
        }
    }
}
