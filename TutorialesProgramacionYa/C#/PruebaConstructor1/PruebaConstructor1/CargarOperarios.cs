using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConstructor1
{
    public class CargarOperarios
    {
        private int[] _operarios;

        public CargarOperarios()
        {
            _operarios = new int[5];

            for(int f=0; f<5; f++)
            {
                Console.Write($"Ingresar el sueldo del operario nro. {f + 1}: ");
                string linea = Console.ReadLine();
                _operarios[f] = int.Parse(linea);
            }            
        }

        public void  Imprimir()
        {
            for(int f=0; f<5; f++)
            {
                Console.WriteLine($"El operario {f + 1} percibe un sueldo de $ {_operarios[f]}");
            }
            Console.ReadKey();
        }
    }
}
