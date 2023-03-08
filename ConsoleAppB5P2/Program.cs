using System;
using System.Collections.Concurrent;

namespace ConsoleAppB5P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 9;

            Queue<int> purchases = new Queue<int>();

            GetFillQueue(purchases, size);

            int revenue = CalculationRevenue(purchases);

            Console.WriteLine($"Все клиенты обслужены, выручка составила: {revenue}");
            Console.ReadKey();
        }

        private static void GetFillQueue(Queue<int> purchases, int size)
        {
            Random random = new Random();

            int minRandom = 1;
            int maxRandom = 1001;

            for (int i = 0; i < size; i++)
                purchases.Enqueue(random.Next(minRandom, maxRandom));
        }

        private static int CalculationRevenue(Queue<int> purchases)
        {
            int sum = 0;

            foreach (int purchase in purchases)
            {
                sum += purchase;

                Console.WriteLine($"Сумма по чеку: {purchase}\nТекущая выручка: {sum}");
                Console.ReadKey();
                Console.Clear();
            }

            return sum;
        }
    }
}