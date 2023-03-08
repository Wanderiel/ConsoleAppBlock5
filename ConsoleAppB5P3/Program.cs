using System;

namespace ConsoleAppB3P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ExitCommand = "exit";
            const string CodeWordCommand = "sum";

            string userInput;

            List<int> numbers = new();

            bool isWorking = true;

            Console.WriteLine($"Вводите любые числа." +
                $"\nДля подсчёта суммы введите - {CodeWordCommand}, для выхода - {ExitCommand}.");

            while (isWorking)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case ExitCommand:
                        isWorking = false;
                        break;

                    case CodeWordCommand:
                        int sum = GetSum(numbers);

                        Console.WriteLine($"\nСумма всех введённых чисел: {sum}");
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

        private static int GetSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int value in numbers)
                sum += value;

            return sum;
        }
    }
}