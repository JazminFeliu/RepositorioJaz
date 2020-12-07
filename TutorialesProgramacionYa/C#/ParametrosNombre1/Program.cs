using System;

namespace ParametrosNombre1
{
    class Program
    {
        public void Imprimir(string mensaje, int columna, int fila)
        {
            Console.SetCursorPosition(columna, fila);
            Console.Write(mensaje);
        }

        static void Main(string[] args)
        {
            var ob1 = new Program();
            ob1.Imprimir(fila: 12, columna: 40, mensaje: "Hola");
            ob1.Imprimir(mensaje: "Fin", fila: 23, columna: 5);

            Console.ReadKey();
        }
    }
}
