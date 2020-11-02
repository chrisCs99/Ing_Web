using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Tienda.Soporte.SharedKernel.Core;
using Tienda.Soporte.SharedKernel.ValueObjects.PersonEmail.Rule;

namespace Tienda.Soporte.SharedKernel.ValueObjects.PersonEmail
{
    public class PersonEmailValue : ValueObject, IComparable<PersonEmailValue>
    {
        public string Value { get; private set; }

        public PersonEmailValue(string value)
        {
            CheckRule(new NotNullRule<string>(value));
            CheckRule(new EmailRule(value));
            Value = value;
        }

        #region Conversion

        public static implicit operator string(PersonEmailValue value) => value.Value;

        public static implicit operator PersonEmailValue(string value) => new PersonEmailValue(value);

        #endregion

        public int CompareTo([AllowNull] PersonEmailValue other) { 
            return Value.CompareTo(other.Value); 
        }
    }
}
