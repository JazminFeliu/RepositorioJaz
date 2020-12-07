using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlMenosUnNumEsMenorADiez
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;

            Console.Write("Ingrese el primer número:");
            linea = Console.ReadLine();

            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo número:");
            linea = Console.ReadLine();

            num2 = int.Parse(linea);

            Console.Write("Ingrese el tercer número:");
            linea = Console.ReadLine();

            num3 = int.Parse(linea);

            if (num1 < 10 || num2 < 10 || num3 < 10)
                Console.WriteLine("Al menos uno de los valores ingresados es menor a diez");
            else
                Console.WriteLine("Ninguno de los valores ingresados es menor a diez");

            Console.ReadKey();
        }
    }
}
