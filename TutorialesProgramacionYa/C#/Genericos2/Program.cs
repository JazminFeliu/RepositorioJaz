using System;

namespace Genericos2
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return "(" + Nombre + "-" + Edad + ")";
        }
    }

    class ListaGenerica<T>
    {
        class Nodo
        {
            public T Info { get; set; }
            public Nodo sig { get; set; }
        }

        private Nodo raiz;

        public ListaGenerica()
        {
            raiz = null;
        }

        public void Insertar(int pos, T x)
        {
            if (pos <= Cantidad() + 1 )
            {
                Nodo nuevo = new Nodo();
                nuevo.Info = x;
                if (pos == 1)
                {
                    nuevo.sig = raiz;
                    raiz = nuevo;
                }
                else if(pos == Cantidad() + 1)
                {
                    Nodo reco = raiz;
                    while (reco.sig != null)
                    {
                        reco = reco.sig;
                    }
                    reco.sig = nuevo;
                    nuevo.sig = null;
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f=0; f<= pos-2; f++)
                    {
                        reco = reco.sig;
                    }
                    Nodo siguiente = reco.sig;
                    reco.sig = nuevo;
                    nuevo.sig = siguiente;
                }
            }
        }

        public T Extraer(int pos)
        {
            T informacion;
            if (pos == 1)
            {
                informacion = raiz.Info;
                raiz = raiz.sig;
            }
            else
            {
                Nodo reco;
                reco = raiz;
                for (int f=0; f<=pos -2; f++)
                {
                    reco = reco.sig;
                }
                Nodo prox = reco.sig;
                reco.sig = prox.sig;
                informacion = prox.Info;                
            }
            return informacion;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write(reco.Info + " - ");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            var lista1 = new ListaGenerica<int>();
            lista1.Insertar(1, 10);
            lista1.Insertar(2, 30);
            lista1.Insertar(3, 50);
            lista1.Imprimir();

            var lista2 = new ListaGenerica<string>();
            lista2.Insertar(1, "uno");
            lista2.Insertar(2, "dos");
            lista2.Insertar(3, "tres");
            lista2.Imprimir();

            var lista3 = new ListaGenerica<Persona>();
            lista3.Insertar(1, new Persona { Nombre = "Jazmín", Edad = 43 });
            lista3.Insertar(2, new Persona { Nombre = "Sebastian", Edad = 44 });
            lista3.Insertar(3, new Persona { Nombre = "Santiago", Edad = 45 });
            lista3.Imprimir();

            Console.ReadKey();
        }
    }
}
