using System;

namespace SobrecargaOperadores3
{
    class Program
    {
        class VectorEnteros
        {
            private int[] vec;

            public VectorEnteros()
            {
                vec = new int[5]; 
            }

            public void Cargar()
            {
                for(int f=0; f<5; f++)
                {
                    Console.Write("Ingrese componente: ");
                    vec[f] = int.Parse(Console.ReadLine());
                }
            }

            public void Imprimir()
            {
                for(int f=0; f<vec.Length; f++)
                {
                    Console.Write(vec[f] + " ");
                }
                Console.WriteLine();
            }

            public static VectorEnteros operator ++(VectorEnteros v)
            {
                var resu = new VectorEnteros();
                
                for(int f=0; f<v.vec.Length; f++)
                {
                    resu.vec[f] = v.vec[f] + 1;
                }
                return resu;
            }
        }
        static void Main(string[] args)
        {
            var v1 = new VectorEnteros();
            Console.WriteLine("Carga del vector");
            v1.Cargar();

            Console.WriteLine("Impresión del vector");
            v1.Imprimir();

            v1++;

            Console.WriteLine("Impresión del vector luego del operador ++");
            v1.Imprimir();

            Console.ReadKey();
        }
    }
}
