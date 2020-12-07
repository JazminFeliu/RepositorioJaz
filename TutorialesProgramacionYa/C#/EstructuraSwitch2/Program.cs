using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero del uno al cinco escrito: ");
            string linea = Console.ReadLine();

            switch(linea)
            {
                case "uno": Console.Write(1);
                    break;
                case "dos": Console.Write(2);
                    break;
                case "tres": Console.Write(3);
                    break;
                case "cuatro": Console.Write(4);
                    break;
                case "cinco": Console.Write(5);
                    break;
                default:
                    Console.WriteLine("El valor ingresado se encuentra fuera de rango");
                    break;
            }

            Console.ReadKey();
        }
    }
}
