using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace practica27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensaje mensaje = new Mensaje();

            Thread hilo1 = new Thread(new ThreadStart(mensaje.mostrarUno));
            hilo1.Start();
            Thread hilo2 = new Thread(new ThreadStart(mensaje.mostrarDos));
            hilo2.Start();
            Console.ReadKey();
        }
    }

    class Mensaje
    {
        public void mostrarUno()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("M1");
                Thread.Sleep(1000);
            }
        }

        public void mostrarDos()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("M2");
                Thread.Sleep(900);
            }
        }
    }
}
