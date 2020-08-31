using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.LSP
{
    class Noticiero : Principal
    {     
        public Noticiero(string mensaje) : base(mensaje)
        {
            
        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
        }
    }
}
