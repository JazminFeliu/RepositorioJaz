using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutiplosConFor
{
    class MultiplosConFor
    {
        static void Main(string[] args)
        {
            int mul3 = 0;
            int mul5 = 0;
            int mul3y5 = 0;

            for(int f = 0; f < 10; f++)
            {
                Console.Write($"Ingrese el entero número {f+1}: ");
                string linea = Console.ReadLine();
                int valor = int.Parse(linea);
                
                if (valor % 3 == 0 && valor % 5 == 0)
                {
                    mul3y5++;
                    mul3++;
                    mul5++;
                }
                else if (valor % 3 == 0)
                {
                    mul3++;                    
                }
                else if (valor % 5 == 0)
                {
                    mul5++;
                }
            }
            Console.WriteLine($"Ha ingresado {mul5} valores multiplos de 5, {mul3} múltiplos de 3 y {mul3y5} múltiplos de ambos.");

            Console.ReadKey();

        }
    }
}
