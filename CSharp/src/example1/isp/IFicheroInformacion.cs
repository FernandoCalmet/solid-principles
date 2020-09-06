using System.IO;

namespace CSharp.src.example1.isp
{
    public interface IFicheroInformacion
    {
        FileInfo GetInformacion(string titulo);
    }
}