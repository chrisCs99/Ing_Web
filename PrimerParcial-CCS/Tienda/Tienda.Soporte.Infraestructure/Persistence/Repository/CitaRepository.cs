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
    public class CitaRepository : ICitaRepository
    {
        private readonly ApplicationDbContext _context;

        public CitaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Cancel(Cita cita)
        {
            _context.Citas.Update(cita);
        }

        public async Task<Cita> GetCita(Guid citaId)
        {
            Cita obj =
                await _context.Citas.Where(o => o.Id == citaId).FirstOrDefaultAsync();
            return obj;
        }

        public async Task<Cita> GetLastInsert()
        {
            Cita obj = await _context.Citas.LastOrDefaultAsync();
            return obj;
        }

        public async Task Insert(Cita cita)
        {
            await _context.Citas.AddAsync(cita);
        }

        public void Update(Cita cita)
        {
            _context.Citas.Update(cita);
        }
    }
}
