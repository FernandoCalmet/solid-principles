using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.OCP
{
    class Tienda
    {
        private List<BaseInventario> productos;

        public Tienda(List<BaseInventario> productos)
        {
            this.productos = productos;
        }

        public void calcularInventario()
        {
            double total = 0;

            
            foreach(var producto in productos)
            {
                producto.CalcularProducto();
                Console.WriteLine(producto);
                total += producto.Producto.Precio;
            }          
            Console.WriteLine("El total en inventario es {0}", total);
        }
    }
}
