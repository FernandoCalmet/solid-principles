using System;

namespace CSharp.src.example2.lsp
{
    public class Radio : Principal
    {
        public Radio(string mensaje) : base(mensaje)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("Desde la radio: {0}", mensaje);
        }
    }
}