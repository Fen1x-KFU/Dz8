using System;

namespace Tumakov
{
    public class Program
    {
        static void StartTask(string name)
        {
            Console.WriteLine($"Задание: {name}\n");
        }

        static void Task1()
        {
            StartTask("9.1");

            Console.WriteLine("Введите тип первого банковского счёта!");
            string scoreType1 = Console.ReadLine();

            Console.WriteLine("Введите тип второго банковского счёта!");
            string scoreType2 = Console.ReadLine();

            Console.WriteLine("Введите баланс первого счёта!");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance1) == false)
            {
                Console.WriteLine("Вы ввели не баланс счёта!");
                balance1 = 0;
            }

            Console.WriteLine("Введите баланс второго счёта!");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance2) == false)
            {
                Console.WriteLine("Вы ввели не баланс счёта!");
                balance2 = 0;
            }

            BankScore1 bankScore1 = new BankScore1(balance1, scoreType1);
            BankScore1 bankScore2 = new BankScore1(balance2, scoreType2);

            bankScore1.MoneyTransfer(bankScore2, 500);
            bankScore1.Print(bankScore2);
        }

        static void Task2()
        {
            StartTask("9.2");

            Console.WriteLine("Введите тип первого банковского счёта!");
            string scoreType1 = Console.ReadLine();

            Console.WriteLine("Введите тип второго банковского счёта!");
            string scoreType2 = Console.ReadLine();

            Console.WriteLine("Введите баланс первого счёта!");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance1) == false)
            {
                Console.WriteLine("Вы ввели не баланс счёта!");
                balance1 = 0;
            }

            Console.WriteLine("Введите баланс второго счёта!");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance2) == false)
            {
                Console.WriteLine("Вы ввели не баланс счёта!");
                balance2 = 0;
            }

            BankScore2 bankScore1 = new BankScore2(balance1, scoreType1);
            BankScore2 bankScore2 = new BankScore2(balance2, scoreType2);

            bankScore1.MoneyTransferUp(500);
            bankScore2.MoneyTransferDown(550);
        }

        static void Task3()
        {
            StartTask("9.3");

            Console.WriteLine("Введите тип первого банковского счёта!");
            string scoreType1 = Console.ReadLine();

            Console.WriteLine("Введите тип второго банковского счёта!");
            string scoreType2 = Console.ReadLine();

            Console.WriteLine("Введите баланс первого счёта!");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance1) == false)
            {
                Console.WriteLine("Вы ввели не баланс счёта!");
                balance1 = 0;
            }

            Console.WriteLine("Введите баланс второго счёта!");
            if (decimal.TryParse(Console.ReadLine(), out decimal balance2) == false)
            {
                Console.WriteLine("Вы ввели не баланс счёта!");
                balance2 = 0;
            }

            BankScore3 bankScore1 = new BankScore3(balance1, scoreType1);
            BankScore3 bankScore2 = new BankScore3(balance2, scoreType2);

            bankScore1.MoneyTransferUp(500);
            bankScore2.MoneyTransferDown(550);
        }

        static void Main()
        {
            //Task1();
            //Task2();
            Task3();
        }
    }
}