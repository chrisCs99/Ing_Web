using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface IOrdenServicioRepository
    {
        Task Insert(OrdenServicio ordenServicio);

        void Update(OrdenServicio ordenServicio);

        Task<OrdenServicio> GetOrdenServicio(Guid ordenServicioId);

        void Cancel(OrdenServicio ordenServicio);
    }
}
