using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class ProductoId : TypedIdValueBase
    {
        public ProductoId(Guid value) : base(value) { }

        #region Conversion

        public static implicit operator Guid(ProductoId value) => value.Value;

        public static implicit operator ProductoId(Guid value) => new ProductoId(value);

        #endregion
    }
}
