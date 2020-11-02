using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;
using Tienda.Soporte.SharedKernel.ValueObjects;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Producto : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string NombreProd { get; private set; }
        public string Categoria { get; private set; }

        public Producto(string nombreProd, string categoria)
        {
            CheckRule(new NotNullRule<string>(nombreProd));
            CheckRule(new NotNullRule<string>(categoria));
            Id = Guid.NewGuid();
            NombreProd = nombreProd;
            Categoria = categoria;
        }
    }
}
