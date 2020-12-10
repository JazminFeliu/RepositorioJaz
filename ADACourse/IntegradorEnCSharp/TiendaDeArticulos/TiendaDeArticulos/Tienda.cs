using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArticulos
{
    public class Tienda
    {
        private IArticulo _articulo;

        public void IniciarTienda()
        {
            Console.Write("Bienvenida a la Tienda de Articulos! Por favor, ingrese el nombre del articulo a gestionar:");
            string nombre = Console.ReadLine();

            Console.Write($"Elija el sector al que asignará {nombre} (A: Almacén / B: Bazar): ");

            string tipo = Console.ReadLine();

            _articulo = tipo == "A"
                ? ArticuloFactory.CrearArticulo((TipoDeArticulo)1, nombre)
                : ArticuloFactory.CrearArticulo((TipoDeArticulo)2, nombre);
        }

        public void DefinirArticulo()
        {
            _articulo.DefinirArticulo();

        }
        public void IngresarArticulo()
        {
            _articulo.IngresarArticulo();
        }

        public void VerArticulo()
        {
            _articulo.VerArticulo();
        }

        public void VerInventario()
        {
            _articulo.VerInventario();
        }

        public void ActualizarArticulo()
        {
            _articulo.ActualizarArticulo();
        }
    }
}
