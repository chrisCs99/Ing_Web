using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class TecnicoId : TypedIdValueBase
    {
        public TecnicoId(Guid value) : base(value) { }

        #region Conversion

        public static implicit operator Guid(TecnicoId value) => value.Value;

        public static implicit operator TecnicoId(Guid value) => new TecnicoId(value);

        #endregion
    }
}
