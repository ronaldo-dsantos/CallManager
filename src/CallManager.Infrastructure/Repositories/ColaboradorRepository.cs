using CallManager.Application.Interfaces;
using CallManager.Application.Models;
using CallManager.Infrastructure.Data;

namespace CallManager.Infrastructure.Repositories
{
    public class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
    {
        public ColaboradorRepository(CallManagerDbContext context) : base(context)
        {
        }

        // Adicionar métodos específicos para o repositório de Colaborador, se necessário.
    }
}
