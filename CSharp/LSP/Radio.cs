using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.LSP
{
    class Radio : Principal
    {
        public Radio(string mensaje):base(mensaje)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("Desde la radio: {0}", mensaje);
        }
    }
}
