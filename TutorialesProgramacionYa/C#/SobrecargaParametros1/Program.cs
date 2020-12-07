using System;

namespace SobrecargaParametros1
{
    class Program
    {
        public int Sumar(int x1, int x2)
        {
            int s = x1 + x2;
            return s;
        }

        public string Sumar(string s1, string s2)
        {
            string s = s1 + s2;
            return s;
        }
        static void Main(string[] args)
        {
            var par = new Program();

            Console.WriteLine("La suma de 5+10 es: " + par.Sumar(5, 10));
            Console.WriteLine("La concatenacion de Juan y Carlos es: " + par.Sumar("Juan", "Carlos"));

            Console.ReadKey();
        }
    }
}
