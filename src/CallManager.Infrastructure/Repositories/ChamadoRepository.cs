using CallManager.Application.Interfaces;
using CallManager.Application.Models;
using CallManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CallManager.Infrastructure.Repositories
{
    public class ChamadoRepository : Repository<Chamado>, IChamadoRepository
    {
        public ChamadoRepository(CallManagerDbContext context) : base(context) 
        {
        }

        public async Task<IEnumerable<Chamado>> ObterChamadosComColaboradorAsync()
        {
            return await _context.Chamados
                .Include(c => c.Colaborador)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Chamado?> ObterChamadoComColaboradorPorIdAsync(int id)
        {
            return await _context.Chamados
                .Include(c => c.Colaborador)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
