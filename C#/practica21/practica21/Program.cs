using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            saludar(500);
            Console.ReadKey();
        }

        public static void saludar(int dinero)
        {
            if(dinero < 200)
            {
                return;
            }
            Console.WriteLine("A cómo el pandebono... a 1500 con tinto");
        }
    }
}
