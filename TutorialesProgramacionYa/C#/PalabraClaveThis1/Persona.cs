using System;

namespace PalabraClaveThis1
{
    class Persona
    {
        private string _nombre;
        private int _edad;

        public Persona(string nom, int ed)
        {
            this._nombre = nom;
            this._edad = ed;
            this.Imprimir();
        }


        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + this._nombre);
            Console.WriteLine("Edad: " + this._edad);

            Console.ReadKey();
        }
    }
}
