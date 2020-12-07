using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumnosFor
{
    class NotasAlumnosFor
    {
        static void Main(string[] args)
        {
            int aprobados = 0;
            int reprobados = 0;

             for( int f = 1; f < 11; f++)
            {
                Console.Write($"Ingrese la nota del alumno nro. {f}: ");
                string linea = Console.ReadLine();
                int nota = int.Parse(linea);

                if (nota >= 7 )
                {
                    aprobados ++;
                }
                else
                {
                    reprobados++;
                }            
             }

            Console.WriteLine($"{aprobados} alumnos han sido aprobados y {reprobados} han sido reprobados.");

            Console.ReadKey();

        }
    }
}
