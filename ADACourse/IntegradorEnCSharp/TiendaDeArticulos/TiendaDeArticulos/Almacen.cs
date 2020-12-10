using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArticulos
{
    public class Almacen : Articulo
    {
        private int[] _id;
        private string[] _detalle;
        private decimal[] _precio;
        private int[] _cantidad;

        public Almacen(string nombre, int stock)
        {
            Nombre = nombre;
            StockArticulosCargados = stock;
        }

        public override void DefinirArticulo()
        {
            Console.WriteLine($"El Articulo {Nombre} se ingresará en la Seccion Almacen");
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
