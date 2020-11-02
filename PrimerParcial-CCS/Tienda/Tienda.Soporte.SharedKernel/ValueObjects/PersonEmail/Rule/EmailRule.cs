using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Tienda.Soporte.SharedKernel.Core;

namespace Tienda.Soporte.SharedKernel.ValueObjects.PersonEmail.Rule
{
    class EmailRule : IBusinessRule
    {
        private readonly string _value;

        public EmailRule(string value)
        {
            _value = value;
        }

        public string Message => "El formato del correo es incorrecto";

        public bool IsBroken()
        {
            return !Regex.IsMatch(_value, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$");
        }
    }
}
