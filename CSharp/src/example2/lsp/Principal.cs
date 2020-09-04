namespace CSharp.src.example2.lsp
{
    public abstract class Principal
    {
        protected string mensaje;

        public Principal(string mensaje)
        {
            this.mensaje = mensaje;
        }

        public abstract void Muestra();
    }
}