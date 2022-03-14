using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            piramideDelPandebono(200, 300, 0, 2000);
            Console.ReadKey();
        }

        static void piramideDelPandebono(params long[] vaca)
        {
            long total_vaca = 0;
            for (int i = 0; i < vaca.Length; i++)
            {
                total_vaca += vaca[i];
            }
            Console.WriteLine("Se recogió $" + total_vaca);
        }
    }

}
