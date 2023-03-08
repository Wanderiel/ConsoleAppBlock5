using System;

namespace ConsoleAppB5P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> meaninglessСollection = new()
            {
                { "утро", "в поле выпала роса" },
                { "солнце", "руки к небу протяни" },
                { "ветер", "поднимаю паруса" },
                { "лето", "надо ехать в край родной" },
                { "лес", "наслаждаюсь тишиной" },
                { "горы", "полюбуйся красотой" },
                { "дождь", "шлёпаю босым по лужам" },
                { "вечер", "как прекрасен здесь закат" },
                { "полнолуние", "осторожно, волки" }
            };

            string userInput;

            Console.Write("Приветствую, скажи слово, может что-то подскажу: ");
            userInput = Console.ReadLine().ToLower();

            if (meaninglessСollection.ContainsKey(userInput))
                Console.WriteLine(meaninglessСollection[userInput]);
            else
                Console.WriteLine("Хм... ничем не помогу...");

            Console.ReadKey();
        }
    }
}