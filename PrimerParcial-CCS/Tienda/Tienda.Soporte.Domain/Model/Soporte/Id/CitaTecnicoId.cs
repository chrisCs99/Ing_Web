using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class CitaTecnicoId : TypedIdValueBase
    {
        public CitaTecnicoId(Guid value) : base (value) { }
        
        #region Conversion

        public static implicit operator Guid(CitaTecnicoId value) => value.Value;

        public static implicit operator CitaTecnicoId(Guid value) => new CitaTecnicoId(value);

        #endregion
    }
}
