using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class CitaId : TypedIdValueBase
    {
        public CitaId(Guid value) : base(value) { }

        #region Conversion

        public static implicit operator Guid(CitaId value) => value.Value;

        public static implicit operator CitaId(Guid value) => new CitaId(value);

        #endregion
    }
}
