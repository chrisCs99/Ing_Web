using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class OrdenProducto : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public DetalleServicio DetalleServicio { get; set; }
        public Producto Producto { get; set; }

        public OrdenProducto(DetalleServicio detalleServicio, Producto producto)
        {
            DetalleServicio = detalleServicio;
            Producto = producto;
        }

        protected OrdenProducto() { }
    }
}
