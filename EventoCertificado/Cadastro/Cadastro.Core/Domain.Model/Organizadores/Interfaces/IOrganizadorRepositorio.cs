using Cadastro.Core.Domain.Model.Organizadores;
using System.Collections.Generic;

namespace Cadastro.Core.Domain.Model.Interfaces
{
    public interface IOrganizadorRepositorio
    {
        void Adicionar(Organizador organizador);

        IEnumerable<Organizador> OrganizadoresAtivos();
    }
}
