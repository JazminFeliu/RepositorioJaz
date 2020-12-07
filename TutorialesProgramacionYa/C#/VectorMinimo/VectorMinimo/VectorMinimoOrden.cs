using System;

namespace VectorMinimo
{
    class VectorMinimoOrden
    {
        int[] _elemento;

        static void Main(string[] args)
        {
            VectorMinimoOrden vm = new VectorMinimoOrden();
            vm.Cargar();
            vm.OrdenarMenor();

            Console.ReadKey();

        }

        public void Cargar()
        {
            Console.Write("Ingrese la cantidad de elementos a cargar: ");
            string linea = Console.ReadLine();
            int cant = int.Parse(linea);

            _elemento = new int[cant];

            for (int f=0; f<cant; f++)
            {
                Console.Write($"Ingrese el valor entero nro. {f + 1}: ");
                linea = Console.ReadLine();
                _elemento[f] = int.Parse(linea);
            }
        }

        public void OrdenarMenor()
        {
            int valorMenor = _elemento[0];

            int cant = 1;

            for(int f=0; f<_elemento.Length; f++)
            {
                if ( _elemento[f] < valorMenor )
                {
                    valorMenor = _elemento[f];
                }

                if (_elemento[f] == valorMenor)
                {
                    cant++;
                    
                }   
            }
            Console.WriteLine($"El valor entero menor ingresado es {valorMenor}");

            if (cant > 1)
                Console.WriteLine($"El valor menor {valorMenor} se repite {cant-1} veces.");
            else
                Console.WriteLine($"El valor menor {valorMenor} no se repite en el vector");
        }
    }
}
