using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteroUnooDosDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;

            Console.Write("Ingrese un numero entero de uno o dos dígitos: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            if (num < 10)
            {
                Console.WriteLine($"El número {num} tiene un solo dígito");
            }
            else
            {
                Console.WriteLine($"El número {num} tiene dos dígitos");
            }

            Console.ReadKey();
        }
    }
}
