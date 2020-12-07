using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesVirtualesOverrideSealed
{
    class ProductoEnAduanaDetenido: ProductoImportado
    {
        private double multa;

        public ProductoEnAduanaDetenido(string pdescripcion, double pPrecioCompra, double pImpuesto, double pMulta)
            :base(pdescripcion, pPrecioCompra, pImpuesto)
        {
            multa = pMulta;
        }

        public sealed override void CalcularPrecio()
        {
            Console.WriteLine("Calcula el precio del producto importado con multa");
            precioVenta = (precioCompra * (1 + impuesto) * 1.3) + multa;
        }
    }
}
