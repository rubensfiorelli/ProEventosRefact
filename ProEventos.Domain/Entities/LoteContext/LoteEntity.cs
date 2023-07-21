using ProEventos.Domain.Entities.EventoContext;
using ProEventos.Domain.Validations;
using ProEventos.Domain.Validations.Contracts;

namespace ProEventos.Domain.Entities.LoteContext
{
    public sealed class LoteEntity : BaseEntity, IContract
    {
        public LoteEntity(string descricao, decimal preco, DateTime dataInicial, DateTime dataFinal, int quantidade,
            Guid eventoId) : base(descricao)
        {
            Preco = preco;
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            Quantidade = quantidade;
            EventoId = eventoId;
        }

        public decimal Preco { get; private set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }
        public int Quantidade { get; private set; }
        public Guid EventoId { get; private set; }
        public EventoEntity? Evento { get; set; }

        public override void SetDescricao(string descricao)
        {
            base.SetDescricao(descricao);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<LoteEntity>()
                .DescriptionIsOk(Descricao, 64, 12, "O nome do lote deve conter entre 12 e 64 caractres", "Descricao Lote");

            return contracts.IsValid();
        }
    }
}
