using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesVirtualesOverrideSealed
{
    class Producto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public Producto(string pdescripcion, double pprecioCompra)
        {
            descripcion = pdescripcion;
            precioCompra = pprecioCompra;
            precioVenta = 0.0;
        }

        public virtual void CalcularPrecio()
        {
            Console.WriteLine("Calcula el precio del producto");
            precioVenta = precioCompra * 1.3;
        }

        public void MostrarVenta()
        {
            Console.WriteLine("{0} se vende en {1}", descripcion, precioVenta);
        }

    }
}
