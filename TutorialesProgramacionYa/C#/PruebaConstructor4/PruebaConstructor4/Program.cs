using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConstructor4
{
    class Program
    {
        static void Main(string[] args)
        {
            var ope = new Operacion(15, 4);
            ope.MultiplicarOpe();
            ope.Imprimir();

            var opeType1 = ope.GetType();

            var ope2 = new Operacion(1, 3);
            ope2.DividirOpe();
            ope2.Imprimir();


            var opeType2 = ope2.GetType();
            
            PropertyInfo pinfo = opeType2.GetProperty("Resultado");

            Console.ReadKey();
        }
    }
}
