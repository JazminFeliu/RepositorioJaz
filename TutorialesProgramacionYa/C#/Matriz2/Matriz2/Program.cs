using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            mat = new int[3, 4];

            Console.WriteLine("Cantidad de filas de la matriz: " + mat.GetLength(0));

            Console.WriteLine("Cantidad de columnas de la matriz: " + mat.GetLength(1));

            Console.ReadKey();
        }
    }
}
