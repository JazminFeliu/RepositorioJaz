using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorMenor
{
    class MayorMenor
    {
        static void Main(string[] args)
        {
            MayorMenor maymen = new MayorMenor();
            maymen.CargarValores();

            Console.ReadKey();

        }
        public void CargarValores()
        {
            string linea;
            
            Console.Write("Ingrese el primer valor entero: ");
            linea = Console.ReadLine();
            int valor1 = int.Parse(linea);

            Console.Write("Ingrese el segundo valor entero: ");
            linea = Console.ReadLine();
            int valor2 = int.Parse(linea);

            Console.Write("Ingrese el tercer valor entero: ");
            linea = Console.ReadLine();
            int valor3 = int.Parse(linea);

            int mayor, menor;

            mayor = CalcularMayor(valor1, valor2, valor3);

            menor = CalcularMenor(valor1, valor2, valor3);

            Console.WriteLine("El mayor valor de los tres es: " + mayor);
            Console.WriteLine("El menor valor de los tres es: " + menor);
        }

        public int CalcularMenor(int v1, int v2, int v3)
        {
            int min;
            if (v1 < v2 && v1 < v3)
            {
                min = v1;
            }
            else if (v2< v3)
            {
                min = v2;
            }
            else
            {
                min = v3;
            }

            return min;
        }

        public int CalcularMayor(int v1, int v2, int v3)
        {
            int may;
            if (v1 > v2 && v1 > v3)
            {
                may = v1;
            }
            else if (v2 > v3)
            {
                may = v2;
            }
            else
            {
                may = v3;
            }

            return may;
        }
        
    }
}
