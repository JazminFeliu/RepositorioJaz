using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioTresNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            string linea;

            Console.Write("Ingrese la primer nota del alumno: ");
            linea = Console.ReadLine();
            nota1 = float.Parse(linea);

            Console.Write("Ingrese la segunda nota del alumno: ");
            linea = Console.ReadLine();
            nota2 = float.Parse(linea);

            Console.Write("Ingrese la tercera nota del alumno: ");
            linea = Console.ReadLine();
            nota3 = float.Parse(linea);

            promedio = (nota1 + nota2 + nota3) / 3;
            
            if (promedio >= 7)
            {
                Console.WriteLine($"El alumno ha promocionado la materia con un promedio de {promedio}");
            }
            else if (promedio < 4)
            {
                Console.WriteLine($"El alumno ha reprobado con un promedio de {promedio}");
            }
            else
            {
                Console.WriteLine($"El alumno tiene un promedio regular de {promedio}");
            }

            Console.ReadKey();

        }
    }
}
