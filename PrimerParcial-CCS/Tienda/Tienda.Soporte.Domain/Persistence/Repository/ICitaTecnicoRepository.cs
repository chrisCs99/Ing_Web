using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface ICitaTecnicoRepository
    {
            Task Insert(CitaTecnico citaTecnico);

            Task<CitaTecnico> GetCitaTecnico(Guid citaTecnicoId);
        
    }
}
