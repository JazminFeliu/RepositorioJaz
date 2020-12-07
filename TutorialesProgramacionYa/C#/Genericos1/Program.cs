using System;

namespace Genericos1
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
    class Pila<T>
    {
        private T[] _vec = new T[5];
        private int _tope = 0;

        public void Insertar(T x)
        {
            _vec[_tope] = x;
            _tope++;
        }

        public T Extraer()
        {
            _tope--;
            return _vec[_tope];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pila0 = new Pila<Persona>();
            var per1 = new Persona { Nombre = "Jacinto", Edad = 22 };
            var per2 = new Persona { Nombre = "Julieto", Edad = 39 };
            var per3 = new Persona { Nombre = "Jaimito", Edad = 12 };

            pila0.Insertar(per1);
            pila0.Insertar(per2);
            pila0.Insertar(per3);

            Persona p = pila0.Extraer();
            Console.WriteLine(p.Nombre + "  " + p.Edad);

            var pila1 = new Pila<int>();
            pila1.Insertar(20);
            pila1.Insertar(40);
            pila1.Insertar(19);
            Console.WriteLine(pila1.Extraer());

            var pila2 = new Pila<string>();
            pila2.Insertar("Lorenzo");
            pila2.Insertar("Mauricio");
            pila2.Insertar("Rigoberto");
            Console.WriteLine(pila2.Extraer());

            Console.ReadKey();
        }
    }
}
