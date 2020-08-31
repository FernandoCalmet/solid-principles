using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID.ISP
{
    class cMultiSencillo:iMultiBasico
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo reporte...");
        }

        public void Escanear()
        {
            Console.WriteLine("Escaneando imagen...");
        }
    }
}
