using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            var pv = new SueldoEmpleados();
            pv.Cargar();
            pv.Imprimir();

        }
    }
}
