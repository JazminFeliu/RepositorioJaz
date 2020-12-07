using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDosClase
{
    class Triangulo
    {
        private int lado1, lado2, lado3;
         
        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese el valor del primer lado del triángulo: ");
            linea = Console.ReadLine();
            lado1 = int.Parse(linea);

            Console.Write("Ingrese el valor del segundo lado del triángulo: ");
            linea = Console.ReadLine();
            lado2 = int.Parse(linea);

            Console.Write("Ingrese el valor del tercer lado del triángulo: ");
            linea = Console.ReadLine();
            lado3 = int.Parse(linea);
        }

        public void Imprimir()
        {
            if (lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine("El primer lado ingresado es el mayor");
            }
            else if (lado2 > lado3)
            {
                Console.WriteLine("El segundo lado es el mayor");
            }
            else
            {
                Console.WriteLine("El tercer lado es el mayor");
            }                                                       
            
            Console.ReadKey();
        }

        public void EsEquilatero()
        {
            if (lado1 == lado2 && lado2 == lado3)

                Console.WriteLine("El triángulo es equilátero");
            else
                Console.WriteLine("El tirángulo no es equilátero");

            Console.ReadKey();
        }

        static void Main (string[] args)
        {
        Triangulo tri = new Triangulo();
        tri.Inicializar();
        tri.Imprimir();
        tri.EsEquilatero();

        }
    }
    
}
