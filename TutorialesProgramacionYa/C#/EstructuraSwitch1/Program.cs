using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSwitch1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor entre el 1 y el 5: ");
            string linea = Console.ReadLine();
            int valor = int.Parse(linea);

            switch(valor)
            {
                case 1: Console.Write("Uno");
                    break;
                case 2: Console.Write("Dos");
                    break;
                case 3: Console.Write("Tres");
                    break;
                case 4: Console.Write("Cuatro");
                    break;
                case 5: Console.Write("Cinco");
                    break;
                default:
                    Console.Write("Se ingresó un valor fuera de rango");
                    break;
            }

            Console.ReadKey();
        }
    }
}
