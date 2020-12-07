using System;

namespace Indizador4
{
    public enum DatoCasilla {  agua, barco };

    class Tablero
    {
        private DatoCasilla[,] mat;

        public Tablero()
        {
            mat = new DatoCasilla[10, 10];
        }

        public void Graficar()
        {
            for(int f= 0; f< mat.GetLength(0); f++)
            {
                for (int c=0; c<mat.GetLength(1); c++)
                {
                    if(mat[f,c] == DatoCasilla.agua)
                    {
                        Console.Write("0");
                    }
                    if (mat[f,c] == DatoCasilla.barco)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

        public DatoCasilla this [int fila, int columna]
        {
            get
            {
                return mat[fila, columna];
            }
            set
            {
                mat[fila, columna] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var tablero1 = new Tablero();
            tablero1[0, 0] = DatoCasilla.barco;
            tablero1[0, 1] = DatoCasilla.barco;
            tablero1[0, 2] = DatoCasilla.barco;
            tablero1[0, 9] = DatoCasilla.barco;
            tablero1[1, 9] = DatoCasilla.barco;
            tablero1[2, 9] = DatoCasilla.barco;
            tablero1.Graficar();
            Console.WriteLine();
            if (tablero1[0,0] == DatoCasilla.barco)
            {
                Console.WriteLine("Hay un barco en esta casilla");
            }
            else
            {
                if(tablero1[0,0]== DatoCasilla.agua)
                {
                    Console.WriteLine("Agua");
                }
            }
            Console.ReadKey();
        }
    }
}
