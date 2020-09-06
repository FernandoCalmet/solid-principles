namespace CSharp.src.example1.isp
{
    public class AlmacenamientoSQL : IAlmacenamiento
    {
        private DBRepository _dbRepository;

        public AlmacenamientoSQL()
        {
            _dbRepository = new DBRepository();
        }

        public void Guardar(string titulo, string contenido)
        {
            _dbRepository.Guardar(titulo, contenido);
        }

        public string Leer(string titulo)
        {
            return _dbRepository.Leer(titulo);
        }
    }
}