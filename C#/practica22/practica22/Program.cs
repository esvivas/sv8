using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 6;
            sumaUno(k);
            Console.WriteLine("La variable k = " + k);
            sumaOtro(ref k);
            pongaDoscientos(ref k);
            Console.WriteLine("La variable k = " + k);
            
            Console.ReadKey();
        }

        static void sumaUno(int x)
        {
            x++;
            Console.WriteLine("La variable x = " + x);
        }

        static void sumaOtro(ref int p)
        {
            p++;
            Console.WriteLine("La variable p = " + p);
        }

        static void pongaDoscientos(ref int z)
        {
            z = 200;
            Console.WriteLine("La variable z = " + z);
        }
    }
}
