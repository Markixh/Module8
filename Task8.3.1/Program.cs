using Module8.Library;

namespace Task8_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile rf = new ReadFile(@"D:\Андрей\Программирование\C#\SF\Module8\Module8.Library\ReadFile.cs");
            rf.Write();
            rf.Read();
            Console.ReadKey();
        }
    }
}