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
        public int opcionMenu;
        public int _stockArticulosCargados;
        public int _stockACargar;

        public int IniciarTienda()
        {
            Console.WriteLine("Bienvenida a la Tienda de Articulos!");
            Console.WriteLine("");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("0- Ingresar Articulo");
            Console.WriteLine("1- Ver Articulo");
            Console.WriteLine("2- Ver Inventario");
            Console.WriteLine("3- Actualizar Inventario");
            Console.WriteLine("4 - Salir");
            string op = Console.ReadLine();
            return opcionMenu = int.Parse(op);
        }

        public int DefinirStock()
        {
            Console.Write("Ingrese el stock de articulos con los que iniciara la prueba: ");
            string stock = Console.ReadLine();
            _stockACargar = int.Parse(stock);
            return _stockACargar;
        }


        public void DefinirArticulo()
        {
            Console.Write("Por favor, ingrese el nombre del articulo a gestionar :");
            string nombre = Console.ReadLine();

            Console.Write($"Elija el sector al que asignará {nombre} (A: Almacén / B: Bazar): ");
            string tipo = Console.ReadLine();

            _articulo = tipo == "A"
                ? ArticuloFactory.CrearArticulo((TipoDeArticulo)1, nombre, _stockArticulosCargados)
                : ArticuloFactory.CrearArticulo((TipoDeArticulo)2, nombre, _stockArticulosCargados);

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
