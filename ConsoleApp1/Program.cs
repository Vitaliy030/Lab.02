using System;

namespace ConsoleApp1
{
    public class Program
    {
        static public string Convert(int x)
        {
            string n;
            switch (x)
            {
                case 10: n = "Десять"; break;
                case 11: n = "Одинадцять"; break;
                case 12: n = "Дванадцять"; break;
                case 13: n = "Тринадцять"; break;
                case 14: n = "Чотирнадцять"; break;
                case 15: n = "П'ятнадцять"; break;
                case 16: n = "Шiстнадцять"; break;
                case 17: n = "Сiмнадцять"; break;
                case 18: n = "Вiсiмнадцять"; break;
                case 19: n = "Дев'ятнадцять"; break;
                case 20: n = "Двадцять"; break;
                default: n = "NULL"; break;
            }
            return n;
        }
        static public void Main(string[] args)
        {
            string p;
            Console.WriteLine("Введiть число в межах вiд 10 до 20:");
            int a = int.Parse(Console.ReadLine());
            if (a >= 10 && a <= 20)
            {
                p = Convert(a);
                Console.WriteLine("\nПеретворення:\n" + a + " - " + p);
            }
            else
                Console.WriteLine("\nВи ввели некоректне значення!");
        }
    }
}
