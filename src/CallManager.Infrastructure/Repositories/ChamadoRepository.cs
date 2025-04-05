using CallManager.Application.Interfaces;
using CallManager.Application.Models;
using CallManager.Infrastructure.Data;

namespace CallManager.Infrastructure.Repositories
{
    public class ChamadoRepository : Repository<Chamado>, IChamadoRepository
    {
        public ChamadoRepository(CallManagerDbContext context) : base(context)
        {
        }
        // Adicionar métodos específicos para o repositório de Chamado, se necessário.
    }
}
