namespace CSharp.src.example1.dip
{
    public interface IAlmacenamiento
    {
        void Guardar(string titulo, string contenido);
        string Leer(string titulo);
    }
}