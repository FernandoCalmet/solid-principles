using System;
using System.Collections.Generic;

namespace CSharp.src.example2.dip
{
    public class Auditor
    {
        private IAuditable almacen;

        public Auditor(IAuditable Almacen)
        {
            this.almacen = Almacen;
        }

        public double totalAlimentos()
        {
            double total = 0;
            IEnumerable<Producto> listado = almacen.ObtenProductos(0);
            foreach(Producto prod in listado)
            {              
               Console.WriteLine(prod);
               total += prod.Costo;             
            }
            return total;
        }

        public double totalBebidas()
        {
            double total = 0;
            IEnumerable<Producto> listado = almacen.ObtenProductos(1);
            foreach (Producto prod in listado)
            {
                Console.WriteLine(prod);
                total += prod.Costo;
            }
            return total;
        }

        public double totalRopas()
        {
            double total = 0;
            IEnumerable<Producto> listado = almacen.ObtenProductos(2);
            foreach (Producto prod in listado)
            {
                Console.WriteLine(prod);
                total += prod.Costo;
            }
            return total;
        }
    }
}