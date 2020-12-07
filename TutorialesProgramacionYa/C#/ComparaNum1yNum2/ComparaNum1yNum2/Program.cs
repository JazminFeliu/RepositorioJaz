using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaNum1yNum2
{
    class Program
    {
        static void Main(string[] args)
        {
                
            float num1, num2;
            string linea;

            Console.WriteLine("Ingrese el primer numero: ");
            linea = Console.ReadLine();

            num1 = float.Parse(linea);

            Console.WriteLine("Ingrese el segundo número: ");
            linea = Console.ReadLine();

            num2 = float.Parse(linea);

            if (num1 > num2)
            {
                Console.WriteLine($"El numero {num1} es mayor que el {num2}");
            }
            else
            {
                Console.WriteLine($"El número {num2} es mayor que el {num1}");
            }

            Console.ReadKey();


        }
    }
}

