using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var propietario = new Propietario("Jazmin");

            var edificio = new Edificio("Guido 119, Tandil", 6, 4);
            
            edificio.Muestra();

            propietario.MostrarPropiedad();

            propietario.AdicionarPropiedad(edificio);

            propietario.MostrarPropiedad();

            Console.ReadKey(); 
                
        }
    }
}
