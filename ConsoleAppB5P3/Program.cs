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
                        isWorking = true;
                        break;

                    case SumCommand:
                        PrintSum(numbers);
                        break;

                    default:
                        AddNumber(numbers, userInput);
                        break;
                }
            }

            Console.WriteLine("\nВсего доброго!");
            Console.ReadKey();
        }

        private static void PrintSum(List<int> numbers)
        {
            int sum = CalculateSum(numbers);

            Console.WriteLine($"\nСумма всех введённых чисел: {sum}");
        }

        private static int CalculateSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            return sum;
        }

        private static void AddNumber(List<int> numbers, string userInput)
        {
            if (int.TryParse(userInput, out int number))
                numbers.Add(number);
        }
    }
}