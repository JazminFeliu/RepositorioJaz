using System;
using System.Collections.Generic;

namespace ProblemaLinkedList1
{
    class Program
    {
        private static void ImprimirLista(LinkedList<int> lista)
        {
            LinkedListNode<int> reco = lista.First;
            while(reco != null)
            {
                Console.Write(reco.Value + "-");
                reco = reco.Next;
            }
            Console.WriteLine();
        }

        private static void ImprimirUltimoAlPrimero(LinkedList<int> lista)
        {
            LinkedListNode<int> reco = lista.Last;

            while(reco != null)
            {
                Console.Write(reco.Value + "-");
                reco = reco.Previous;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var lista1 = new LinkedList<int>();
            lista1.AddFirst(30);
            lista1.AddFirst(20);
            lista1.AddFirst(10);
            lista1.AddFirst(5);
            lista1.AddLast(1);

            Console.WriteLine("Imprimimos la lista");

            ImprimirLista(lista1);

            Console.WriteLine("Cantidad de nodos de la lista: " + lista1.Count);
            Console.WriteLine("Imprimimos la lista de atras para adelante:");
            ImprimirUltimoAlPrimero(lista1);

            Console.ReadKey();
        }
    }
}
