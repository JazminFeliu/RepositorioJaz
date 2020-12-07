using System;

namespace GameOfLearnIT
{
    class Mago : Personaje
    {
        private int _force;
        private int _spell;
        private int _health;
        private int _levelMago;

        public Mago(string nombre)
        {
            Nombre = nombre;
        }

        public override void DefinirPersonaje()
        {
            Console.WriteLine($"{Nombre} será Mago.");
        }

        public override void OtorgarNivelInicialPersonaje()
        {
            _force = 7;
            _spell = 10;
            _health = 6;
            _levelMago = 1;
        }

        public override void MostrarPersonaje()
        {
            Console.WriteLine($"El Mago {Nombre} ha subido al nivel {_levelMago}");
            Console.WriteLine($"Su hechizo es de {_spell}, cuenta con una fuerza de {_force} y su salud es {_health}");
            Console.WriteLine("Felicitaciones!!!");
        }
    }
}
