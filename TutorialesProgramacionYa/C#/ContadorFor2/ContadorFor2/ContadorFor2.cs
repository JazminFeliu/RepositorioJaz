using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorFor2
{
    class ContadorFor2
    {
        static void Main(string[] args)
        {
            int suma = 0;
            
           for (int f = 1; f < 11; f++)
            {
                Console.Write($" Ingrese el valor nro. {f}: ");
                string linea = Console.ReadLine();
                int valor = int.Parse(linea);
                suma = suma + valor;
            }

            int promedio = suma / 10;
            Console.WriteLine($"La suma de los números ingresados es de {suma} y su promedio {promedio}.");
            
            Console.ReadKey();                        
        }
    }
}
