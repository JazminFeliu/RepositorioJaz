﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArticulos
{
    public class ArticuloFactory
    {
        private int _stockArticulosCargados; 

        private static Bazar _bazar;
        private static Almacen _almacen;

        _stockArticulosCargados = 0;

        public static IArticulo CrearArticulo(TipoDeArticulo articulo, string nombre, int stock)
        {
            IArticulo obj = null;

            switch (articulo)
            {
                case TipoDeArticulo.Bazar:
                    if (_bazar == null)
                        _bazar = new Bazar(nombre);

                    obj = _bazar;
                    break;

                case TipoDeArticulo.Almacen:
                    if (_almacen == null)
                        _almacen = new Almacen(nombre);

                    obj = _almacen;
                    break;

            }
            return obj;

            _stockArticulosCargados = _stockArticulosCargados + 1;
        }
    }
}
