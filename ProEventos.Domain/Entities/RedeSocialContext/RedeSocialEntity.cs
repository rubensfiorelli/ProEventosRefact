using ProEventos.Domain.Entities.EventoContext;
using ProEventos.Domain.Validations;
using ProEventos.Domain.Validations.Contracts;

namespace ProEventos.Domain.Entities.RedeSocialContext
{
    public sealed class RedeSocialEntity : BaseEntity, IContract
    {
        public RedeSocialEntity(string descricao, string url, Guid eventoId, Guid palestranteId) : base(descricao)
        {
            Url = url;
            EventoId = eventoId;
            PalestranteId = palestranteId;
        }

        public string Url { get; private set; }
        public Guid EventoId { get; private set; }
        public EventoEntity? Evento { get; set; }
        public Guid PalestranteId { get; private set; }
        public PalestranteEntity? Palestrante { get; set; }

        public override void SetDescricao(string descricao)
        {
            base.SetDescricao(descricao);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<RedeSocialEntity>()
               .DescriptionIsOk(Descricao, 64, 6, "O nome da rede social deve conter entre 6 e 64 caractres", "Descricao Rede Social");

            return contracts.IsValid();
        }
    }
}
