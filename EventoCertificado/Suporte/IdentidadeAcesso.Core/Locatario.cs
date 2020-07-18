namespace IdentidadeAcesso.Core
{
    public class Locatario
    {
        public LocatarioId LocatarioId { get; private set; }
        public string Name { get; set; }

        public Locatario(LocatarioId locatarioId)
        {
            LocatarioId = locatarioId;
        }

        public Usuario NovoUsuario()
        {
            return new Usuario(LocatarioId);
        }
    }
}
