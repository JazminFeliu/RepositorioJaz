using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumPosNulNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string linea;

            Console.Write("Ingrese un valor entero, positivo, cero o negativo: ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            if (valor == 0)
            {
                Console.WriteLine("El valor ingresado es cero.");
            }
            else if (valor > 0)
            {
                Console.WriteLine($"El valor ingresado {valor} es positivo.");
            }
            else
            {
                Console.WriteLine($"El valor ingresado {valor} es negativo.");
            }

            Console.ReadKey();
        }
    }
}
