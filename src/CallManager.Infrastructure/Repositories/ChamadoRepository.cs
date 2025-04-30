using CallManager.Application.Interfaces;
using CallManager.Application.Models;
using CallManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CallManager.Infrastructure.Repositories
{
    public class ChamadoRepository : Repository<Chamado>, IChamadoRepository
    {
        private readonly CallManagerDbContext _context;
        public ChamadoRepository(CallManagerDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Chamado>> ObterChamadosComColaboradorAsync()
        {
            return await _context.Chamados
                .Include(c => c.Colaborador)
                .ToListAsync();
        }

        public async Task<Chamado?> ObterChamadoComColaboradorPorIdAsync(Guid id)
        {
            return await _context.Chamados
                .Include(c => c.Colaborador)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
