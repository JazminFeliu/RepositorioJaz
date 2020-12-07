using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTipoCola1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cola1 = new Cola();
            cola1.Insertar(3);
            cola1.Insertar(34);
            cola1.Insertar(43);
            cola1.Insertar(8);
            cola1.Insertar(7);

            cola1.Imprimir();

            Console.WriteLine("Estraemos de la cola: " + cola1.Extraer());
            
            cola1.Imprimir();

            Console.ReadKey();
        }
    }
}
