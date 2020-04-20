using System;

namespace ConsoleApp5._1
{
    public class Program
    {
        static public int is_number(string input)
        {
            bool a = true;
            while (a)
            {
                int d = input.Length;
                foreach (char c in input)
                    if (char.IsNumber(c))
                    {
                        if ((input[0] == '0') && (d != 1))
                        {
                            Console.WriteLine("Ви ввели некоректне значення, введiть нове:\n");
                            input = Console.ReadLine();
                            a = true;
                            break;
                        }
                        a = false;
                    }
                    else if ((input[0] == '-') && (d != 1) && (input[1] != '-'))
                        continue;
                    else
                    {
                        Console.WriteLine("Ви ввели некоректне значення, введiть нове:");
                        input = Console.ReadLine();
                        a = true;
                        break;
                    }
            }

            return Convert.ToInt32(input);
        }

        static public int product(int[,] h, int p1, int t1, int p2, int t2)
        {
            int d = h[p1, t1] * h[p2, t2];
            return d;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть зi скiлькох рядкiв складається масив:");
            string n = Console.ReadLine();
            int n0 = is_number(n);

            while (n0 < 1)
            {
                Console.WriteLine("Ви ввели некоректне значення, введiть нове:");
                n = Console.ReadLine();
                n0 = is_number(n);
            }

            Console.WriteLine("Введiть зi скiлькох стовпчикiв складається масив:");
            string m = Console.ReadLine();
            int m0 = is_number(m);

            while (m0 < 1)
            {
                Console.WriteLine("Ви ввели некоректне значення, введiть нове:");
                m = Console.ReadLine();
                m0 = is_number(m);
            }

            int[,] a = new int[n0, m0];

            Console.WriteLine("\nВведiть значення елементiв масиву:");

            for (int i = 0; i < n0; ++i)
                for (int j = 0; j < m0; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i + 1, j + 1);
                    string a0 = Console.ReadLine();
                    int a00 = is_number(a0);
                    a[i, j] = a00;
                }

            Console.WriteLine("\nМатриця А має вигляд:");
            for (int i = 0; i < n0; i++)
            {
                for (int j = 0; j < m0; j++)
                    Console.Write("{0}\t", a[i, j]);
                Console.Write("\n\n\n");
            }

            Console.WriteLine("Введiть номер рядка першого вибраного елемента:");
            string p01 = Console.ReadLine();
            int p1 = is_number(p01);

            while ((p1 < 1) || (p1 > n0))
            {
                Console.WriteLine("Ви ввели некоректне значення, введiть нове:");
                p01 = Console.ReadLine();
                p1 = is_number(p01);
            }

            Console.WriteLine("Введiть номер стовпчика першого вибраного елемента:");
            string t01 = Console.ReadLine();
            int t1 = is_number(t01);

            while ((t1 < 1) || (t1 > m0))
            {
                Console.WriteLine("Ви ввели некоректне значення, введiть нове:");
                t01 = Console.ReadLine();
                t1 = is_number(t01);
            }

            Console.WriteLine("Введiть номер рядка другого вибраного елемента:");
            string p02 = Console.ReadLine();
            int p2 = is_number(p02);

            while ((p2 < 1) || (p2 > n0))
            {
                Console.WriteLine("Ви ввели некоректне значення, введiть нове:");
                p02 = Console.ReadLine();
                p2 = is_number(p02);
            }

            Console.WriteLine("Введiть номер стовпчика другого вибраного елемента:");
            string t02 = Console.ReadLine();
            int t2 = is_number(t02);

            while ((t2 < 1) || (t2 > m0))
            {
                Console.WriteLine("Ви ввели некоректне значення, введiть нове:");
                t02 = Console.ReadLine();
                t2 = is_number(t02);
            }

            p1 -= 1;
            t1 -= 1;
            p2 -= 1;
            t2 -= 1;

            int d = product(a, p1, t1, p2, t2);
            Console.WriteLine("\nОбранi елементи:\n1. a[{0},{1}] = {2}\n2. a[{3},{4}] = {5}\n\nДобуток вказаних елементiв масиву:\n" + d, p1 + 1, t1 + 1, a[p1, t1], p2 + 1, t2 + 1, a[p2, t2]);
        }
    }
}
