using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVectorParalelo17
{
    public class VectorPais
    {
        private string[] _paises;
        private int[] _habitantes;

        public void Cargar()
        {
            _paises = new string[5];
            _habitantes = new int[5];

            Console.WriteLine("Ingreso de paises y habitantes");

            for (int f = 0; f < _paises.Length; f++)
            {
                Console.Write($"Ingrese el pais nro. {f + 1}: ");
                _paises[f] = Console.ReadLine();


                Console.Write($"Ingrese la cantidad de habitantes de {_paises[f]}: ");
                string linea = Console.ReadLine();
                _habitantes[f] = int.Parse(linea);
            }
        }

        public void OrdenarPorPais()
        {
            for (int k = 0; k < 5; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (_paises[f].CompareTo(_paises[f + 1]) > 0)
                    {
                        string auxpais = _paises[f];
                        _paises[f] = _paises[f + 1];
                        _paises[f + 1] = auxpais;

                        int auxhabitantes = _habitantes[f];
                        _habitantes[f] = _habitantes[f + 1];
                        _habitantes[f + 1] = auxhabitantes;
                    }
                }
            }
        }

        public void OrdenarPorHabitante()
        {
            for (int k = 0; k < _paises.Length; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (_habitantes[f] < _habitantes[f + 1])
                    {
                        string auxpais = _paises[f];
                        _paises[f] = _paises[f + 1];
                        _paises[f + 1] = auxpais;

                        int auxhabitantes = _habitantes[f];
                        _habitantes[f] = _habitantes[f + 1];
                        _habitantes[f + 1] = auxhabitantes;


                    }
                }
            }
        }

        public void Imprimir()
        {
            OrdenarPorPais();

            Console.WriteLine("Listado de Paises ordenados alfabéticamente");

            for (int f = 0; f < _paises.Length; f++)
            {
                Console.WriteLine($"{_paises[f]} tiene {_habitantes[f]} habitantes.");
            }

            OrdenarPorHabitante();

            Console.WriteLine("Listado de Paises ordenados por mayor cantidad de habitantes");

            for (int f = 0; f < _paises.Length; f++)
            {
                Console.WriteLine($"{_paises[f]} tiene {_habitantes[f]} habitantes.");
            }

        }
    }
}
