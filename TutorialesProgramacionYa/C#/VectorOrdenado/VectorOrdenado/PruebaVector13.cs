using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOrdenado
{
    class PruebaVector13
    {
        private int[] _sueldo;

        static void Main(string[] args)
        {
            PruebaVector13 pv = new PruebaVector13();
            pv.Cargar();
            pv.Ordenar();
            pv.Imprimir();

            Console.ReadKey();
        }

        public void Cargar()
        {
            _sueldo = new int[5];

            for (int f=0; f<_sueldo.Length; f++)
            {
                Console.Write("Ingrese el sueldo: ");
                string linea = Console.ReadLine();
                _sueldo[f] = int.Parse(linea);
            }
        }

        public void Ordenar()
        {
            for(int k = 0; k < 4; k++)
            {
                for(int f = 0; f<4-k; f++)
                {
                    if(_sueldo[f]> _sueldo[f+1])
                    {
                        int aux = _sueldo[f];
                        _sueldo[f] = _sueldo[f + 1];
                        _sueldo[f + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("El vector ordenado de menor a mayor es:");

            for(int f =0; f<_sueldo.Length; f++ )
            {
                Console.WriteLine($"Vector en posicion {f + 1}:{ _sueldo[f]}");
            }
        }
    }
}
