using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromocionAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            string linea;

            Console.Write("Ingrese la primera nota del alumno: ");
            linea = Console.ReadLine();

            nota1 = float.Parse(linea);

            Console.Write("Ingrese la segunda nota del alumno: ");
            linea = Console.ReadLine();

            nota2 = float.Parse(linea);

            Console.Write("Ingrese la tercera nota del alumno: ");
            linea = Console.ReadLine();

            nota3 = float.Parse(linea);

            promedio = (nota1 + nota2 + nota3)/3;

            if (promedio > 7)
            {
                Console.WriteLine($"El alumno ha sido promocionado con una nota promedio de {promedio}");
            }
            Console.ReadKey();
        }
    }
}
