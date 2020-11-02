using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface ICitaRepository
    {
        Task Insert(Cita cita);

        void Update(Cita cita);
        void Cancel(Cita cita);

        Task<Cita> GetCita(Guid citaId);

        Task<Cita> GetLastInsert();
    }
}
