using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Core.Domain.Model.Organizadores.ValueObject
{
    public class OrganizadorId
    {
        public Guid Id { get; private set; }
        public OrganizadorId()
        {
            Id = Guid.NewGuid();
        }

        public OrganizadorId(Guid id)
        {
            Id = id;
        }
    }
}
