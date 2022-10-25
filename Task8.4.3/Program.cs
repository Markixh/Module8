using Module8.Library;
using System.Runtime.Serialization.Formatters.Binary;
using System;

namespace Task8_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new("Андрей", 91921995, "Andr@ru");
            Console.WriteLine("Объект создан");

            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (var fs = new FileStream("myContact.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
                Console.WriteLine("Объект сериализован");
            }
            // десериализация
            using (var fs = new FileStream("myContact.dat", FileMode.Open))
            {
                var newContact = (Contact)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newContact.Name} --- Телефон: {newContact.PhoneNumber} --- Email: {newContact.Email}");
            }
            Console.ReadLine();
        }
    }
}