using System;

namespace CSharp.src.example2.isp
{
    public class MultiSencillo : IMultiBasico
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