using System;

namespace CSharp.src.example2.dip
{
    public class Producto
    {
        private String nombre;
        private int tipo; // 0 alimento 1 bebida 2 ropa
        private double costo;

        public Producto(string nombre, int tipo, double costo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.costo = costo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public double Costo { get => costo; set => costo = value; }

        public override string ToString()
        {
            string strTipo = "";
            if (tipo == 0)
                strTipo = "Alimento";
            else if (tipo == 1)
                strTipo = "Bebida";
            else if (tipo == 2)
                strTipo = "Ropa";
            return string.Format("{0}, tipo{1}, costo ${2}", nombre, strTipo, costo);
        }
    }
}