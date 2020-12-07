using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadranteDelPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            int coordx, coordy;
            string linea;

            Console.Write("Ingrese el valor de coord. en el plano X, que no sea cero: ");
            linea = Console.ReadLine();

            coordx = int.Parse(linea);

            Console.Write("Ingrese el valor de coord. en el plano Y, que no sea cero: ");
            linea = Console.ReadLine();

            coordy = int.Parse(linea);

            if (coordx > 0 && coordy > 0)
                Console.WriteLine($"El punto ({coordx},{coordy}) se encuentra en el Primer Cuadrante");
            
            else if (coordx< 0 && coordy > 0)
                Console.WriteLine($"El punto ({coordx},{coordy}) se encuentra en el Segundo Cuadrante");
            
            else if (coordx < 0 && coordy < 0)
                Console.WriteLine($"El punto ({coordx},{coordy}) se encuentra en el Tercer Cuadrante");

            else 
                Console.WriteLine($"El punto ({coordx},{coordy}) se encuentra en el Cuarto Cuadrante");

            Console.ReadKey();
        }
    }
}
