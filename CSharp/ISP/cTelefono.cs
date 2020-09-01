using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.ISP
{
    class cTelefono:iTelefono
    {      
        public void Telefono()
        {
            Console.WriteLine("Llamando...");
        }

        public void Faxear()
        {
            Console.WriteLine("Escaneando mensaje...");
        }
    }
}
