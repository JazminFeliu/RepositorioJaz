using System;
using System.Collections.Generic;

namespace PilaCola1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pila1 = new Stack<int>();
            Console.WriteLine("Insertamos tres elementos de la pila: 10, 25 y 70");

            pila1.Push(10);
            pila1.Push(25);
            pila1.Push(70);

            Console.WriteLine("Cantidad de elementos en la pila: " + pila1.Count);
            Console.WriteLine("Extraemos un elemento de la pila: " + pila1.Pop());
            Console.WriteLine("Cantidad de elementos en la pila: " + pila1.Count);

            var cola1 = new Queue<string>();
            Console.WriteLine("Insertamos tres elementos en la cola: Seba, Jaz y Santy");

            cola1.Enqueue("Seba");
            cola1.Enqueue("Jaz");
            cola1.Enqueue("Santy");

            Console.WriteLine("Cantidad de elementos de la cola: " + cola1.Count);
            Console.WriteLine("Extraemos un elemento de la cola: " + cola1.Dequeue());
            Console.WriteLine("Cantidad de elementos de la cola: " + cola1.Count);

            Console.ReadKey();

        }
    }
}
