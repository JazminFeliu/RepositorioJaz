using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClase3
{
    class PuntoEnElPlano
    {
        private int x, y;

        public void Inicializar()
        {
            string linea;

            Console.Write("Ingrese el valor de la coordenada x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);

            Console.Write("Ingrese el valor de la coordenada y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }

        public void Imprimir()
        {
            if (x>0 && y>0)
            {
                Console.WriteLine($"el punto ({x},{y}) se encuentra en el primer cuadrante");
            }
            else if (y<0)
            {
                Console.WriteLine($"el punto ({x},{y}) se encuentra en el tercer cuadrante");
            }
            else if (x<0)
            {
                Console.WriteLine($"el punto ({x},{y}) se encuentra en el segundo cuadrante");
            }
            else
            {
                Console.WriteLine($"el punto ({x},{y}) se encuentra en el cuarto cuadrante");
            }            
        }              

        static void Main(string[] args)
        {
            PuntoEnElPlano punto = new PuntoEnElPlano();
            punto.Inicializar();
            punto.Imprimir();

            Console.ReadKey();
        }
    }
}
