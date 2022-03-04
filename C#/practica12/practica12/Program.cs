using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica12
{
    internal class Program
    {
        enum baraja { CORAZONES, DIAMANTES, TREBOLES, PICAS};
        static void Main(string[] args)
        {
            baraja cartas = baraja.CORAZONES;
            string color;
            switch (cartas)
            {
                case baraja.CORAZONES:
                    color = "ROJO";
                    break;
                case baraja.DIAMANTES:
                    color = "ROJO";
                    break;
                case baraja.TREBOLES:
                    color = "NEGRO";
                    break;
                case baraja.PICAS:
                    color = "NEGRO";
                    break;
                default: 
                    color = "blanco";
                    break;
            }

            Console.WriteLine("Su carta "+cartas +" es de color " + color);
            Console.ReadKey();
        }
    }
}
