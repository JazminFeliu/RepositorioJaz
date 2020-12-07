using System;

namespace PruebaVector14
{
    class VectorStringOrdenado
    {
        private string[] _pais;

        static void Main(string[] args)
        {
            VectorStringOrdenado vso = new VectorStringOrdenado();

            vso.IngresarPais();
            vso.OrdenarPais();
            vso.ImprimirPais();

            Console.ReadKey();
        }

        public void IngresarPais()
        {
            _pais = new string[5];

            for (int f=0; f< _pais.Length; f++)
            {
                Console.WriteLine($"Ingrese el pais nro. {f + 1}: ");
                _pais[f] = Console.ReadLine();
            }
        }

        public void OrdenarPais()
        {
            for (int k=0; k<4; k++)
            {
                for(int f=0; f<4-k; f++)
                {                                       
                    if (_pais[f].CompareTo(_pais[f+1])>0)
                    {
                        string aux = _pais[f];
                        _pais[f] = _pais[f + 1];
                        _pais[f + 1] = aux;
                    }                        
                }
            }
        }

        public void ImprimirPais()
        {
            Console.WriteLine("Paises ordenados alfabéticamente");
            for(int f=0; f<_pais.Length; f++)
            {
                Console.WriteLine($"En la posición {f + 1} se encuentra {_pais[f]}");
            }
        }
    }
}
