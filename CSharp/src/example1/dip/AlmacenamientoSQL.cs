namespace CSharp.src.example1.dip
{
    public class AlmacenamientoSQL : IAlmacenamiento
    {
        private DBRepository _dbRepository;

        public AlmacenamientoSQL(DBRepository dBRepository)
        {
            _dbRepository = dBRepository;
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