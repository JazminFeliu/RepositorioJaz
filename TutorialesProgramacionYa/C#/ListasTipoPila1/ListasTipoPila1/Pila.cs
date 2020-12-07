using System;

namespace ListasTipoPila1
{
    class Pila
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

        public void Insertar(int x)
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
                return int.MaxValue;
            }
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de todos los elementos de la pila.");
            
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        public bool IsVacia()
        {
            if (raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while(reco!= null)
            {
                cant++;
                reco = reco.sig;
            }
            return cant;
        }

        public int Retornar()
        {
            if (raiz != null)
            {
                int informacion = raiz.info;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }
    }
    
}
