using Cadastro.Core.Domain.Model.Interfaces;
using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Core.Application.Organizadores
{
    public class OrganizadorService : IOrganizadorService
    {
        private readonly IOrganizadorRepositorio _repositorio;

        public OrganizadorService(IOrganizadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void CadastrarNovoOrganizador(Organizador organizador)
        {
            if (organizador.EhValido())
                _repositorio.Adicionar(organizador);
        }
    }
}
