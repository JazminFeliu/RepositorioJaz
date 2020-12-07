using System;

namespace PruebaExcepcion9
{
    public class Cliente
    {
        public string Nombre { get; set; }

        private int cuenta = 0;

        public int Monto { get; set; }
        

        public Cliente(string nombre, int monto)
        {
            Nombre = nombre;
            Monto = monto;
        }

        public void Depositar(int valor)
        {
            cuenta += valor;
            Console.WriteLine($"El cliente {Nombre} ha depositado {valor} en su cuenta, quedando un saldo de {cuenta}");
        }

        public void Extraer(int valor)
        {
            if (valor <= cuenta)
            {
                cuenta -= valor;
                Console.WriteLine($"Ha extraído {valor} de su cuenta, quedando un saldo de {cuenta}");
            }
            else
            {
                throw new Exception($"el monto que usted quiere extraer {valor} es mayor al que posee, que es de {cuenta}.");
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"El cliente {Nombre} tiene en su cuenta un total de {cuenta}");
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var cli1 = new Cliente("Seba", 1500);
                cli1.Depositar(4700);
                cli1.Depositar(5000);
                cli1.Extraer(200);
                cli1.Imprimir();

                var cli2 = new Cliente("Jazmin", 300);
                cli2.Depositar(1200);
                cli2.Depositar(300);
                cli2.Extraer(1500);
                cli2.Extraer(600);
                cli2.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
