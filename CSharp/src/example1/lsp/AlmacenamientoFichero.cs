using System.IO;

namespace CSharp.src.example1.lsp
{
    public class AlmacenamientoFichero : IAlmacenamiento
    {
        readonly string path = "C:/temp";
        public void Guardar(string titulo, string contenido)
        {
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
        }

        public string Leer(string titulo)
        {
            if (!InformacionFichero(titulo).Exists)
                return null;

            return File.ReadAllText($"{path}/{titulo}.txt");
        }

        private FileInfo InformacionFichero(string titulo)
        {
            return new FileInfo($"{path}/{titulo}.txt");
        }
    }
}