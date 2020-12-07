using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades3
{
    class Program
    {
        static void Main(string[] args)
        {
            var club = new Club();

            club.CalcularMayorAntiguedad();
            
            Console.ReadKey();
        }
    }
}
