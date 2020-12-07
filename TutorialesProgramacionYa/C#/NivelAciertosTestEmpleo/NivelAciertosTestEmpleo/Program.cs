using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAciertosTestEmpleo
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalpreguntas, totalrespuestasbien, porcentaje;
            string linea;

            Console.Write("Ingrese la cantidad de preguntas del test laboral: ");
            linea = Console.ReadLine();

            totalpreguntas = int.Parse(linea);

            Console.Write("Ingrese la cantida de respuestas correctas: ");
            linea = Console.ReadLine();

            totalrespuestasbien = int.Parse(linea);

            porcentaje = totalrespuestasbien * 100 / totalpreguntas;

            if (porcentaje < 50)
            {
                Console.WriteLine("Fuera de nivel");
            }
            else if (porcentaje < 75)
            {
                Console.WriteLine("Nivel Regular");
            }
            else if (porcentaje < 90)
            {
                Console.WriteLine("Nivel Medio");
            }
            else
            {
                Console.WriteLine("Nivel Máximo.");
            }
            Console.ReadKey();
        }
    }
}
