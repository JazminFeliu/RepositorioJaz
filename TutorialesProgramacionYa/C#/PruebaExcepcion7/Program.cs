using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExcepcion7
{
    public class PersonaAdulta
    {
        public string Nombre { get; set; }

        private int edad;
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 18)
                    throw new Exception($"No es adulta la persona {Nombre} porque tiene { value} años. ");
                edad = value;
            }
        }

        public PersonaAdulta (string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }        

        public void Imprimir()
        {
            Console.WriteLine($"{ Nombre } - { Edad}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var persona1 = new PersonaAdulta("Ana", 50);
                persona1.Imprimir();

                var persona2 = new PersonaAdulta("Juan", 13);
                persona2.Imprimir();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
