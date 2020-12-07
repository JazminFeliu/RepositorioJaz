using System;

namespace ParametrosPorValor3
{
    class Program
    {
        public string EscribirValor(int v1)
        {
            switch(v1)
            {
                case 1: return "El valor ingresado es el uno.";
                    break;
                case 2: return "El valor ingresado es el dos.";
                    break;
                case 3: return "El valor ingresado es el tres.";
                    break;
                case 4: return "El valor ingresado es el cuatro.";
                    break;
                case 5: return "El valor ingresado es el cinco.";
                    break;
                case 6: return "El valor ingresado es el seis.";
                    break;
                case 7: return "El valor ingresado es el siete.";
                    break;
                case 8: return "El valor ingresado es el ocho.";
                    break;
                case 9: return "El valor ingresado es el nueve.";
                    break;
                case 10: return "El valor ingresado es el diez.";
                    break;
                default:
                    return "Ingresó un valor fuera de rango";
                    break;
            }
                
        }
        static void Main(string[] args)
        {
            var val = new Program();
            Console.Write("Ingrese un valor del 1 al 10: ");
            string linea = Console.ReadLine();
            int valor = int.Parse(linea);

            string nombre = val.EscribirValor(valor);

            Console.WriteLine(nombre);

            Console.ReadKey();
        }
    }
}
