using System;

namespace ConsoleAppB4P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string AddDossierCommand = "1";
            const string PrintDossiersCommand = "2";
            const string RemoveDossierCommand = "3";
            const string ExitCommand = "4";

            bool isWorking = true;

            string userInput;

            List<string> employee = new();
            List<string> posts = new();

            while (isWorking)
            {
                Console.Clear();

                Console.WriteLine($"{AddDossierCommand}. Добавить досье" +
                    $"\n{PrintDossiersCommand}. Распечатать все досье" +
                    $"\n{RemoveDossierCommand}. Удалить досье" +
                    $"\n{ExitCommand}. Выйти из программы" +
                    $"\n");

                userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case AddDossierCommand:
                        AddDossier(employee, posts);
                        break;

                    case PrintDossiersCommand:
                        PrintDossiers(employee, posts);
                        break;

                    case RemoveDossierCommand:
                        RemoveDossier(employee, posts);
                        break;

                    case ExitCommand:
                        isWorking = false;
                        break;

                    default:
                        Console.Write("Неверная команда");
                        break;
                }

                Console.ReadKey();
            }

            Console.Write("Работа завершена, всего доброго.");

            Console.ReadKey();
        }

        static private void AddDossier(List<string> employee, List<string> posts)
        {
            Console.WriteLine("Инициализация процедуры добавления новой записи...");
            Thread.Sleep(300);

            Console.Write("Введите ФИО: ");
            employee.Add(Console.ReadLine());

            Console.Write("Введите должность: ");
            posts.Add(Console.ReadLine());

            Console.WriteLine("\nПодождите, я записываю...");
            Thread.Sleep(500);

            Console.WriteLine($"\nДобавлена новая запись: {employee.Last()} - {posts.Last()}");
        }

        static void PrintDossiers(List<string> employee, List<string> posts)
        {
            const int RecordLength = 39;
            const int IdLength = 3;
            const int SurnameLength = 18;
            const int PostLength = 11;

            char symbol = '=';

            Console.WriteLine(new string(symbol, RecordLength));

            if (employee.Count > 0)
            {
                Console.WriteLine("Инициализация процедуры печати, подождите...\n");
                Thread.Sleep(500);

                for (int i = 0; i < employee.Count; i++)
                    Console.WriteLine($"|{i,IdLength}" +
                        $" |{employee[i],SurnameLength}" +
                        $" |{posts[i],PostLength} |");
            }
            else
            {
                Console.WriteLine($"{"Записей не найдено",RecordLength}");
            }

            Console.WriteLine(new string(symbol, RecordLength));
        }

        static private void RemoveDossier(List<string> employee, List<string> posts)
        {
            string userInput;

            Console.WriteLine("Введите Id досье для удаления: ");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int id) &&
                id >= 0 && id < employee.Count)
            {
                Console.WriteLine("Инициализация процедуры удаления, подождите...\n");
                Thread.Sleep(500);

                employee.RemoveAt(id);
                posts.RemoveAt(id);

                Console.WriteLine("\nЗапись успешно удалена...");
            }
            else
            {
                Console.Write("\nВведён неверный id досье...");
            }
        }
    }
}