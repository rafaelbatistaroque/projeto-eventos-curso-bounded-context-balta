using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Core.Application.Organizadores
{
    public interface IOrganizadorService
    {
        void CadastrarNovoOrganizador(Organizador organizador);
    }
}
