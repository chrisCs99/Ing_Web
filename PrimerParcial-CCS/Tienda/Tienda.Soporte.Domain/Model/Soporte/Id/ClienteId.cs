using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Id
{
    public class ClienteId : TypedIdValueBase
    {
        public ClienteId(Guid value) : base (value) {}

        #region Conversion

        public static implicit operator Guid(ClienteId value) => value.Value;

        public static implicit operator ClienteId(Guid value) => new ClienteId(value);

        #endregion

    }
}
