using System;

namespace StringMultiplesLineas1
{
    class OperacionNumeros
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public OperacionNumeros()
        {
            MenuOpciones();
        }

        private void MenuOpciones()
        {
            string opciones =
                @"  1 - Carga de 2 valores
                    2 - Mostrar la suma
                    3 - Mostrar la resta
                    4 - Mostrar el producto
                    5 - Mostrar la división
                    6 - Finalizar";
            int op;

            do
            {
                Console.WriteLine(opciones);
                Console.Write("Elija una opción: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Cargar();
                        break;
                    case 2:
                        Sumar();
                        break;
                    case 3:
                        Restar();
                        break;
                    case 4:
                        Multiplicar();
                        break;
                    case 5:
                        Dividir();
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar:");
                Console.ReadKey();
                Console.Clear();
            } while (op != 6);
        }

        private void Cargar()
        {
            Console.Write("Ingrese el primer valor: ");
            Numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            Numero2 = int.Parse(Console.ReadLine());
        }

        private void Sumar()
        {
            Console.WriteLine($"La suma de {Numero1} y {Numero2} es { Numero1 + Numero2}");
        }

        private void Restar()
        {
            Console.WriteLine($"La resta de {Numero1} y {Numero2} es {Numero1 - Numero2} ");
        }

        private void Multiplicar()
        {
            Console.WriteLine($"El producto de {Numero1} por {Numero2} es {Numero1 * Numero2}");
        }

        private void Dividir()
        {
            Console.WriteLine($"La división entre {Numero1} y {Numero2} es {Numero1 / Numero2}");
        }

        static void Main(string[] args)
        {
            new OperacionNumeros();
        }
    }
}
