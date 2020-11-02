using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.SharedKernel.ValueObjects.Rule
{
    public class NameLengtRule : IBusinessRule
    {
        private readonly string _value;

        public NameLengtRule(string value)
        {
            _value = value;
        }

        public string Message => "El nombre no puede contener mas de 200 caracteres";

        public bool IsBroken() => _value.Length > 200;
    }
}
