using System.IO;

namespace Module8.Library
{
    public class ReadFile
    {
        string FilePath;

        public ReadFile(string filepath)
        {
            FilePath = filepath;
        }

        public void Read()
        {            
            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(FilePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                {
                    Console.WriteLine(str);
                }
            }
        }

        public void Write()
        {
            var fileInfo = new FileInfo(FilePath);
            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($@"//{DateTime.Now}");
            }
        }
    }
}
//24.10.2022 22:33:22
