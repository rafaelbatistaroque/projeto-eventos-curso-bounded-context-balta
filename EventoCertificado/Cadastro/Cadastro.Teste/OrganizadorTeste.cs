using Cadastro.Core.Domain.Model.Organizadores;
using Cadastro.Core.Domain.Model.Organizadores.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro.Teste
{
    [TestClass]
    public class OrganizadorTeste
    {
        [TestMethod]
        public void DevePassarSeOrganixadorEhAtivo()
        {
            var lista = new List<Organizador>().AsQueryable();

            lista.Where(OrganizadorQuery.TodosAtivos).ToList().ForEach(i => Assert.IsTrue(i.Ativo));
        }
    }
}
