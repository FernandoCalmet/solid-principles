using System.IO;

namespace CSharp.src.example1.lsp
{
    public interface IAlmacenamiento
    {
        void Guardar(string titulo, string contenido);
        string Leer(string titulo);
    }
}