using System;

namespace ListaGenerica1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lg = new ListaGenerica();

            lg.Insertar(1, 10);
            lg.Insertar(2, 20);
            lg.Insertar(3, 30);
            lg.Insertar(2, 15);
            lg.Insertar(3, 25);
            lg.Insertar(2, 50);
            lg.Insertar(4, 101);
            lg.Insertar(1, 120);
            lg.Insertar(1, 115);

            lg.Imprimir();

            Console.WriteLine("Lista luego de borrar el primero: ");

            lg.Borrar(1);
            lg.Imprimir();

            Console.WriteLine("Lista luego de Extraer el segundo: ");

            lg.Extraer(2);
            lg.Imprimir();

            Console.WriteLine("Lista luego de intercambiar el primero con el tercero: ");
            
            lg.Intercambiar(1, 3);
            lg.Imprimir();

            if (lg.Existe(20))
            {
                Console.WriteLine("Se encuentra el 20 en la lista");
            }
            else
            {
                Console.WriteLine("No se encuentra el 20 en la lista");
            }

            lg.Mayor();
            lg.PosMayor();

            Console.WriteLine("La posicion del numero mayor es: " + lg.PosMayor());

            if(lg.Ordenada())
            {
                Console.WriteLine("La lista se encuentra ordenada de menor a mayor");
            }
            else
            {
                Console.WriteLine("La lista NO se encuentra ordenada de menor a mayor");
            }

            Console.ReadKey();
        }
    }
}
