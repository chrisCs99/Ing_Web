using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class DetalleServicioId : TypedIdValueBase
    {
        public DetalleServicioId(Guid value) : base(value) { }

        #region Conversion

        public static implicit operator Guid(DetalleServicioId value) => value.Value;

        public static implicit operator DetalleServicioId(Guid value) => new DetalleServicioId(value);

        #endregion
    }
}
