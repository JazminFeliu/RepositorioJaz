using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz6
{
    class Matriz
    {
        private int[,] mat;

        public Matriz()
        {
            Console.Write("Ingrese la cantidad de filas de la matriz: ");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.Write("Ingrese la cantidad de columnas de la matriz: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];

            for ( int f = 0; f<mat.GetLength(0); f++ )
            {
                for (int c = 0; c<mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese la componente: ");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
                
            }

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");                    
                }
                Console.WriteLine();
            }
        }

        
        public void ImprimirMayor()
        {
            int mayor = 0;
            int filamayor = 0;
            int columnamayor = 0;

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    int linea = mat[f, c];

                    if (linea > mayor)
                    {
                        mayor = linea;
                        filamayor = f;
                        columnamayor = c;
                    }
                }                
            }

            Console.WriteLine($"El numero {mayor} es le mayor de todas las componentes y se encuentra en la " +
                $"fila {filamayor+1} y la columna {columnamayor+1} de la matriz.");
            
            Console.ReadKey();

        }
    }
        
}
