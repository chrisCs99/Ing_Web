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
    public class DetalleServicioRepository : IDetalleServicioRepository
    {
        private readonly ApplicationDbContext _context;

        public DetalleServicioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DetalleServicio> GetDetalleServicio(Guid detalleServicioId)
        {
            DetalleServicio obj =
                await _context.DetalleServicios.Where(o => o.Id == detalleServicioId).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(DetalleServicio detalleServicio)
        {
            await _context.DetalleServicios.AddAsync(detalleServicio);
        }
    }
}
