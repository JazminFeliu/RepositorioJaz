using System;

namespace ListasTipoPila1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pila = new Pila();

            pila.Insertar(10);
            pila.Insertar(40);
            pila.Insertar(3);
            pila.Insertar(23);
            pila.Insertar(4);
            pila.Insertar(7);
            pila.Insertar(31);
            pila.Insertar(38);


            pila.Imprimir();

            Console.WriteLine("Extraemos de la pila: " + pila.Extraer());
            
            pila.Imprimir();

            Console.WriteLine("La cantidad de Nodos de la pila es: " + pila.Cantidad());

            Console.WriteLine("El primer valor ingresado es: " + pila.Retornar());

            while (pila.IsVacia() == false)
            {
                Console.WriteLine(pila.Extraer());
            }            

            Console.ReadKey();

        }
    }
}
