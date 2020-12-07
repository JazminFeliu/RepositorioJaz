using System;

namespace Enumeracion1
{
    class JuegoDeCartas
    {
        public enum TipoCarta {  oro, basto, espada, copa};

        private TipoCarta cartaActual;

        public void Imprimir()
        {
            cartaActual = TipoCarta.oro;
            Console.WriteLine("El valor actual es: " + cartaActual);

            cartaActual = TipoCarta.espada;

            Console.WriteLine("El valor actualizado es: " + cartaActual);
        }
        static void Main(string[] args)
        {
            var tc = new JuegoDeCartas();
            tc.Imprimir();

            Console.ReadKey();
        }
    }
}
