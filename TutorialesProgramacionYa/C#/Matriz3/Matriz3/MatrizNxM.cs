using System;

namespace Matriz3
{
    class MatrizNxM
    {
        private int[,] mat;
        private int f;
        private int c;

        public MatrizNxM()
        {
            Console.Write("Ingrese el número de filas de la matriz a crear: ");
            string linea = Console.ReadLine();
            f = int.Parse(linea);

            Console.Write("Ingrese la cantidad de columnas que desea: ");
            linea = Console.ReadLine();
            c = int.Parse(linea);

            mat = new int[f, c];
        }

        public void CargarMatriz()
        {
            for(int i = 0; i<f; i++)
            {
                for(int z=0; z<c; z++)
                {
                    Console.Write($"Ingrese componente: ");
                    string linea = Console.ReadLine();
                    mat[i, z] = int.Parse(linea);
                }
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("La cantidad de filas de la matriz es: " + mat.GetLength(0));

            Console.WriteLine("y las columnas de la matriz es: " + mat.GetLength(1));

            Console.WriteLine("Matriz completa");
            for (int i = 0; i < f; i++)
            {
                for (int z = 0; z < c; z++)
                {
                    Console.Write(mat[i, z]+ " "); 
                }
                Console.WriteLine();
            }

            Console.WriteLine("Última fila solamente");

            for(int i=0; i<c; i++ )
            {
                Console.Write(mat[mat.GetLength(0)-1, i] + " ");
            }


            Console.ReadKey();

        }
    }
}
