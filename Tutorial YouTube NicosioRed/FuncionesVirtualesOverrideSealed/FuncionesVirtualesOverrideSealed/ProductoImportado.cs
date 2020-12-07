using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesVirtualesOverrideSealed
{
    class ProductoImportado: Producto
    {
        protected double impuesto;

        public ProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
            :base(pDescripcion, pPrecioCompra) 
        {
            impuesto = pImpuesto;
        }

        public override void CalcularPrecio()
        {
            Console.WriteLine(" Calcula precio del producto importado");
            precioVenta = precioCompra * (1 + impuesto) * 1.3;
        }

        public new void MostrarVenta()
        {
          
            Console.WriteLine("El gran producto {0} se vende en {1}!!!!!!!", descripcion, precioVenta);
        }
    }
}
