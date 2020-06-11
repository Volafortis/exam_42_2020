using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст");
            int n = Console.Read();
            if (n >= 0 && n <= 7)
            {
                Console.WriteLine("Дошкольник");
                Console.ReadKey();
            }
            else if (n >= 8 && n <= 18)
            {
                Console.WriteLine("Школьник");
                Console.ReadKey();
            }
            else if (n >= 19 && n <= 23)
            {
                Console.WriteLine("Студент");
                Console.ReadKey();
            }
            else if (n >= 24 && n <= 65)
            {
                Console.WriteLine("Работяга");
                Console.ReadKey();
            }
            else if (n >= 65 && n <= 100)
            {
                Console.WriteLine("Дед инсайд");
                Console.ReadKey();
            }
            else if (n >= 100 && n <= 120)
            {
                Console.WriteLine("Жмых");
                Console.ReadKey();
            }
        }
    }
}