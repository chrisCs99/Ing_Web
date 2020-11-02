using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class OrdenServicioId : TypedIdValueBase
    {
        public OrdenServicioId(Guid value) : base(value) { }

        #region Conversion

        public static implicit operator Guid(OrdenServicioId value) => value.Value;

        public static implicit operator OrdenServicioId(Guid value) => new OrdenServicioId(value);

        #endregion
    }
}
