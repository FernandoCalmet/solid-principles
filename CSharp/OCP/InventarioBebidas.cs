using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.OCP
{
    class InventarioBebidas: BaseInventario
    {
        public InventarioBebidas(Producto producto) : base(producto)
        {

        }

        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
