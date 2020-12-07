using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga10valoresWhileSumaPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, num, suma, promedio;
            string linea;
            suma = 0;
            x = 1;

            while (x <= 10)
            {
                Console.Write($"Ingrese el número {x}: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                suma = num + suma;
                x++;
            }

            promedio = suma / 10;

            Console.Write($"la suma de los números ingresados es de {suma} y su promedio {promedio}.");

            Console.ReadKey();
        }
    }
}
