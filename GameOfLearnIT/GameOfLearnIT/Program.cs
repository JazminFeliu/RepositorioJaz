using System;

namespace GameOfLearnIT
{
    class Program
    {
        static void Main(string[] args)
        {
            var juego = new Juego();
            string op = "S";

            while (op == "S") 
            {
                    juego.IniciarJuego();
                    juego.DefinirPersonaje();
                    juego.OtorgarNivelInicialPersonaje();
                    juego.MostrarPersonaje();

                    Console.Write("Desea continuar?(S/N)");
                    op = Console.ReadLine();
            }
         
        }
    }
}
