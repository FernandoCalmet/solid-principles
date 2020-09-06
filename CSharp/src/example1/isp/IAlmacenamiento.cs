namespace CSharp.src.example1.isp
{
    public interface IAlmacenamiento
    {
        void Guardar(string titulo, string contenido);
        string Leer(string titulo);
    }
}