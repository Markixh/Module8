using Microsoft.VisualBasic.FileIO;

namespace Task8_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Dir = "testFolder";
            if (!(args.Length == 0))
                Dir = args[0];
            if (CreatCatalog(String.Concat(GetPathDesktop(), $@"/{Dir}")))
                Console.WriteLine($"{Dir} успешно создан");
            FileSystem.DeleteDirectory("Каталог", UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
            MoveRecycler(String.Concat(GetPathDesktop(), $@"/{Dir}"));
            Console.WriteLine($"{Dir} успешно перемещен в карзину");
        }

        static string GetPathDesktop()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return path;
        }

        static string GetPathRemote()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return path;
        }

        static bool CreatCatalog(string name)
        {
            try
            {
                DirectoryInfo newDirectory = new DirectoryInfo(name);
                if (!newDirectory.Exists)
                {
                    newDirectory.Create();
                    return true;
                }
                else
                    Console.WriteLine("Каталог уже создан");
                return false;
            }
            catch
            {
                Console.WriteLine("Возникла ошибка при удалении каталога");
                return false;
            }
        }

        static void MoveRecycler(string name)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(name);
            string newPath = String.Concat(GetPathRemote(), @"/res");
            try
            {
                if (dirInfo.Exists && !Directory.Exists(newPath))
                    dirInfo.MoveTo(newPath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}