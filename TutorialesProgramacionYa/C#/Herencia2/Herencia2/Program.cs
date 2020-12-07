using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona();

            Console.Write("Ingrese el nombre: ");
            persona1.Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            string linea = Console.ReadLine();
            persona1.Edad = int.Parse(linea);

            Console.WriteLine("Los datos de la persona son:");
            persona1.Imprimir();

            var empleado1 = new Empleado();

            Console.Write("Ingrese el nombre del empleado: ");
            empleado1.Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del empleado: ");
            linea = Console.ReadLine();
            empleado1.Edad = int.Parse(linea);

            Console.Write("Ingrese el sueldo del empleado: ");
            linea = Console.ReadLine();
            empleado1.Sueldo = float.Parse(linea);

            Console.WriteLine("Los datos del empleado son:");
            empleado1.Imprimir();

            Console.ReadKey();
        }
    }
}
