using System;

namespace DosVectoresEnOrden
{

    class PruebaVector16
    {
        private string[] _nombre;
        private int[] _nota;

        static void Main(string[] args)
        {
            PruebaVector16 pvp = new PruebaVector16();

            pvp.Cargar();
            pvp.Ordenar();
            pvp.Imprimir();

            Console.ReadKey();
        }

        public void Cargar()
        {
            _nombre = new string[5];
            _nota = new int[5];

            Console.WriteLine("Carga de nombres de alumnos y notas");

            for (int f=0; f<5; f++)
            {
                Console.WriteLine($"Ingrese el nombre del alumno nro. {f + 1}: ");
                _nombre[f] = Console.ReadLine();

                Console.WriteLine($"Ingrese la nota de {_nombre[f]}: ");
                string linea = Console.ReadLine();
                _nota[f] = int.Parse(linea);
            }
        }

        public void Ordenar()
        {
            for(int k=0; k<5; k++)
            {
                for(int f=0; f<4-k; f++)
                {
                    if (_nota[f] < _nota[f+1])
                    {
                        int auxnota = _nota[f];
                        string auxnombre = _nombre[f];

                        _nota[f] = _nota[f + 1];
                        _nombre[f] = _nombre[f + 1];

                        _nota[f + 1] = auxnota;
                        _nombre[f + 1] = auxnombre;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Notas de alumnos ordenadas de mayor a menor");

            for (int f=0; f<5; f++)
            {
                Console.WriteLine($"El alumno {_nombre[f]} tiene la nota {_nota[f]}.");
            }
        }

    }
}
