using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class OrdenServicio : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public DateTime FechaRegistro { get; private set; }
        public Cliente Cliente { get; set; }
        public EstadoOrdenServicio EstadoOrden { get; set; }

        public OrdenServicio(Cliente cliente)
        {
            Id = Guid.NewGuid();
            FechaRegistro = DateTime.Now;
            Cliente = cliente;
            EstadoOrden = EstadoOrdenServicio.ENCURSO;
        }

        protected OrdenServicio() { }
    }
}
