using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.DIP
{
    class cAlmacen:iAuditable
    {
        private List<cProducto> inventario;

        public cAlmacen()
        {
            inventario = new List<cProducto>();
        }
              
        public void AdicionarProducto(cProducto pProducto)
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }

        public IEnumerable<cProducto> ObtenProductos(int pTipo)
        {
            List<cProducto> prodEncontrados = new List<cProducto>();
            foreach (cProducto prod in inventario)
            {
                if (prod.Tipo == pTipo)
                    prodEncontrados.Add(prod);
            }
            return prodEncontrados;
        }
    }
}
