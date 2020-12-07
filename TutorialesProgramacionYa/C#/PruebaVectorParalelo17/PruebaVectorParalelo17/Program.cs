using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVectorParalelo17
{
    class Program
    {
        static void Main(string[] args)
        {
            VectorPais vp = new VectorPais();

            vp.Cargar();
            vp.Imprimir();

            Console.ReadKey();
        }
    }
}
