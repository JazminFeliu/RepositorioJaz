using System;

namespace GameOfLearnIT
{
    public class Juego
    {
        private IPersonaje _personaje;

        public void IniciarJuego()
        {
            Console.Write("Bienvenido a GoLIT! Por favor, ingrese su nombre:");
            string nombre = Console.ReadLine();

            Console.Write($"Elija el personaje que asigna a {nombre} (A:Aprendiz/M:Mago/H:Hechicera): ");

            string tipo = Console.ReadLine();

            _personaje = tipo == "A"
                ? PersonajeFactory.CrearPersonaje((TipoDePersonaje)1, nombre)
                : tipo == "H"
                    ? PersonajeFactory.CrearPersonaje((TipoDePersonaje)2, nombre)
                    : PersonajeFactory.CrearPersonaje((TipoDePersonaje)3, nombre);
        }

        public void DefinirPersonaje()
        {
            _personaje.DefinirPersonaje();
        }

        public void OtorgarNivelInicialPersonaje()
        {
            _personaje.OtorgarNivelInicialPersonaje();
        }
            
        public void MostrarPersonaje()
        {
            _personaje.MostrarPersonaje();
        }

        
    }
}
