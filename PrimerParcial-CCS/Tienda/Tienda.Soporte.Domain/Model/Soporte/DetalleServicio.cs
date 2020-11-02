using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;
using Tienda.Soporte.SharedKernel.ValueObjects;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class DetalleServicio : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public TipoServicio TipoServicio { get; private set; }
        public double Precio { get; private set; }
        public OrdenServicio OrdenServicio { get; set; }
        public string Descripcion_Servicio { get; private set; }

        public DetalleServicio (TipoServicio tipoServicio, double precio, OrdenServicio ordenServicio, string descripcion_servicio)
        {
            CheckRule(new NotNullRule<string>(descripcion_servicio));
            Id = Guid.NewGuid();
            Precio = precio;
            TipoServicio = tipoServicio;
            OrdenServicio = ordenServicio;
            Descripcion_Servicio = descripcion_servicio;
        }
        protected DetalleServicio() { }
    }
}
