using System;

namespace CSharp.src.example2.isp
{
    public class Telefono : ITelefono
    {
        public void Telefonear()
        {
            Console.WriteLine("Llamando...");
        }

        public void Faxear()
        {
            Console.WriteLine("Escaneando mensaje...");
        }
    }
}