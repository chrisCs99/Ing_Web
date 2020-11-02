using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class CitaTecnico : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public Cita Cita { get; set; }
        public Tecnico Tecnico { get; set; }

        public CitaTecnico(Cita cita, Tecnico tecnico)
        {
            Cita = cita;
            Tecnico = tecnico;
        }

        protected CitaTecnico() { }
    }
}
