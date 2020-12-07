using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosVariables2
{
    class Program
    {
        public int Sumar(params int[] p)
        {
            int su = 0;
            for (int f=0; f<p.Length; f++)
            {
                su = su + p[f];
            }
            return su;
        }

        public int Multiplicar(params int[] p)
        {
            int mul = p[0];
            for(int f=1; f<p.Length; f++)
            {
                mul = mul * p[f];
            }
            return mul;
        }

        
        static void Main(string[] args)
        {
            var op = new Program();

            Console.WriteLine("Ingrese la operacion que realizará (suma/multiplicacion): ");
            string ope = Console.ReadLine();

            Console.WriteLine("Los valores 3, 4,5,7,5 serán operados");

            if(ope == "suma")
            {

                Console.WriteLine("El total sumado es:" + op.Sumar(3, 4, 5, 7, 5));
            }
            else
            {
                Console.WriteLine("El total multiplicado es:" + op.Multiplicar(3, 4, 5, 7, 5));
            }

            Console.ReadKey();
        }
    }
}
