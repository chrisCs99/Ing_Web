using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class OrdenProductoId : TypedIdValueBase
    {
        public OrdenProductoId(Guid value) : base(value) { }

        #region Conversion

        public static implicit operator Guid(OrdenProductoId value) => value.Value;

        public static implicit operator OrdenProductoId(Guid value) => new OrdenProductoId(value);

        #endregion
    }
}
