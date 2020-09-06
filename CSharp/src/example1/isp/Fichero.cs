using System.IO;

namespace CSharp.src.example1.isp
{
    public class Fichero : IFicheroInformacion
    {
        readonly string path = "C:/temp";
        public FileInfo GetInformacion(string titulo)
        {
            return new FileInfo($"{path}/{titulo}.txt");
        }
    }
}