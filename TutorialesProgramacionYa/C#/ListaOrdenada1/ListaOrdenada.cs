﻿using System;

namespace ListaOrdenada1
{
    class ListaOrdenada
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;
        
        public ListaOrdenada()
        {
            raiz = null;
        }

        public void Insertar(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;

            if(raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                if (x< raiz.info)
                {
                    nuevo.sig = raiz;
                    raiz = nuevo;
                }
                else
                {
                    Nodo reco = raiz;
                    Nodo atras = raiz;
                    while (x>=reco.info && reco.sig !=null)
                    {
                        atras = reco;
                        reco = reco.sig;
                    }

                    if (x >= reco.info)
                    {
                        reco.sig = nuevo;
                    }
                    else
                    {
                        nuevo.sig = reco;
                        atras.sig = nuevo;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            while(reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }
    }
}
