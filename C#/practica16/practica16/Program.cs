using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De número ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
            {
                goto Par;
            }
            else
            {
                goto Impar;
            }


        Par:
            Console.WriteLine("El número es par.");
            goto Fin;
        Impar:
            Console.WriteLine("El número es impar.");
        Fin:;
            Console.ReadKey();
        }
    }
}
