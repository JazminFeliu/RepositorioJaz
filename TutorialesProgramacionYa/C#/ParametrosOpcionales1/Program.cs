using System;

namespace ParametrosOpcionales1
{
    class Program
    {
        public void Imprimir (string mensaje, int col = 1, int fil = 1)
        {
            Console.SetCursorPosition(col, fil);
            Console.Write(mensaje);

        }
        static void Main(string[] args)
        {
            var ob1 = new Program();
            ob1.Imprimir("Hola");
            ob1.Imprimir("Hola", 40);
            ob1.Imprimir("Hola", 40, 12);

            Console.ReadKey();
        }
    }
}
