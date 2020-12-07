using System;

namespace Matriz1
{
    class Matriz
    {
        private int[,] _matriz;

        public void CargarMatriz()
        {
            _matriz = new int[3, 5];
            
            for (int f=0; f<3; f++)
            {
                for(int c=0; c<5; c++)
                {
                    Console.Write("Ingrese componente: ");
                    string linea = Console.ReadLine();
                    _matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for(int f=0; f<3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(_matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
