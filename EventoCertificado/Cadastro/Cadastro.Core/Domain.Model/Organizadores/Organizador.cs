using Cadastro.Core.Domain.Model.Organizadores.ValueObject;
using Nucleo.Core;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class Organizador
    {
        public OrganizadorId Id { get; private set; }
        public string Nome { get; private set; }
        public NomeCompleto Responsavel { get; private set; }
        public bool Ativo { get; private set; }

        public Organizador(OrganizadorId organizadorId, string nome, NomeCompleto responsavel)
        {
            Id = organizadorId;
            Nome = nome;
            Responsavel = responsavel;
            Ativo = true;
        }

        public bool EhValido()
        {
            return true;
        }
    }
}
