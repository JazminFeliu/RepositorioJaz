using System;

namespace SobrecargaConstructor1
{
    class Program
    {
        class Titulo
        {
            private string _tit;
            private int _columna;
            private int _fila;

            public Titulo(string t)
            {
                _tit = t;
                _columna = 1;
                _fila = 1;

            }

            public Titulo(string t, int col, int fil)
            {
                _tit = t;
                _columna = col;
                _fila = fil;
            }

            public void Imprimir()
            {
                Console.SetCursorPosition(_columna, _fila);
                Console.Write(_tit);
            }
        }

                    
        static void Main(string[] args)
        {
            var t1 = new Titulo("Hola Mundo");
            t1.Imprimir();

            var t2 = new Titulo("Hola Mundo", 40, 12);
            t2.Imprimir();

            Console.ReadKey();
        }
    }
}
