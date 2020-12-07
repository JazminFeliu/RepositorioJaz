using System;

namespace PruebaExcepcion10
{
    public class PilaVaciaException: Exception
    {
        public PilaVaciaException (string mensaje): base ("Problema: " + mensaje)
        {
        }
    }

    public class Pila
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }

        public void Insertar (int x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = x;
            
            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public int Extraer()
        {
            if (raiz != null)
            {
                int informacion = raiz.info;
                raiz = raiz.sig;
                return informacion;
            }
            else
            {
                throw new PilaVaciaException("No hay mas elementos en la pila");
            }
        }

        public bool Vacia()
        {
            return raiz == null;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de todos los elementos de la pila");
            while (reco != null)
            {
                Console.Write(reco.info + "- ");
                reco = reco.sig;
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pila1 = new Pila();
            pila1.Insertar(45);
            pila1.Insertar(65);
            pila1.Insertar(78);
            pila1.Imprimir();
            try
            {
                while (!pila1.Vacia())
                {
                    Console.WriteLine("Extraemos de la pila:" + pila1.Extraer());
                }
                Console.WriteLine("Extraemos de la pila:" + pila1.Extraer());
            }
            catch (PilaVaciaException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
