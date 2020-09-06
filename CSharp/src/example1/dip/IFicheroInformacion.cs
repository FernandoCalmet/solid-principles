using System.IO;

namespace CSharp.src.example1.dip
{
    public interface IFicheroInformacion
    {
        FileInfo GetInformacion(string titulo);
    }
}