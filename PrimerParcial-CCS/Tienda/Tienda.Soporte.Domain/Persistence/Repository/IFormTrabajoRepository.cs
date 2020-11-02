using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface IFormTrabajoRepository
    {
        Task Insert(FormTrabajo formTrabajo);

        Task<FormTrabajo> GetFormTrabajo(Guid formTrabajoId);
    }
}
