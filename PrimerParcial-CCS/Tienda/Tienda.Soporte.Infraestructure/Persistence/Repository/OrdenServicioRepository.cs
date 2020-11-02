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
    public class OrdenServicioRepository : IOrdenServicioRepository
    {
        private readonly ApplicationDbContext _context;

        public OrdenServicioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Cancel(OrdenServicio ordenServicio)
        {
            _context.OrdenServicios.Update(ordenServicio);
        }

        public async Task<OrdenServicio> GetOrdenServicio(Guid ordenServicioId)
        {
            OrdenServicio obj =
                await _context.OrdenServicios.Where(o => o.Id == ordenServicioId).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(OrdenServicio ordenServicio)
        {
            await _context.OrdenServicios.AddAsync(ordenServicio);
        }

        public void Update(OrdenServicio ordenServicio)
        {
            _context.OrdenServicios.Update(ordenServicio);
        }
    }
}
