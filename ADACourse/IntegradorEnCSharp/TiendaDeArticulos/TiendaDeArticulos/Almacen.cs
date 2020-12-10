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

        private int cantidadDisponible = 0;

        public Almacen(string nombre)
        {
            Nombre = nombre;
        }

        public override void DefinirArticulo()
        {
            cantidadDisponible++;

            Console.WriteLine($"El Articulo {Nombre} se ingresará en la Seccion Almacen");
            Console.WriteLine("Recuerde que solamente puede ingresar un maximo de 15 articulos en esta Sección");
            Console.WriteLine($"Quedan {cantidadDisponible} lugares disponibles. ");

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
