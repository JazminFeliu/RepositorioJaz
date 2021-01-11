using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArticulos
{
    public class Bazar : Articulo
    {
        // todos vectores paralelos, elementos int (ID y CANTIDAD), uno string (DETALLE) y otro decimal (PRECIOS) 
        private int[] _IDyCantidadBazar;
        private string[] _detalle;
        private decimal[] _precio;
        private int[] _cantidad;

        public Bazar(string nombre)
        {
            Nombre = nombre;

        }

        public override void DefinirArticulo()
        {
            Console.WriteLine($"El Articulo {Nombre} se ingresará en la Seccion Bazar");
            Console.WriteLine($"El stock de articulos cargados hasta el momento es de {StockArticulosCargados}");

        }

        public override void IngresarArticulo()
        {
            
        }

        public override void VerArticulo()
        {

        }

        public override void VerInventario()
        {

        }

        public override void ActualizarArticulo()
        {

        }
    }
}
