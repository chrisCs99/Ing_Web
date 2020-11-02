using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;
using Tienda.Soporte.SharedKernel.ValueObjects;
using Tienda.Soporte.SharedKernel.ValueObjects.PersonEmail;
using Tienda.Soporte.SharedKernel.ValueObjects.PhoneNumber;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Tecnico : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public PersonNameValue Nombres { get; private set; }
        public PersonNameValue Apellidos{ get; private set; }
        public PhoneNumberValue Telefono { get; private set; }
        public PersonEmailValue Correo{ get; private set; }
        public Oficios Oficio { get; private set; }

        public Tecnico(string nombres, string apellidos, string telefono,
            string correo, Oficios oficios)
        {
            Id = Guid.NewGuid();
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Correo = correo;
            Oficio = oficios;
        }

        protected Tecnico() { }
    }
}
