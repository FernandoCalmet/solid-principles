using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.OCP
{
    abstract class BaseInventario
    {
        protected Producto producto;

        public BaseInventario(Producto producto)
        {
            this.producto = producto;
        }

        public Producto Producto { get => producto; set => producto = value; }

        public override string ToString()
        {
            return producto.ToString();
        }

        public abstract double CalcularProducto();
    }
}
