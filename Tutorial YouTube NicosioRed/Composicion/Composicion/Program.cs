using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    class Program
    {
        static void Main(string[] args)
        {
            var edificio = new Edificio("Galicia 670", 10, 8);
            edificio.Mostrar();

            var propietario = new Propietario("Estrella");
            propietario.MostrarPropiedad();

            Console.ReadKey();
        }
    }
}
