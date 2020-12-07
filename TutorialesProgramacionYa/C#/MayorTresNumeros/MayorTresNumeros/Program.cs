using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3;
            string linea;

            Console.Write("Ingrese el primer número: ");
            linea = Console.ReadLine();

            num1 = float.Parse(linea);

            Console.Write("Ingrese el segundo número: ");
            linea = Console.ReadLine();

            num2 = float.Parse(linea);

            Console.Write("Ingrese el tercer número: ");
            linea = Console.ReadLine();

            num3 = float.Parse(linea);

            if ((num1 >= num2) && (num1 >= num3))
            {
                Console.WriteLine($"El número {num1} es el mayor.");
            }
            else if (num2 >= num3 )
            {
                Console.WriteLine($"El número {num2} es el mayor.");
            }
            else
            {
                Console.WriteLine($"El número {num3} es el mayor.");
            }
            Console.ReadKey();

        }
    }
}
