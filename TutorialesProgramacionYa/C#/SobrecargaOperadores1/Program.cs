using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores1
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
                Console.WriteLine("Ingrese componente: ");
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

        public static VectorEnteros operator + ( VectorEnteros v1, VectorEnteros v2)
        {
            var su = new VectorEnteros();

            for(int f=0; f<su.vec.Length; f++)
            {
                su.vec[f] = v1.vec[f] + v2.vec[f];
            }
            return su;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new VectorEnteros();
            var v2 = new VectorEnteros();

            Console.WriteLine("Carga del primer vector: ");
            v1.Cargar();

            Console.WriteLine("Carga del segundo vector: ");
            v2.Cargar();

            Console.WriteLine("Primer vector: ");
            v1.Imprimir();

            Console.WriteLine("Segundo vector: ");
            v2.Imprimir();

            VectorEnteros vt;
            vt = v1 + v2;

            Console.WriteLine("Vector resultante: ");
            vt.Imprimir();

            Console.ReadKey();
        }
    }
}
