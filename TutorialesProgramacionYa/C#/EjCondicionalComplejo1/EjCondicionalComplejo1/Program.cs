using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjCondicionalComplejo1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, suma, diferencia, producto, division;
            string linea;

            Console.Write("Ingrese el primer valor a comparar: ");
            linea = Console.ReadLine();

            num1 = float.Parse(linea);

            Console.Write("Ingrese el segundo valor a comparar: ");
            linea = Console.ReadLine();

            num2 = float.Parse(linea);

            if (num1 > num2)
            {
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.WriteLine($"La suma de {num1} y {num2} es de {suma} y su diferencia es {diferencia}");
            }
            else
            {
                producto = num1 * num2;
                division = num1 / num2;
                Console.WriteLine($"El producto de {num1} y {num2} es {producto} y su division {division}");
            }
            Console.ReadKey();
        }
    }
}
