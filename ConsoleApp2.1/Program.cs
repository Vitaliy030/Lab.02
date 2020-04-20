using System;

namespace ConsoleApp2._1
{
    public class Program
    {
        static public double Calculation(double x)
        {
            double z = Math.Pow(x, 1.0/4.0);
            return z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Результати обчислення функцiї y = f(x) на промiжку [1.25, 6.75] з кроком dx = 0.25.\n\tx\t\ty = f(x)");
            double x = 1.25;
            double y;
            while (x <= 6.75)
            {
                y = Calculation(x);
                Console.WriteLine("\t{0}\t\t{1}", x, y);
                x += 0.25;
            }
        }
    }
}
