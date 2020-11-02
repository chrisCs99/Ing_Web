using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class FormTrabajo : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public Cita Cita { get; set; }
        public string DetalleTrabajo { get; private set; }
        public DateTime? FechaFormulario { get; private set; }

        public FormTrabajo(Cita cita, string detalleTrabajo, DateTime? fechaFormulario)
        {
            CheckRule(new NotNullRule<string>(detalleTrabajo));
            Id = Guid.NewGuid();
            Cita = cita;
            DetalleTrabajo = detalleTrabajo;
            FechaFormulario = fechaFormulario;
        }

        protected FormTrabajo() { }
    }
}
