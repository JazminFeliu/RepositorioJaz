using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVectores2
{
    class GastoPorTurno
    {
        private float[] _sueldosTM;
        private float[] _sueldosTT;

       
        static void Main(string[] args)
        {
            GastoPorTurno gt = new GastoPorTurno();
            
            gt.CargarSueldos();
            gt.GastosPorTurno();

            Console.ReadKey();
        }

        public void CargarSueldos()
        {
            string linea;
            
            _sueldosTM = new float[4];
            _sueldosTT = new float[4];
            
            for (int f = 0; f < 4; f++)
            {
                Console.Write($"Ingrese el sueldo del empleado {f + 1} del turno mañana: ");
                linea = Console.ReadLine();
                _sueldosTM[f] = float.Parse(linea);
            }

            for (int f = 0; f < 4; f++)
            {
                Console.Write($"Ingrese el sueldo del empleado {f + 1} del turno tarde: ");
                linea = Console.ReadLine();
                _sueldosTT[f] = float.Parse(linea);
            }
        }
   

        public void GastosPorTurno()
        {
            float gastosTM = 0;
            float gastosTT = 0;

            for (int f = 0; f < 4; f++)
            {
;               gastosTM = gastosTM + _sueldosTM[f];
                gastosTT = gastosTT + _sueldosTT[f];
            }
            Console.WriteLine($"El Gasto total de Sueldos del turno mañana es de $ {gastosTM}");
            Console.WriteLine($"El Gasto total de Sueldos del turno tarde es de $ {gastosTT}");
        }
       
    }
}
