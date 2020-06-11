using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t=0;
            string s;
            Console.WriteLine("Введите возраст");
            s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            if ((n >= 0) && (n < 7))
            {
                Console.WriteLine("Дошкольник");
                t = 1;
            }
            if ((n >= 8) && (n < 18))
            {
                Console.WriteLine("Школьник");
                t = 2;
            }
            if (n >= 19 && n < 23)
            {
                Console.WriteLine("Студент");
                t = 3;
            }
            if (n >= 24 && n < 64)
            {
                Console.WriteLine("Работяга");
                t = 4;
            }
            if (n >= 65 && n < 100)
            {
                Console.WriteLine("Дед");
                t = 5;
            }

            Console.WriteLine("Льготные поездки в общевственном транспорте выдают только дошкольникам и дедам.");
            Console.WriteLine("Доступ к льготным поездкам:");
            if (t == 1 || t == 5)
            {
                Console.WriteLine("Есть");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
    }
       
    }
