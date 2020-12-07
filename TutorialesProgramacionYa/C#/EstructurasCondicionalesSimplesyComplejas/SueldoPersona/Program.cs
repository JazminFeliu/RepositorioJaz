using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            string linea;

            Console.WriteLine("Ingrese el sueldo del trabajador: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);


            if (sueldo > 3000)
            {
                Console.WriteLine("El trabajador debe abonar impuestos");

            }
            Console.ReadKey();
        }
    }
}