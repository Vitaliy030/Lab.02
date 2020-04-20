using System;

namespace ConsoleApp3._1
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

        static public int min_element(int[] h, int p)
        {
            bool a = true;
            int min = Math.Abs(h[0]);
            for (int i = 0; i < p; ++i)
                if (min > Math.Abs(h[i]))
                {
                    min = Math.Abs(h[i]);
                    if (h[i] < 0)
                        a = false;
                    else
                        a = true;
                }
            if (!a)
                min *= -1;
            return min;
        }

        static public string zero(int[] h, int p)
        {
            int n1 = -1;
            int n2 = -1;
            int d = 1;
            string d0;

            for (int i = 0; i < p; ++i)
                if (h[i] == 0)
                {
                    n1 = i;
                    break;
                }

            for (int i = 0; i < p; ++i)
                if (h[i] == 0)
                    n2 = i;

            if (n1 == n2)
            {
                if (n1 == -1)
                {
                    for (int i = 0; i < p; ++i)
                        d *= h[i];
                    d0 = d.ToString();
                }
                else if (n1 == p - 1)
                    d0 = "-0-";
                else if (n1 == p - 2)
                    d0 = "-1-";
                else
                {
                    for (int i = n1 + 1; i < p; ++i)
                        d *= h[i];
                    d0 = d.ToString();
                }
            }
            else if (n1 == n2 - 1)
                d0 = "-2-";
            else if (n1 == n2 - 2)
                d0 = "-3-";
            else
            {
                for (int i = n1 + 1; i < n2; ++i)
                    d *= h[i];
                d0 = d.ToString();
            }
            return d0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть елементiв масиву:");
            string n = Console.ReadLine();
            int n0 = is_number(n);

            while (n0 < 1)
            {
                Console.WriteLine("Ви ввели некоректне значення, введiть нове:");
                n = Console.ReadLine();
                n0 = is_number(n);
            }

            int[] a = new int[n0];

            Console.WriteLine("\nВведiть значення елементiв масиву:");

            int k = 0;
            for (int i = 0; i < n0; ++i)
            {
                Console.Write("a[{0}] = ", i+1);
                string a0 = Console.ReadLine();
                int a00 = is_number(a0);
                a[i] = a00;
                if (a[i] == 0) ++k;
            }

            int min = min_element(a, n0);
            Console.WriteLine("\nМiнiмальний за модулем елемент масиву: " + min);

            string d;
            int d0;
            if (k == 0)
            {
                d = zero(a, n0);
                d0 = Convert.ToInt32(d);
                Console.WriteLine("\nОскiльки серед елементiв масиву немає зi значенням нуль, то був пiдрахований добуток усiх елементiв масиву:\n" + d0);
            }
            else if (k == 1)
            {
                d = zero(a, n0);
                if (d == "-0-")
                    Console.WriteLine("\nОскiльки елемент масиву зi значенням нуль є останнiм, то добуток елементiв пiсля даного дорiвнює нулю.");
                else if (d == "-1-")
                    Console.WriteLine("\nОскiльки елемент масиву зi значенням нуль є передостаннiй, то добуток елементiв пiсля даного дорiвнює нулю.");
                else
                {
                    d0 = Convert.ToInt32(d);
                    Console.WriteLine("\nОскiльки серед елементiв масиву є лише один зi значенням нудь, то був пiдрахований добуток елементiв розташованих пiсля нього:\n" + d0);
                }
            }
            else
            {
                d = zero(a, n0);
                if (d == "-2-")
                    Console.WriteLine("\nОскiльки перший i останнiй елементи масиву зi значенням нуль розташованi один пiсля одного, то добуток елементiв мiж ними дорiвнює нулю.");
                else if (d == "-3-")
                    Console.WriteLine("\nОскiльки мiж першим i останнiм елементи масиву зi значенням нуль розташований лише один елемент, то добуток елементiв мiж ними дорiвнює нулю.");
                else
                {
                    d0 = Convert.ToInt32(d);
                    Console.WriteLine("\nДобуток елементiв масиву, розташованих мiж першим й останнiм нульовими елементами:\n" + d0);
                }

            }
        }
    }
}
