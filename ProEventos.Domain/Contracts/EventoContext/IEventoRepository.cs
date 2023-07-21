using ProEventos.Domain.Entities.EventoContext;

namespace ProEventos.Domain.Contracts.EventoContext
{
    public interface IEventoRepository
    {
        Task<EventoEntity> InsertAsync(EventoEntity evento);
        Task<EventoEntity> UpdateAsync(EventoEntity evento);
        Task<EventoEntity> DeleteAsync(EventoEntity evento);
        Task<ICollection<EventoEntity>> SelectDescricaoAsync(string descricao, bool includePalestrantes);
        Task<ICollection<EventoEntity>> SelectAllAsync(bool includePalestrantes);
        Task<EventoEntity> SelectIdAsync(Guid eventoId, bool includePalestrantes);

    }
}
