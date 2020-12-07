using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosPorValor2
{
    class Program
    {
        public int MostrarMayor(int v1, int v2, int v3)
        {
            if (v1 >= v2 && v1 >= v3)
            {
                return v1;
            }
            else if (v2 >= v3)
            {
                return v2;
            }
            else
            {
                return v3;
            }
        }
        static void Main(string[] args)
        {
            var may = new Program();

            Console.WriteLine("Ingrese el primer valor: ");
            string linea = Console.ReadLine();
            int val1 = int.Parse(linea);

            Console.WriteLine("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            int val2 = int.Parse(linea);

            Console.WriteLine("Ingrese el tercer valor");
            linea = Console.ReadLine();
            int val3 = int.Parse(linea);

            int mayor = may.MostrarMayor(val1, val2, val3);

            Console.WriteLine("El numero mayor de los tres ingresados es: " + mayor);

            Console.ReadKey();
        }
    }
}
