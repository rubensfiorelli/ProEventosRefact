using ProEventos.Domain.Entities.EventoContext;

namespace ProEventos.Domain.Contracts.PalestranteContext
{
    public interface IPalestranteRepository
    {
        Task<PalestranteEntity> InsertAsync(PalestranteEntity palestrante);
        Task<PalestranteEntity> UpdateAsync(PalestranteEntity palestrante);
        Task<PalestranteEntity> DeleteAsync(PalestranteEntity palestrante);
        Task<PalestranteEntity> SelectNomeAsync(string nome, bool includeEventos);
        Task<PalestranteEntity> SelectAllAsync(bool includeEventos);
        Task<PalestranteEntity> SelectIdAsync(Guid palestranteId, bool includeEventos);
    }
}
