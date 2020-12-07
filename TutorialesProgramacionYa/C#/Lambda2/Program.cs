using System;

namespace Lambda2
{
    public delegate bool Comparacion(int elemento);

    public class Estudiante
    {
        public String Nombre { get; set; }
        public int Nota { get; set; }
    }

    public class Curso
    {
        private Estudiante[] vec = new Estudiante[5];

        public void Cargar( int pos, Estudiante est)
        {
            vec[pos] = est;
        }

        public void ImprimirTodo()
        {
            foreach(var elemnto in vec)
            {
                Console.WriteLine("Nombre: {0} Nota: {1}", elemnto.Nombre, elemnto.Nota);
            }
        }

        public void ImprimirSi(Comparacion compara)
        {
            foreach(var elemento in vec )
            {
                if(compara(elemento.Nota))
                {
                    Console.WriteLine("Nombre: {0} Nota {1}", elemento.Nombre, elemento.Nota);
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var curso1 = new Curso();
            curso1.Cargar(0, new Estudiante { Nombre = "Lucia", Nota = 10 });
            curso1.Cargar(1, new Estudiante { Nombre = "Santiago", Nota = 10 });
            curso1.Cargar(2, new Estudiante { Nombre = "Emi", Nota = 9 });
            curso1.Cargar(3, new Estudiante { Nombre = "Emilio", Nota = 8 });
            curso1.Cargar(4, new Estudiante { Nombre = "Jazmin", Nota = 10 });

            Console.WriteLine("Listado completo de alumnos");
            curso1.ImprimirTodo();

            Console.WriteLine("Listado de Estudiantes con notas mayores o iguales a 9");
            curso1.ImprimirSi((nota) => nota >= 9);

            Console.WriteLine("Listado completo de estudiantes que tienen un 8");
            curso1.ImprimirSi((nota) => nota == 8);

            Console.WriteLine("Listado completo de estudiantes empleando el método ImprimirSi");
            curso1.ImprimirSi((nota) => true);

            Console.ReadKey();

        }
    }
}
