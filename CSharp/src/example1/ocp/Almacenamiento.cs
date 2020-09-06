using System.IO;

namespace CSharp.src.example1.ocp
{
    public class Almacenamiento
    {
        string path = "C:/temp";
        public virtual void EscribirFichero(string titulo, string contenido)
        {
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
        }

        public virtual string LeerFichero(string titulo)
        {
            return File.ReadAllText($"{path}/{titulo}.txt");
        }
    }
}