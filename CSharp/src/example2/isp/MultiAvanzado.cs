using System;

namespace CSharp.src.example2.isp
{
    public class MultiAvanzado : IMultiCompleto
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo reporte...");
        }

        public void Escanear()
        {
            Console.WriteLine("Escaneando reporte...");
        }

        public void Telefonear()
        {
            Console.WriteLine("Llamando...");
        }

        public void Faxear()
        {
            Console.WriteLine("Faxeando mensaje...");
        }
    }
}