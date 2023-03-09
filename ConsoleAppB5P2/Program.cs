using System;

namespace ConsoleAppB5P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 9;

            Queue<int> purchases = new();

            FillQueue(purchases, size);

            ServePurchase(purchases);

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

        private static void ServePurchase(Queue<int> purchases)
        {
            int sum = 0;

            while (purchases.Count > 0)
            {
                int purchase = purchases.Dequeue();
                Console.WriteLine($"Сумма по чеку: {purchase}");

                sum += purchase;
                PrintSum(sum);
            }

            Console.WriteLine($"Все клиенты обслужены, выручка составила: {sum}");
        }

        private static void PrintSum(int sum)
        {
            Console.WriteLine($"Текущая выручка: {sum}\nСледующий!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}