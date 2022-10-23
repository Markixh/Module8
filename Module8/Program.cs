namespace Module8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetCatalogsCount(); //   Вызов метода получения директорий

            CreatCatalog("test");

            GetCatalogsCount(); //   Вызов метода получения директорий
        }

        static void GetCatalogs()
        {
            string dirName = @"D:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
            }
        }

        static void GetCatalogsCount()
        {
            string dirName = @"D:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                Console.WriteLine(dirs.Length); // Количество каталогов

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                Console.WriteLine(files.Length); // Количество файлов
            }
        }

        static void CreatCatalog(string name)
        {
            string dirName = @"D:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            if (!dirInfo.Exists)
                Console.WriteLine("Каталог отсутствует");
            DirectoryInfo newDirectory = new DirectoryInfo(@"/" + name);
            if (!newDirectory.Exists)
                newDirectory.Create();
        }
    }
}