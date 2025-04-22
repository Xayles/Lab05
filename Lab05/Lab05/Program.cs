using Lab05Lib;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Введіть кількість виконавців: ");
        int count = int.Parse(Console.ReadLine());

        MusicArtist[] artists = new MusicArtist[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nВиконавець #{i + 1}");

            Console.Write("Сценічне ім'я: ");
            string stageName = Console.ReadLine();

            Console.Write("Ім'я засновника: ");
            string foundersName = Console.ReadLine();

            Console.Write("Країна: ");
            string country = Console.ReadLine();

            Console.Write("Музичний жанр: ");
            string genre = Console.ReadLine();

            Console.Write("Рік заснування: ");
            int yearFormed = int.Parse(Console.ReadLine());

            Console.Write("Рік дебюту: ");
            int debutYear = int.Parse(Console.ReadLine());

            Console.Write("Чи активний виконавець? (y - так / n - ні): ");
            bool isActive = Console.ReadLine().ToLower() == "y";

            int? endYear = null;
            if (!isActive)
            {
                Console.Write("Рік завершення кар'єри: ");
                endYear = int.Parse(Console.ReadLine());
            }

            Console.Write("Чи підтримує Україну? (y - так / n - ні): ");
            bool supportUkraine = Console.ReadLine().ToLower() == "y";

            artists[i] = new MusicArtist(stageName, foundersName, country, genre, yearFormed, debutYear, isActive, supportUkraine, endYear);
        }

        Console.WriteLine("\nІнформація про виконавців:");
        foreach (var artist in artists)
        {
            artist.DisplayInfo();
        }

        Console.ReadKey();
    }
}
