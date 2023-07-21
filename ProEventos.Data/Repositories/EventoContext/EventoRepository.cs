using Microsoft.EntityFrameworkCore;
using ProEventos.Data.Context;
using ProEventos.Domain.Contracts.EventoContext;
using ProEventos.Domain.Entities.EventoContext;

namespace ProEventos.Data.Repositories.EventoContext
{
    public class EventoRepository : IEventoRepository
    {
        private readonly ApplicationDbContext _context;

        public EventoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<EventoEntity> DeleteAsync(EventoEntity evento)
        {
            _context.Eventos.Remove(evento);
            await _context.SaveChangesAsync();

            return evento;
        }

        public async Task<EventoEntity> InsertAsync(EventoEntity evento)
        {
            try
            {
                _context.Add(evento);
                await _context.SaveChangesAsync();

                return evento;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ICollection<EventoEntity>> SelectAllAsync(bool includePalestrantes)
        {
            try
            {
                IQueryable<EventoEntity> eventos = _context.Eventos.AsNoTracking()
                     .Include(e => e.Lotes)
                     .Include(e => e.RedesSociais)
                     .Include(e => e.Palestrantes)
                     .OrderBy(e => e.Data);


                return await _context.Eventos.ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ICollection<EventoEntity>> SelectDescricaoAsync(string descricao, bool includePalestrantes)
        {
            try
            {
                IQueryable<EventoEntity> eventos = _context.Eventos.AsNoTracking()
                     .Include(e => e.Lotes)
                     .Include(e => e.RedesSociais)
                     .Include(e => e.Palestrantes)
                     .OrderBy(e => e.Data)
                     .Where(e => e.Descricao.Contains(descricao));


                return await _context.Eventos.ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoEntity> SelectIdAsync(Guid eventoId, bool includePalestrantes)
        {
            try
            {
                IQueryable<EventoEntity> eventos = _context.Eventos.AsNoTracking()
                     .Include(e => e.Lotes)
                     .Include(e => e.RedesSociais)
                     .Include(e => e.Palestrantes)
                     .OrderBy(e => e.Data)
                     .Where(e => e.Id.Equals(eventoId));


                return await _context.Eventos.SingleOrDefaultAsync();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoEntity> UpdateAsync(EventoEntity evento)
        {
            _context.Eventos.Update(evento);
            await _context.SaveChangesAsync();

            return evento;
        }
    }
}
