using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClase4
{
    class Cuadrado
    {
        private int lado;
        
        public void Inicializar()
        {
            string linea;

            Console.Write("Ingrese el valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }

        public void Imprimir()
        {
            int perimetro = lado * 4;
            int superficie = lado * 2;

            Console.WriteLine($"El cuadrado tiene un perimetro de {perimetro} y una superficie de {superficie}");

            Console.ReadKey();            
        }

        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Inicializar();
            cuadrado.Imprimir();

        }
    }
}
