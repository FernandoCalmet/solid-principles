using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.DIP
{
    class cAuditor
    {
        private iAuditable almacen;

        public cAuditor(iAuditable pAlmacen)
        {
            this.almacen = pAlmacen;
        }

        public double totalAlimentos()
        {
            double total = 0;
            IEnumerable<cProducto> listado = almacen.ObtenProductos(0);
            foreach(cProducto prod in listado)
            {              
               Console.WriteLine(prod);
               total += prod.Costo;             
            }
            return total;
        }

        public double totalBebidas()
        {
            double total = 0;
            IEnumerable<cProducto> listado = almacen.ObtenProductos(1);
            foreach (cProducto prod in listado)
            {
                Console.WriteLine(prod);
                total += prod.Costo;
            }
            return total;
        }

        public double totalRopas()
        {
            double total = 0;
            IEnumerable<cProducto> listado = almacen.ObtenProductos(2);
            foreach (cProducto prod in listado)
            {
                Console.WriteLine(prod);
                total += prod.Costo;
            }
            return total;
        }
    }
}
