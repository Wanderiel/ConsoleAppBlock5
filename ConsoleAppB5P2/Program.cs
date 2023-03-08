using System;

namespace ConsoleAppB5P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 9;

            Queue<int> purchases = new Queue<int>();

            FillQueue(purchases, size);

            int revenue = GetCalculationRevenue(purchases);

            Console.WriteLine($"Все клиенты обслужены, выручка составила: {revenue}");
            Console.ReadKey();
        }

        private static void FillQueue(Queue<int> purchases, int size)
        {
            Random random = new Random();

            int minRandom = 1;
            int maxRandom = 1001;

            for (int i = 0; i < size; i++)
                purchases.Enqueue(random.Next(minRandom, maxRandom));
        }

        private static int GetCalculationRevenue(Queue<int> purchases)
        {
            int sum = 0;

            foreach (int purchase in purchases)
            {
                sum += purchase;
                PrintPurcase(purchase, sum);
            }

            return sum;
        }

        private static void PrintPurcase(int purchase, int sum)
        {
            Console.WriteLine($"Сумма по чеку: {purchase}\nТекущая выручка: {sum}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}