using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;
using Tienda.Soporte.SharedKernel.ValueObjects;
using Tienda.Soporte.SharedKernel.ValueObjects.PersonEmail;
using Tienda.Soporte.SharedKernel.ValueObjects.PhoneNumber;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Cliente : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public PersonNameValue Nombres { get; private set; }
        public PersonNameValue Apellidos { get; private set; }
        public PhoneNumberValue Telefono { get; private set; }
        public PersonEmailValue Correo { get; private set; }
        public string Direccion { get; private set; }

        public Cliente(
            Guid id,
            string nombres,
            string apellidos,
            string telefono,
            string correo,
            string direccion
            )
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        protected Cliente() { }

        public void CrearCliente()
        {
            
        }
    }
}
