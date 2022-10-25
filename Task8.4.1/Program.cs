namespace Task8_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filename = "BinaryFile.bin";

            Console.WriteLine("Из файла считано:");

            Console.WriteLine(ReadValues(path + @"\" + filename));

            WriteValue(path + @"\" + filename);
        }

        static string ReadValues(string path)
        {
            string str = "";

            if (File.Exists(path))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.                    
                    str = reader.ReadString();
                }
            }
            return str;
        }

        static void WriteValue(string path)
        {
            if (File.Exists(path))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryWriter write = new BinaryWriter(File.Open(path, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.                    
                    write.Write($"Файл изменен {DateTime.Now} на компьютере Windows 10");
                }
            }
        }
    }
}