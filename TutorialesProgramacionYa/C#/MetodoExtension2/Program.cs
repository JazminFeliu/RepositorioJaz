using System;
using System.Collections.Generic;

namespace MetodoExtension2
{
    public static class Extension
    {
        public static void Imprimir<T>(this List<T> lista)
        {
            foreach(var elemento in lista)
            {
                Console.Write("{0} ", elemento);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lista1 = new List<int>();
            lista1.Add(10);
            lista1.Add(20);
            lista1.Add(30);
            lista1.Add(500);
            lista1.Add(400);
            lista1.Imprimir();

            Console.ReadKey();
        }
    }
}
