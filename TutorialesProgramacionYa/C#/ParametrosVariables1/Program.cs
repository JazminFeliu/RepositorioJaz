using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosVariables1
{
    class Program
    {
        public int Sumar(params int[] p)
        {
            int su = 0;
            
            for(int f=0; f<p.Length; f++)
            {
                su = su + p[f];
            }
            return su;
        }

        static void Main(string[] args)
        {
            var p = new Program();

            Console.Write("La suma de 3,4,5, 6,7,7 es: ");
            Console.WriteLine(p.Sumar(3, 4, 5,6,7,7));

            Console.ReadKey();
        }
    }
}
