using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona.presentacion();
            Persona.descripcion = "Experto en Terapia Visual y Distracción Ocupacional";
            Persona.nombre_empleo = "psicología";
            Console.WriteLine("Empleo: " + Persona.nombre_empleo);
            Console.WriteLine("Descripción: " + Persona.descripcion);

            Console.ReadKey();
        }
    }
    class Persona
    {
        private string nombre;
        private string apellido;
        public static string nombre_empleo;
        public static string descripcion;

        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre;
        }

        public static void presentacion()
        {
            Console.WriteLine("Colegio Rural Pandillitas del Norte");
            Console.WriteLine("Nombre: Elba Tracio");
        }
    }
}
