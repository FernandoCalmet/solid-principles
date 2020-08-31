using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.DIP
{
    interface iAuditable
    {
        IEnumerable<cProducto> ObtenProductos(int pTipo);
    }
}
