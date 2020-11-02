using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class FormTrabajoId : TypedIdValueBase
    {
        public FormTrabajoId(Guid value) : base(value) { }

        #region Conversion

        public static implicit operator Guid(FormTrabajoId value) => value.Value;

        public static implicit operator FormTrabajoId(Guid value) => new FormTrabajoId(value);

        #endregion
    }
}
