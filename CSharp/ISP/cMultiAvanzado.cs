using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.ISP
{
    class cMultiAvanzado:iMultiCompleto
    {        
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo reporte...");
        }

        public void Escanear()
        {
            Console.WriteLine("Escaneando reporte...");
        }

        public void Telefono()
        {
            Console.WriteLine("Llamando...");
        }

        public void Faxear()
        {
            Console.WriteLine("Faxeando mensaje...");
        }
        
    }
}
