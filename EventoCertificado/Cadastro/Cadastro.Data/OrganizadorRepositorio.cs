using Cadastro.Core.Domain.Model.Interfaces;
using Cadastro.Core.Domain.Model.Organizadores;
using Cadastro.Core.Domain.Model.Organizadores.Queries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Data
{
    public class OrganizadorRepositorio : IOrganizadorRepositorio
    {
        public void Adicionar(Organizador organizador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Organizador> OrganizadoresAtivos()
        {
            var lista = new List<Organizador>().AsQueryable();

            return lista.Where(OrganizadorQuery.TodosAtivos);
        }
    }
}
