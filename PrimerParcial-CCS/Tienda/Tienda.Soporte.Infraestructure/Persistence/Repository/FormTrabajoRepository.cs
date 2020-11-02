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
    public class FormTrabajoRepository : IFormTrabajoRepository
    {
        private readonly ApplicationDbContext _context;

        public FormTrabajoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<FormTrabajo> GetFormTrabajo(Guid formTrabajoId)
        {
            FormTrabajo obj =
                await _context.FormTrabajos.Where(o => o.Id == formTrabajoId).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(FormTrabajo formTrabajo)
        {
            await _context.FormTrabajos.AddAsync(formTrabajo);
        }
    }
}
