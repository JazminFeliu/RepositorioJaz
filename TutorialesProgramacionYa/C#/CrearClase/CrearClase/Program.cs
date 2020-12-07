using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearClase
{
    class Persona
    {
        private string nombre;
        private int edad;

        public void Inicializar()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            string linea;

            Console.Write($"Ingrese la edad de {nombre}: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine($"{nombre} tiene {edad} años");
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
                Console.WriteLine($"{nombre} es mayor de edad");
            else
                Console.WriteLine($"{nombre} no es mayor de edad");

            Console.ReadKey();
        }

        static void Main (string[] args)
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();
        }
    }
}
