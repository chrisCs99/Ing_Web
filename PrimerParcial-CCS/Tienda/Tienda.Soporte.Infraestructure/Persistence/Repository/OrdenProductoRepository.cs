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
    public class OrdenProductoRepository : IOrdenProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public OrdenProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<OrdenProducto> GetOrdenProducto(Guid ordenProductoId)
        {
            OrdenProducto obj = await _context.OrdenProductos.Where(o => o.Id == ordenProductoId).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(OrdenProducto ordenProducto)
        {
            await _context.OrdenProductos.AddAsync(ordenProducto);
        }
    }
}
