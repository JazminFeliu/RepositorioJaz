using System;

namespace PruebaExcepcion8
{
    public class Operaciones
    {
        public int Numerador { get; set; }

        public int Denominador { get; set; }
        
    
        public Operaciones(int nume, int deno)
        {
            Numerador = nume;
            Denominador = deno;
        }

        public int Sumar(int v1, int v2)
        {
            int suma = v1 + v2;
            return suma;
        }

        public int Restar(int v1, int v2)
        {
            int resta = v1 - v2;
            return resta;
        }

        public int Multiplicar(int v1, int v2)
        {
            int producto = v1 * v2;
            return producto;
        }
        
        public int Dividir(int v1, int v2)
        {
            if (v2 == 0)
                throw new Exception($"Error: no se puede dividir por 0");
            
            int division = v1 / v2;
            return division;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Operaciones entre el primer valor: {Numerador} y el segundo valor: {Denominador}");
            Console.WriteLine($"Su suma es {Sumar(Numerador, Denominador)}");
            Console.WriteLine($"Su resta es: {Restar(Numerador, Denominador)}");
            Console.WriteLine($"Su multiplicación es: {Multiplicar(Numerador, Denominador)}");
            Console.WriteLine($"Su división es: {Dividir(Numerador, Denominador)}");
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ope1 = new Operaciones(49, 7);
            var ope2 = new Operaciones(5, 0);
            try
            {
                
               ope1.Imprimir();
               Console.WriteLine();
               ope2.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();            
        }
    }
}
