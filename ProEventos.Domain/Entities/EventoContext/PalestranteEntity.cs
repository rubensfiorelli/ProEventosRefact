using ProEventos.Domain.Entities.RedeSocialContext;
using ProEventos.Domain.Validations.Contracts;

namespace ProEventos.Domain.Entities.EventoContext
{
    public sealed class PalestranteEntity : BaseEntity, IContract
    {
        public PalestranteEntity(DateTime? createAt, DateTime? updateAt, DateTime data, string descricao)
            : base(createAt, updateAt, data, descricao)
        {

        }

        public ICollection<EventoEntity>? Eventos { get; set; }
        public ICollection<RedeSocialEntity>? RedesSociais { get; set; }

        public override void SetDescricao(string descricao)
        {
            base.SetDescricao(descricao);
        }

        public override bool Validation()
        {
            throw new NotImplementedException();
        }
    }
}
