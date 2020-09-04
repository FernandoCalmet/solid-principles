using System.Collections.Generic;

namespace CSharp.src.example2.dip
{
    public interface IAuditable
    {
         IEnumerable<Producto> ObtenProductos(int pTipo);
    }
}