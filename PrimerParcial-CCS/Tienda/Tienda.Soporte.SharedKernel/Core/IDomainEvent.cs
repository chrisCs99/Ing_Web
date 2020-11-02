using System;
using MediatR;

namespace Tienda.Soporte.SharedKernel.Core
{
    public interface IDomainEvent : INotification
    {
        DateTime OccurredOn { get; }
    }
}