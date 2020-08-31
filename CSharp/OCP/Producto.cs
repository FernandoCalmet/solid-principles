using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.OCP
{
    class Producto
    {
        private String nombre;
        private int categoria;
        private double precio;

        public Producto(string nombre, int categoria, double precio)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
        }

        public String Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return String.Format("El producto {0} cuesta {1}", nombre, precio);
        }
    }
}
