using System;
using System.Collections.Generic;

namespace CSharp.src.example2.dip
{
    public class Almacen : IAuditable
    {
        private List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionarProducto(Producto Producto)
        {
            inventario.Add(Producto);
            Console.WriteLine("Adicionamos {0}", Producto.Nombre);
        }

        public IEnumerable<Producto> ObtenProductos(int tipo)
        {
            List<Producto> prodEncontrados = new List<Producto>();
            foreach (Producto prod in inventario)
            {
                if (prod.Tipo == tipo)
                    prodEncontrados.Add(prod);
            }
            return prodEncontrados;
        }
    }
}