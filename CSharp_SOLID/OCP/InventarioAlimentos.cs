using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.OCP
{
    class InventarioAlimentos : BaseInventario
    {

        public InventarioAlimentos(Producto producto) : base (producto)
        {

        }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }

    }
}
