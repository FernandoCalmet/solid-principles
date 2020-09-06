namespace CSharp.src.example1
{
    public class ProgramExample1
    {
        /* Principio de responsabilidad unica (SRP) */
        public void srpExample()
        {
            srp.ArticulosServicio servicioArticulos = new srp.ArticulosServicio();
            servicioArticulos.GuardarArticulo("Manzana, Platano, Naranja", "Caja de Frutas");
            servicioArticulos.ConsultarArticulo("Caja de Frutas");
        }

        /* Principio de abierto y cerrado (OCP) */
        public void ocpExample()
        {
            ocp.ILogger loggerDB = new ocp.DatabaseLogger();
            ocp.ArticulosServicio servicioArticulos = new ocp.ArticulosServicio(loggerDB);
            servicioArticulos.GuardarArticulo("Lechuga, Zanahoria, Tomate", "Caja de Verduras");
            servicioArticulos.ConsultarArticulo("Caja de Verduras");
        }

        /* Principio de sustitucion de Liskov (LSP) */
        public void lspExample()
        {
            lsp.ArticulosServicio servicioArticulos = new lsp.ArticulosServicio();
            servicioArticulos.GuardarArticulo("Jugo de Naranja, Cocacola, Fanta", "Caja de Bebidas");
            servicioArticulos.ConsultarArticulo("Caja de Bebidas");
        }

        /* Principio de segregacion de interface (ISP) */
        public void ispExample()
        {
            isp.ArticulosServicio servicioArticulos = new isp.ArticulosServicio();
            servicioArticulos.GuardarArticulo("Camisa, Pantalon, Chaqueta", "Caja de Ropa");
            servicioArticulos.ConsultarArticulo("Caja de Ropa");
        }

        /* Principio de inversion de depedencias (DIP) */
        public void dipExample()
        {
            //code
        }
    }
}