namespace IdentidadeAcesso.Core
{
    public class Usuario
    {
        public LocatarioId LocatarioId { get; private set; }
        public string NomeUsuario { get; private set; }
        public string Senha { get; private set; }

        public Usuario(LocatarioId locatarioId)
        {
            LocatarioId = locatarioId;
        }
    }
}
