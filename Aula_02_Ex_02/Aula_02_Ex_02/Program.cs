using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Primeiro numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Terceiro numero: ");
            c = int.Parse(Console.ReadLine());

            if(a > b && a > c)
            {
                if(b > c)
                    Console.Write("{0}, {1}, {2}", c, b, a);
                else
                    Console.Write("{0}, {1}, {2}", b, c, a);
            }
            if (b > a && b > c)
            {
                if (a > c)
                    Console.Write("{0}, {1}, {2}", c, a, b);
                else
                    Console.Write("{0}, {1}, {2}", a, c, b);
            }

            if (c > a && c > b)
            {
                if (a > b)
                    Console.Write("{0}, {1}, {2}", b, a, c);
                else
                    Console.Write("{0}, {1}, {2}", a, b, c);
            }

            Console.Read();
        }
    }
}
