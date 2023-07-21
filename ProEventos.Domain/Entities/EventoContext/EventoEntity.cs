using ProEventos.Domain.Entities.LoteContext;
using ProEventos.Domain.Entities.RedeSocialContext;
using ProEventos.Domain.Validations;
using ProEventos.Domain.Validations.Contracts;

namespace ProEventos.Domain.Entities.EventoContext
{
    public sealed class EventoEntity : BaseEntity, IContract
    {
        public EventoEntity(DateTime? createAt, DateTime? updateAt, DateTime data, string descricao, string local,
            int qtdPessoas) : base(createAt, updateAt, data, descricao)
        {
            Local = local;
            QtdPessoas = qtdPessoas;
        }

        public string Local { get; private set; }
        public int QtdPessoas { get; private set; }
        public ICollection<LoteEntity>? Lotes { get; set; }
        public ICollection<RedeSocialEntity>? RedesSociais { get; }
        public ICollection<PalestranteEntity>? Palestrantes { get; set; }

        public void SetLocal(string local)
        {
            Local = local;
        }

        public override void SetDescricao(string descricao)
        {
            base.SetDescricao(descricao);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<EventoEntity>()
                 .LocalIsOk(Local, 50, 5, "Local deve ter entre 5 e 50 caracteres", nameof(Local));

            return contracts.IsValid();
        }
    }
}
