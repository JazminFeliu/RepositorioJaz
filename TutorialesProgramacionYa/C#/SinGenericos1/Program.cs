using System;

namespace SinGenericos1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pe = new PilaEnteros();

            pe.Insertar(20);
            pe.Insertar(30);
            pe.Insertar(70);
            pe.Insertar(45);
            Console.WriteLine(pe.Extraer());

            var ps = new PilaString();
            ps.Insertar("Jimena");
            ps.Insertar("Maria");
            ps.Insertar("Lorena");
            ps.Insertar("Svieta");

            Console.WriteLine(ps.Extraer());

            Console.ReadKey();
        }
    }
}
