using ProEventos.Domain.Contracts.PalestranteContext;
using ProEventos.Domain.Entities.EventoContext;

namespace ProEventos.Data.Repositories.EventoContext
{
    public class PalestranteRepository : IPalestranteRepository
    {
        public Task<PalestranteEntity> DeleteAsync(PalestranteEntity palestrante)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteEntity> InsertAsync(PalestranteEntity palestrante)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteEntity> SelectAllAsync(bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteEntity> SelectIdAsync(Guid palestranteId, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteEntity> SelectNomeAsync(string ultimoNome, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteEntity> UpdateAsync(PalestranteEntity palestrante)
        {
            throw new NotImplementedException();
        }
    }
}
