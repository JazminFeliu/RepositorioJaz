using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSueldosLength
{
    class SueldoConLength
    {
        private int[] _sueldo;

        static void Main(string[] args)
        {
            SueldoConLength scl = new SueldoConLength();
            scl.CargarSueldos();
            scl.ImprimirSueldos();

            Console.ReadKey();
        }

        public void CargarSueldos()
        {
            Console.Write("Ingrese la cantidad de sueldos que se procesarán: ");
            string linea = Console.ReadLine();
            int cant = int.Parse(linea);

            _sueldo = new int[cant];

            for (int f = 0; f < _sueldo.Length; f++)
            {
                Console.Write($"Ingrese el sueldo nro. {f + 1}: ");
                linea = Console.ReadLine();
                _sueldo[f] = int.Parse(linea);
            }
        }

        public void ImprimirSueldos()
        {
            Console.Write($"Listado de Sueldos ingresados: ");

            for (int f = 0; f < _sueldo.Length; f++)
            {
                Console.Write($"$ {_sueldo[f]} -");
            }
        }

    }
}
