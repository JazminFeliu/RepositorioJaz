using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurebaVector3
{
    class VectorN
    {
        private int[] _vectorn;
            
        static void Main(string[] args)
        {
            VectorN vn = new VectorN();
            vn.CargarVector();
            vn.ImprimirSuma();

            Console.ReadKey();
        }

        public void CargarVector()
        {
            Console.Write($"Ingrese por favor la cantidad de elementos que tendrá este vector: ");
            string linea = Console.ReadLine();
            int cant = int.Parse(linea);
            _vectorn = new int[cant];

            
            for (int f = 0; f < _vectorn.Length; f++)
            {
                Console.Write($"Ingrese el valor entero nro. {f + 1}: ");
                linea = Console.ReadLine();

                _vectorn[f] = int.Parse(linea);

            }            
        }

        public void ImprimirSuma()
        {
            int suma = 0;
            for (int f = 0; f < _vectorn.Length; f++)
            {
               suma = suma + _vectorn[f];
            }
            Console.WriteLine($"La suma de todos los valores del vector es: {suma}");       
        }            
            
    }

}
