using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosPorValor1
{
    class Program
    {
        public void MostrarRango(int menor, int mayor)
        {
            for (var x=menor; x<= mayor; x++)
            {
                Console.Write(x + "-");
            }
        }

        static void Main(string[] args)
        {
            var pro = new Program();
            pro.MostrarRango(2, 147);

            Console.ReadKey();
        }
    }
}
