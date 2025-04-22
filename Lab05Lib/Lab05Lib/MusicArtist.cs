namespace Lab05Lib
{
    public class MusicArtist
    {
        public string StageName;
        public string FoundersName;
        public string Country;
        public string Genre;
        public int YearFormed;
        public int DebutYear;
        public bool IsActive;
        public bool SupportUkraine;
        public int? EndYear; // Рік закінчення діяльності

        public MusicArtist(string stageName, string foundersName, string country, string genre, int yearFormed, int debutYear, bool isActive, bool supportUkraine, int? endYear = null)
        {
            StageName = stageName;
            FoundersName = foundersName;
            Country = country;
            Genre = genre;
            YearFormed = yearFormed;
            DebutYear = debutYear;
            IsActive = isActive;
            SupportUkraine = supportUkraine;
            EndYear = endYear;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"\nСценічне ім'я: {StageName}");
            Console.WriteLine($"Ім'я засновника: {FoundersName}");
            Console.WriteLine($"Країна: {Country}");
            Console.WriteLine($"Музичний жанр: {Genre}");
            Console.WriteLine($"Рік заснування: {YearFormed}");
            Console.WriteLine($"Рік дебюту: {DebutYear}");
            Console.WriteLine($"Активний: {(IsActive ? "Так" : "Ні")}");
            if (!IsActive && EndYear.HasValue)
            {
                Console.WriteLine($"Роки активності: {YearFormed} - {EndYear}");
            }
            Console.WriteLine($"Підтримує Україну: {(SupportUkraine ? "Так" : "Ні")}");
            if (IsActive)
            {
                Console.WriteLine($"Кар'єра триває {DateTime.Now.Year - DebutYear} років");
            }
        }
    }
}