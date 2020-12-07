using System;

namespace PruebaVector15
{
    class OrdenarNVector
    {
        private int[] _vectorn;
        private int f, k;

        static void Main(string[] args)
        {
            OrdenarNVector nv = new OrdenarNVector();

            nv.Ingresar();
            nv.Ordenar();
            nv.Imprimir();

            Console.ReadKey();             
        }

        public void Ingresar()
        {
            Console.WriteLine("Ingrese cuantos elementos desea cargar: ");
            string linea = Console.ReadLine();
            int cant = int.Parse(linea);

            _vectorn = new int[cant];

            for (f=0; f< _vectorn.Length; f++)
            {
                Console.WriteLine($"Ingrese el valor entero nro. {f + 1}: ");
                linea = Console.ReadLine();
                _vectorn[f] = int.Parse(linea);
            }
        }

        public void Ordenar()
        {
            for(k=0; k<_vectorn.Length; k++)
            {
                for(f=0; f <_vectorn.Length - 1 - k; f++)
                {
                    if (_vectorn[f] < _vectorn[f + 1])
                    {
                        int aux = _vectorn[f];
                        _vectorn[f] = _vectorn[f + 1];
                        _vectorn[f + 1] = aux;
                    }
                }                
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"Vector de {_vectorn.Length} elementos ordenado de mayor a menor");

            for(f=0; f<_vectorn.Length; f++)
            {
                Console.WriteLine($"En la posicion {f + 1} se encuentra el valor {_vectorn[f]}");

            }
        }
    }
}
