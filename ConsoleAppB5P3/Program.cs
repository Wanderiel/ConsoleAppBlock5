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

            bool isStopped = false;

            Console.WriteLine($"Вводите любые числа." +
                $"\nДля подсчёта суммы введите - {SumCommand}, для выхода - {ExitCommand}.");

            while (isStopped == false)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case ExitCommand:
                        isStopped = true;
                        break;

                    case SumCommand:
                        isStopped = FinishJob(numbers);
                        break;

                    default:
                        AddNumber(numbers, userInput);
                        break;
                }
            }

            Console.WriteLine("\nВсего доброго!");
            Console.ReadKey();
        }

        private static bool FinishJob(List<int> numbers)
        {
            PrintSum(numbers);

            return true;
        }

        private static int PrintSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int value in numbers)
                sum += value;

            Console.WriteLine($"\nСумма всех введённых чисел: {sum}");

            return sum;
        }

        private static void AddNumber(List<int> numbers, string userInput)
        {
            if (int.TryParse(userInput, out int number))
                numbers.Add(number);
        }
    }
}