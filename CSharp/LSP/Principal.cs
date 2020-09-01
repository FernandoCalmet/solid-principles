using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.LSP
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string mensaje)
        {
            this.mensaje = mensaje;
        }

        public abstract void Muestra();
    }
}
