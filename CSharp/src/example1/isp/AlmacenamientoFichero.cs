using System.IO;

namespace CSharp.src.example1.isp
{
    public class AlmacenamientoFichero : IAlmacenamiento
    {
        readonly string path = "C:/temp";
        private readonly IFicheroInformacion _ficheroInformacion;

        public AlmacenamientoFichero(IFicheroInformacion ficheroInformacion)
        {
            _ficheroInformacion = ficheroInformacion;
        }

        public void Guardar(string titulo, string contenido)
        {
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
        }

        public string Leer(string titulo)
        {
            if (!GetFicheroInformation(titulo).Exists)
                return null;
                
            return File.ReadAllText($"{path}/{titulo}.txt");
        }

        public FileInfo InformacionFichero(string titulo)
        {
            if (!GetFicheroInformation(titulo).Exists)
                return null;

            return new FileInfo($"{path}/{titulo}.txt");
        }

        private FileInfo GetFicheroInformation(string titulo)
        {
            return _ficheroInformacion.GetInformacion(titulo);
        }
    }
}