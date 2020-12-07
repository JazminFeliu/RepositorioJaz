using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaPrimerTrimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;
            string linea;

            Console.Write("Ingrese el dia en formato numérico: ");
            linea = Console.ReadLine();

            dia = int.Parse(linea);

            Console.Write("Ingrese el mes en formato numérico: ");
            linea = Console.ReadLine();

            mes = int.Parse(linea);

            Console.Write("Ingrese el año en formato numérico: ");
            linea = Console.ReadLine();

            anio = int.Parse(linea);

            if ((mes == 1) || (mes == 2) || (mes == 3))
            {
                Console.WriteLine("La fecha ingresada corresponde al primer trimestre del año");
            }
            else
            {
                Console.WriteLine("La fecha ingresada no coresponde al primer trimestre del año");
            }

            Console.ReadKey();

        }
    }
}
