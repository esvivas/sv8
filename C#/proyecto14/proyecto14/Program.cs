using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciclo 1");
            for(int k = 0; k <= 10; k++)
            {
                Console.Write("\t k = " + k);
            }
            Console.WriteLine("\nCiclo 2");
            int p = 1;
            for (; p <= 10; p++)
            {
                Console.Write("\t p = " + p);
            }
            Console.WriteLine("\nCiclo 3");
            int x = 1;
            for (; x <= 10;)
            {
                Console.Write("\t x = " + x);
                x++;
            }
            Console.WriteLine("\nCiclo 4");
            int y = 1;
            for (; ;)
            {   
                if (y <= 10)
                {
                    Console.Write("\t y = " + y);
                    y++;
                }
            }

            Console.WriteLine("\n Ciclo 5");
            for (int i = 0; i <= 10; Console.Write("\t i = " + i++) );

        }
    }
}
