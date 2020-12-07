using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosEstaticos1
{
    class Persona
    {
        private string _nombre;
        private int _edad;
        public static int _cantidad;

        public Persona(string nom, int ed)
        {
            _cantidad++;
            _nombre = nom;
            _edad = ed;
        }

        public void Imprimir()
        {
            Console.WriteLine(_nombre + " " + _edad);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor del atributo estático cantidad: " + Persona._cantidad);
            var per1 = new Persona("Juan", 30);
            per1.Imprimir();

            Console.WriteLine("Valor del atributo estático cantidad: " + Persona._cantidad);
            var per2 = new Persona("Sebastian", 44);
            per2.Imprimir();

            Console.WriteLine("Valor del atributo estático cantidad: " + Persona._cantidad);
            var per3 = new Persona("Jazmin", 43);
            per3.Imprimir();

            Console.ReadKey();
        }
    }
}
