using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantCifrasNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string linea;

            Console.WriteLine("Ingrese un número entero positivo de una, dos o tres cifras: ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            if (valor < 10 )
            {
                Console.WriteLine($"El valor {valor} tiene una cifra.");
            }
            else if (valor < 100)
            {
                Console.WriteLine($"El valor {valor} tiene dos cifras.");
            }
            else if (valor < 1000)
            {
                Console.WriteLine($"El valor {valor} tiene tres cifras.");
            }
            else
            {
                Console.WriteLine("Ha ingresado un valor fuera del rango solicitado");
            }

            Console.ReadKey();
        }
    }
}
