using System;

public class Program
{
    static void Main()
    {
        WriteTransactionsToFile();
    }

    static void WriteTransactionsToFile()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string newDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "..", "..", "..", "Классы и файлы", "BankTransactions.txt"));

        if (Directory.Exists(newDirectory))
        {
            using (StreamWriter writer = new StreamWriter("BankTransactions.txt", true))
            {
                writer.WriteLine($"Transaction Date: {DateTime.Now}, Amount: {500}");
            }
            Console.WriteLine(File.ReadAllText(newDirectory));

        }
    }
}