using System;
using System.Data;

namespace ConsoleAppB5P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 9;

            string[] numbersFirst = GetFillArray(size);
            string[] numbersSecond = GetFillArray(size);

            HashSet<string> hashSet = GetArrayNoRepetitions(numbersFirst, numbersSecond);

            Console.WriteLine("Даны массивы: ");
            Print(numbersFirst);
            Print(numbersSecond);
            Console.WriteLine("\nУникальные значения для обоих массивов:");
            Print(hashSet);

            Console.ReadKey();
        }

        private static string[] GetFillArray(int size)
        {
            string[] array = new string[size];

            Random random = new Random();

            int maxRandom = 100;

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(maxRandom).ToString();

            return array;
        }

        private static void Print(string[] array)
        {
            for (int i = 0; i < array.Length ; i++)
                Console.Write($"{array[i]} ");

            Console.WriteLine();
        }

        private static void Print(HashSet<string> hashSet)
        {
            foreach (string item in hashSet)
                Console.Write($"{item} ");

            Console.WriteLine();
        }

        private static HashSet<string> GetArrayNoRepetitions(string[] firstArray, string[] secondArray)
        {
            HashSet<string> hashSet = new HashSet<string>();

            FillHashSet(hashSet, firstArray);
            FillHashSet(hashSet, secondArray);

            return hashSet;
        }

        private static void FillHashSet(HashSet<string> hashSet, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                hashSet.Add(array[i]);
            }
        }
    }
}