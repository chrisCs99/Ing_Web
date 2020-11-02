using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Cita : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public OrdenServicio OrdenServicio { get; set; }
        public EstadoCita EstadoCita { get; set; }
        public DateTime? FechaVisita { get; private set; }
        public string Direccion { get; private set; }
        public string DescripcionCita { get; private set; }

        public Cita(OrdenServicio ordenServicio, DateTime? fechaVisita, string direccion, string descripcionCita)
        {
            CheckRule(new NotNullRule<string>(direccion));
            CheckRule(new NotNullRule<string>(descripcionCita));
            Id = Guid.NewGuid();
            OrdenServicio = ordenServicio;
            EstadoCita = EstadoCita.Aceptada;
            FechaVisita = fechaVisita;
            Direccion = direccion;
            DescripcionCita = descripcionCita;
        }

        protected Cita() { }

    }
}
