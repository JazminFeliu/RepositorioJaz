using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSueldos
{
    class AlmacenarSueldosEnVector
    {
        private int[] _sueldos;
                
        static void Main(string[] args)
        {
            AlmacenarSueldosEnVector sv = new AlmacenarSueldosEnVector();
            sv.CargarSueldos();
            sv.Imprimir();
        }

        public void CargarSueldos()
        {
            _sueldos = new int[5];
            string linea;

            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese los sueldos de los ultimos 5 meses del empleado: ");
                linea = Console.ReadLine();
                _sueldos[f] = int.Parse(linea);
            }       

        }

        public void Imprimir()
        {
            for( int f = 0; f < 5; f++)
            {
                Console.WriteLine($"El sueldo {f+1} es {_sueldos[f]}.");
            }
            Console.ReadKey();

        }
    }
}
