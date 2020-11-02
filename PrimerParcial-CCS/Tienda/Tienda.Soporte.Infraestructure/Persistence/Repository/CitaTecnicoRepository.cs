using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;

namespace Tienda.Soporte.Infraestructure.Persistence.Repository
{
    public class CitaTecnicoRepository : ICitaTecnicoRepository
    {
        private readonly ApplicationDbContext _context;

        public CitaTecnicoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<CitaTecnico> GetCitaTecnico(Guid citaTecnicoId)
        {
            CitaTecnico obj =
                await _context.CitaTecnicos.Where(o => o.Id == citaTecnicoId).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(CitaTecnico citaTecnico)
        {
            await _context.CitaTecnicos.AddAsync(citaTecnico);
        }
    }
}
