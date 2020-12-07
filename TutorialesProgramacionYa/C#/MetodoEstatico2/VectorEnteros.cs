using System;

namespace MetodoEstatico2
{
    class VectorEnteros
    {
        public static int RetornarMayor(int[] vec)
        {
            int aux = vec[0];
            for (int f= 1; f<vec.Length; f++)
            {
                if (vec[f]>aux)
                {
                    aux = vec[f];
                }
            }
            return aux;
        }

        public static int RetornarMenor(int[] vec)
        {
            int aux = vec[0];
            for(int f=1; f<vec.Length; f++)
            {
                if(vec[f]<aux)
                {
                    aux = vec[f];
                }
            }
            return aux;
        }

        public static int SumarComponentes(int[] vec)
        {
            int s = 0;
            for(int f=0; f<vec.Length;f++)
            {
                s = s + vec[f];
            }
            return s;
        }
        static void Main(string[] args)
        {
            int[] vec = { 7, 8, 3, 4, 9 }; 
            Console.WriteLine("El elemento mayor del vector(7,8,3,4,9) es: " + VectorEnteros.RetornarMayor(vec));
            Console.WriteLine("El elemento menor del vector (7,8,3,4,9) es: " + VectorEnteros.RetornarMenor(vec));
            Console.WriteLine("La suma de todos sus componentes es: " + VectorEnteros.SumarComponentes(vec));

            Console.ReadKey();
        }
    }
}
