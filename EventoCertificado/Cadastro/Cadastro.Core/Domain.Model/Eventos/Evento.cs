using Cadastro.Core.Domain.Model.Eventos.ValueObject;
using Cadastro.Core.Domain.Model.Organizadores.ValueObject;
using Nucleo.Core;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Core.Domain.Model.Eventos
{
    public class Evento
    {
        private readonly IList<Participante> _participantes;

        public EventoId EventoId { get; private set; }
        public OrganizadorId OrganizadorId { get; private set; }
        public string Nome { get; private set; }
        public Periodo PeriodoEntregaCertificado { get; private set; }
        public IReadOnlyCollection<Participante> Participantes => _participantes.ToList();

        protected Evento() { }

        public Evento(EventoId eventoId, OrganizadorId organizadorId, string nome)
        {
            EventoId = eventoId;
            OrganizadorId = organizadorId;
            Nome = nome;

            _participantes = new List<Participante>();
        }

        public void AdicionarParticipante(Participante participante)
        {
            _participantes.Add(participante);
        }

        public void AtualizarListaParticipantes(IEnumerable<Participante> participantes)
        {
            _participantes.Clear();
            _participantes.Union(participantes);
        }


    }
}
