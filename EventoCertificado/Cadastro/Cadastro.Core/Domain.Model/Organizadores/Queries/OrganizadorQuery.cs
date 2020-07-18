using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cadastro.Core.Domain.Model.Organizadores.Queries
{
    public class OrganizadorQuery
    {
        public static Expression<Func<Organizador, bool>> TodosAtivos => x => x.Ativo.Equals(true);
    }
}
