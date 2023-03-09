using System;

namespace ConsoleAppB3P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ExitCommand = "exit";
            const string SumCommand = "sum";

            string userInput;

            List<int> numbers = new();

            bool isWorking = true;

            Console.WriteLine($"Вводите любые числа." +
                $"\nДля подсчёта суммы введите - {SumCommand}, для выхода - {ExitCommand}.");

            while (isWorking)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case ExitCommand:
                        isWorking = false;
                        break;

                    case SumCommand:
                        PrintSum(numbers);
                        isWorking = false;
                        break;

                    default:
                        if (int.TryParse(userInput, out int number))
                            numbers.Add(number);
                        break;
                }
            }

            Console.WriteLine("\nВсего доброго!");
            Console.ReadKey();
        }

        private static int PrintSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int value in numbers)
                sum += value;

            Console.WriteLine($"\nСумма всех введённых чисел: {sum}");

            return sum;
        }
    }
}