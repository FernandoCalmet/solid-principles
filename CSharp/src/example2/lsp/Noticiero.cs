using System;

namespace CSharp.src.example2.lsp
{
    public class Noticiero : Principal
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