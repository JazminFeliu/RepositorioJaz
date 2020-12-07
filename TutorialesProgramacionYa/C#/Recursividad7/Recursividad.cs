using System;

namespace Recursividad7
{
    class Recursividad
    {
        public class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        public void InsertarPrimero(int x)
        {
            var nuevo = new Nodo();
            nuevo.info = x;
            nuevo.sig = raiz;
            raiz = nuevo;
        }

        private void ImprimirInversa(Nodo reco)
        {
            if (reco!= null)
            {
                ImprimirInversa(reco.sig);
                Console.Write(reco.info + "-");
            }
        }

        public void ImprimirInversa()
        {
            ImprimirInversa(raiz);
        }
            
    }
}
