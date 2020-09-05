namespace CSharp.src.example1
{
    public class ProgramExample1
    {
        /* Principio de responsabilidad unica (SRP) */
        public void srpExample()
        {
            srp.ArticulosServicio servicioArticulos = new srp.ArticulosServicio("Manzanas, Platanos, Naranjas", "Caja de Frutas");
            servicioArticulos.ConsultarArticulo("Caja de Frutas");
        }

        /* Principio de abierto y cerrado (OCP) */
        public void ocpExample()
        {
            //code
        }

        /* Principio de sustitucion de Liskov (LSP) */
        public void lspExample()
        {
            //code
        }

        /* Principio de segregacion de interface (ISP) */
        public void ispExample()
        {
            //code
        }

        /* Principio de inversion de depedencias (DIP) */
        public void dipExample()
        {
            //code
        }
    }
}